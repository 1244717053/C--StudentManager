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
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }
        private static FrmStudentList formStudentList = null;
        public static FrmStudentList CreateInstance() 
        {
            // IsDisposed用来释放控件
            if (formStudentList == null || formStudentList.IsDisposed) 
            {
                formStudentList = new FrmStudentList();
            }
            return formStudentList;
        }

        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            // 加载班级信息
            InitClassInfo();

            // 加载全部信息
            InitStudentInfo();
        }

        private void InitStudentInfo()
        {
            string sql = "select [StuId],[StuName],[Sex],[ClassName],[Phone],[CreateTime] from [dbo].[StudentInfo] S inner join [dbo].[ClassInfo] C on S.ClassId = C.ClassId where [IsDeleted]=0; ";
            DataTable dt = SqlHelper.GetDataTable(sql);
            if (dt != null) 
            {
                dgv_StudentList.DataSource = dt;
            }
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

        private void Btu_select_Click(object sender, EventArgs e)
        {
            // 查询返回结果
            string StuName = Tx_Name.Text.Trim();
            int ClassId = (int)Cob_ClassName.SelectedValue;

            // 查询
            string sql = @"select [StuId],[StuName],[Sex],[ClassName],[Phone],[CreateTime] from [dbo].[StudentInfo] S inner join [dbo].[ClassInfo] C on S.ClassId = C.ClassId where S.ClassId = @ClassId and StuName = @StuName";
            SqlParameter[] paras =
            {
                new SqlParameter("@ClassId",ClassId),
                new SqlParameter("@StuName",StuName)
            };
            DataTable dt = SqlHelper.GetDataTable(sql,paras);
            dgv_StudentList.DataSource = dt;
        }

        private void Btu_Edite_Click(object sender, EventArgs e)
        {
            // 通过创建实体类进行值传递
            Student_Edite_Delete student_Edite_Delete = Student_Edite_Delete.Instance();
            student_Edite_Delete.Show();
        }
    }
}
