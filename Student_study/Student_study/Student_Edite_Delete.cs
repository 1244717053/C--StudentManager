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
    public partial class Student_Edite_Delete : Form
    {
        public Student_Edite_Delete()
        {
            InitializeComponent();
        }
        private static Student_Edite_Delete Frm_Student_Edite_Delete = null;

        // 创建单例模式
        public static Student_Edite_Delete Instance() 
        {
            if (Frm_Student_Edite_Delete == null || Frm_Student_Edite_Delete.IsDisposed) 
            {
                Frm_Student_Edite_Delete = new Student_Edite_Delete();
            }
            return Frm_Student_Edite_Delete;
        }

        private void Student_Edite_Delete_Load(object sender, EventArgs e)
        {
            InitLoad_CLassInfo();
        }

        private void InitLoad_CLassInfo()
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

        private void Btu_Edite_Click(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(Tx_StuId.Text.Trim());
            string StuName = Tx_StuName.Text.Trim();
            int ClassId = (int)Cob_ClassName.SelectedValue;
            string Sex = Rd_man.Checked ? Rd_man.Text : Rd_woman.Text;
            string Phone = Tx_Phone.Text.Trim();
            string sql = @"update [dbo].[StudentInfo] set [StuName]=@StuName,[ClassId]=@ClassId,[Sex]=Sex,[Phone]=@Phone where [StuId]=@StuId;";
            SqlParameter[] paras =
                {
                    new SqlParameter("@StuName",StuName),
                    new SqlParameter("@ClassId", ClassId),
                    new SqlParameter("@Sex", Sex),
                    new SqlParameter("@Phone", Phone),
                    new SqlParameter("@StuId",StuId)
                };
            int count = SqlHelper.ExecuteNonQuery(sql, paras);
            if (count > 0)
            {
                MessageBox.Show("修改成功！", "信息！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("修改失败！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Btu_Find_Click(object sender, EventArgs e)
        {
            // 获取学号信息
            if (string.IsNullOrEmpty(Tx_StuId.Text)) 
            {
                MessageBox.Show("查询不能为空！","警告！",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int StuId = Convert.ToInt32(Tx_StuId.Text.Trim());
            string StuName = null;
            string ClassName = null;
            string Sex = null;
            string Phone = null;
            // 数据库中查找信息
            string sql = @"select [StuName],[ClassName],[Sex],[Phone] from [dbo].[StudentInfo] S inner join [dbo].[ClassInfo] C 
            on S.ClassId=C.ClassId where [StuId]=@StuId and IsDeleted = 0 ;";

            SqlParameter[] paras =
            {
                new SqlParameter("@StuId",StuId)
            };
            DataTable dt = SqlHelper.GetDataTable(sql,paras);
            foreach (DataRow dr in dt.Rows)
            {
                StuName = dr["StuName"].ToString();
                ClassName = dr["ClassName"].ToString();
                Sex = dr["Sex"].ToString();
                Phone = dr["Phone"].ToString();
            }
            if (string.IsNullOrEmpty(StuName))
            {
                MessageBox.Show("查无此人！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tx_StuName.Text = "";
                Cob_ClassName.Text = "";
                Tx_Phone.Text = "";
                return;
            }
            Tx_StuName.Text = StuName;
            Cob_ClassName.Text = ClassName;
            if (Sex == "男")
            {
                Rd_man.Checked = true;
            }
            else 
            {
                Rd_woman.Checked = true;
            }
            Tx_Phone.Text = Phone;
        }

        private void Btu_Delete_Click(object sender, EventArgs e)
        {
            int StuId = Convert.ToInt32(Tx_StuId.Text.Trim());
            string sql = @"update StudentInfo set IsDeleted=1 where StuId = @StuId";
            SqlParameter[] paras =
            {
                new SqlParameter("@StuId",StuId)
            };
            int count = SqlHelper.ExecuteNonQuery(sql, paras);
            if (count > 0)
            {
                MessageBox.Show("删除成功！", "信息！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("删除失败！", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
