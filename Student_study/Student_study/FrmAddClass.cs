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
    public partial class FrmAddClass : Form
    {
        public FrmAddClass()
        {
            InitializeComponent();
        }
        private static FrmAddClass formAddClass = null;
        /// <summary>
        /// 创建单例模式
        /// </summary>
        /// <returns></returns>
        public static FrmAddClass CreateInstance() 
        {
            if (formAddClass == null || formAddClass.IsDisposed) {
                formAddClass = new FrmAddClass();
            }
            return formAddClass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ClassName = Tx_ClassName.Text.Trim();
            int GradeId = (int)cobGrade_list.SelectedValue;
            string Remark = Rt_Remark.Text.Trim();
            if (string.IsNullOrEmpty(ClassName)) 
            {
                MessageBox.Show("班级名称不能为空","添加班级提示",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 判断是否已存在
            {
                string sql = @"select count(1) from [dbo].[ClassInfo] where [ClassName]= @ClassName and [GradeId] = @GradeId;";
                SqlParameter[] param =
                {
                    new SqlParameter("@ClassName", ClassName),
                    new SqlParameter("@GradeId", GradeId)
                };
                
                // 查询
                int result = (int)SqlHelper.ExcuteScalar(sql, param);
                

                // 如果存在，返回注册失败
                if(result != 0) 
                {
                    MessageBox.Show("该班级信息已被注册！","重复注册警告！",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //如果不存在，则进行插入操作
                string inser_sql = @"insert into [dbo].[ClassInfo]([ClassName],[GradeId],[Remark])values(@ClassName,@GradeId,@Remark); ";
                SqlParameter[] paras =
                {
                    new SqlParameter("@ClassName", ClassName),
                    new SqlParameter("@GradeId", GradeId),
                    new SqlParameter("@Remark", Remark)
                };
                int count = SqlHelper.ExecuteNonQuery(inser_sql, paras);

                if (count > 0) 
                {
                    MessageBox.Show("数据添加成功！","添加信息", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }

        }

        private void FrmAddClass_Load(object sender, EventArgs e)
        {
            // 获取年级列表数据
            InitGetGrade();
        }

        private void InitGetGrade()
        {
            string sql = "select GradeId,GradeName from [dbo].[GradeInfo] ";
            CommonData.GradeInfo = SqlHelper.GetDataTable(sql);
            cobGrade_list.DataSource = CommonData.GradeInfo;
            cobGrade_list.DisplayMember = "GradeName";
            cobGrade_list.ValueMember = "GradeId";
        }
    }
}
