using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_study
{
    public partial class FrmGradeList : Form
    {
        public FrmGradeList()
        {
            InitializeComponent();
        }
        // 创建单例模式
        private static FrmGradeList frmGradeList = null;
        public static FrmGradeList CreateInstance() {
            if (frmGradeList == null || frmGradeList.IsDisposed) 
            {
                frmGradeList = new FrmGradeList();
            }
            return frmGradeList;
        }
        /// <summary>
        /// 通过load事件可以实现数据的加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FrmGradeList_Load(object sender, EventArgs e)
        {
            string sql = "select GradeId, GradeName from GradeInfo";
            DataTable dt = SqlHelper.GetDataTable(sql);
            dgvGradeList.DataSource = dt;
        }
    }
}
