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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void IMexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Student_Click(object sender, EventArgs e)
        {
            //FrmAddStudent AddForm = new FrmAddStudent();
            //使用单例模式创建实例,调用静态方法，就不需要进行实例创建了
            FrmAddStudent AddForm = FrmAddStudent.CreateInstance();
            AddForm.MdiParent = this; // 当前窗体是父窗体
            AddForm.Show();
            AddForm.Activate();
        }

        private void Student_List_Click(object sender, EventArgs e)
        {
            //FrmStudentList StuList = new FrmStudentList();
            //使用单例模式创建实例,调用静态方法，就不需要进行实例创建了
            FrmStudentList StuList = FrmStudentList.CreateInstance();
            StuList.MdiParent = this; // 当前窗体是父窗体
            StuList.Show();
            StuList.Activate();
        }

        /// <summary>
        /// 新增班级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClass_Click(object sender, EventArgs e)
        {
            FrmAddClass formAddClass = FrmAddClass.CreateInstance();
            formAddClass.MdiParent = this;
            formAddClass.Show();
            formAddClass.Activate();
        }
        /// <summary>
        /// 查看班级列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Class_List_Click(object sender, EventArgs e)
        {
            FrmClassList formClassList = FrmClassList.CreateInstance();
            formClassList.MdiParent = this;
            formClassList.Show();
            formClassList.Activate();
        }
        /// <summary>
        /// 主窗体退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();// 退出当前线程上的消息循环
        }

        private void Grade_List_Click(object sender, EventArgs e)
        {
           FrmGradeList formGradeList = FrmGradeList.CreateInstance();
            formGradeList.MdiParent = this;
            formGradeList.Show();
            formGradeList.Activate();
        }
        /// <summary>
        /// 注意这里是FormClosing()事件触发的结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否要退出？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();// 退出当前线程上的消息循环
            }
            else
            {
                e.Cancel = true;// 取消该事件的触发
            }
        }
    }
}
