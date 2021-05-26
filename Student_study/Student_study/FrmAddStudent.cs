using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_study
{
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }
        //通过单例模式实现只能打开一个FrmAddStudent的实例
        private static FrmAddStudent frmAddStudent = null;
        public static FrmAddStudent CreateInstance()
        {
            if (frmAddStudent == null || frmAddStudent.IsDisposed) 
            {
                frmAddStudent = new FrmAddStudent();
            }
            return frmAddStudent;
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            InitClassInfo();
        }

        private void InitClassInfo()
        {
            string sql = "select ClassName,GradeName,ClassId from [dbo].[ClassInfo] C inner join [dbo].[GradeInfo] G on C.GradeId = G.GradeId";
            DataTable dt = SqlHelper.GetDataTable(sql);

            // 信息中加上年级信息
            foreach (DataRow dr in dt.Rows)
            {
                string className = dr["ClassName"].ToString();
                string GradeName = dr["GradeName"].ToString();
                dr["ClassName"] = className + "-" + GradeName;
            }
            Cob_ClassName.DataSource = dt;
            Cob_ClassName.DisplayMember = "ClassName";
            Cob_ClassName.ValueMember = "ClassId";
        }

        private void Btu_AddStudent_Click(object sender, EventArgs e)
        {
            // 判空
            string StuName = Tx_StuName.Text.Trim();
            string Phone = Tx_Phone.Text.Trim();
            int ClassId = (int)Cob_ClassName.SelectedValue;
            string Sex = Rd_man.Checked ? Rd_man.Text : Rd_woman.Text;

            if (String.IsNullOrEmpty(StuName) || String.IsNullOrEmpty(Phone))
            {
                MessageBox.Show("信息不能为空！", "内容为空警告！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else 
            {
                // 判断是否已经存在于学生信息表
                int count = 0;
                string sql = "select count(1) from [dbo].[StudentInfo] where [StuName] = @StuName and [Phone] = @Phone;";
                SqlParameter[] paras =
                {
                    new SqlParameter("@StuName",StuName),
                    new SqlParameter("@Phone",Phone)
                };
                count = (int)SqlHelper.ExcuteScalar(sql,paras);
                if (count > 0) 
                {
                    MessageBox.Show("学生信息已存在！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 如果不存在于学生信息表
                string sql_insert = @"insert into [dbo].[StudentInfo]([StuName],[ClassId],[Sex],[Phone],[CreateTime])values(@StuName,@ClassId, @Sex,@Phone,@Time);";
                SqlParameter[] paras_insert =
                    {
                        new SqlParameter("@StuName",StuName),
                        new SqlParameter("@ClassId",ClassId),
                        new SqlParameter("@Sex",Sex),
                        new SqlParameter("@Phone",Phone),
                        new SqlParameter("@Time",DateTime.Now.ToString("yyyyMMdd"))
                    };

                // 插入成功！
                int Count = SqlHelper.ExecuteNonQuery(sql_insert, paras_insert);
                if (Count > 0)
                {
                    MessageBox.Show("数据插入成功！", "信息输入成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
