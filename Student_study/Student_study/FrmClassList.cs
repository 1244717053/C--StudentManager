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
    public partial class FrmClassList : Form
    {
        public FrmClassList()
        {
            InitializeComponent();
        }
        private static FrmClassList frmClassList = null;
        /// <summary>
        /// 创建单例模式
        /// </summary>
        /// <returns>单例模式下的单个实例</returns>
        public static FrmClassList CreateInstance() 
        {
            if (frmClassList == null || frmClassList.IsDisposed) 
            {
                frmClassList = new FrmClassList();
            }
            return frmClassList;
        }

        private void FrmClassList_Load(object sender, EventArgs e)
        {
            // 初始化年级列表何班级列表， 快捷方式生成初始化方法InitFuncitonName()
            InitGradeList(); //加载年级列表 
            InitClassInfo(); // 加载所有班级信息
        }

        // 加载所有的班级信息
        private void InitClassInfo()
        {
            // 联合查询
            string sql = "select [ClassId],[ClassName],[GradeName],[Remark] from [dbo].[GradeInfo] G inner join[dbo].[ClassInfo] C on G.GradeId = C.GradeId; ";
            DataTable dt = SqlHelper.GetDataTable(sql);
            dgv_ClassInfo.DataSource = dt;
        }

        // 初始化所有的年级信息
        private void InitGradeList()
        {
            string sql = "select GradeId,GradeName from [dbo].[GradeInfo] ";
            CommonData.GradeInfo = SqlHelper.GetDataTable(sql);
            
            // 数据源绑定
            Cob_gradeList.DataSource = CommonData.GradeInfo;

            // 单一项绑定
            Cob_gradeList.DisplayMember = "GradeName"; // 显示的内容

            Cob_gradeList.ValueMember = "GradeId"; // 值

        }

        private void Btn_select_Click(object sender, EventArgs e)
        {
            // 进行联合查询
            int GradeId = (int)Cob_gradeList.SelectedValue;
            string ClassName = Tx_ClassName.Text;

            //  传递参数
            string sql = @"select [ClassId],[ClassName],[GradeId],[Remark] from [dbo].[ClassInfo] G 
            where [GradeId] = @GradeId and [ClassName] = @ClassName;";
            SqlParameter[] paras =
            {
                new SqlParameter("@GradeId", GradeId),
                new SqlParameter("@ClassName", ClassName)
            };
           DataTable dt = SqlHelper.GetDataTable(sql, paras);
           dgv_ClassInfo.DataSource = dt;
           
        }

        private void dgv_ClassInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
