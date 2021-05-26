using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Student_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取用户名
            string userName = UserName.Text.Trim();
            string userPwd = Pwd.Text.Trim();
            // 判断是否为空
            if (string.IsNullOrEmpty(userName)) 
            {
                MessageBox.Show("用户名为空","登陆提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                UserName.Focus(); // 为控件设置焦点
                return;
            }
            if (string.IsNullOrEmpty(userPwd))
            {
                MessageBox.Show("用户名为空", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pwd.Focus(); // 为控件设置焦点
                return;
            }
            // 与数据库通讯
            {
                string sql = "select count(1) from UserInfo where UserName = @userName and UserPwd = @userPwd ";
                //添加参数
                SqlParameter[] paras = {
                    new SqlParameter("@userName", userName),
                    new SqlParameter("@userPwd", userPwd)
            };
               
                //打开连接,最晚打开，最早关闭
                try
                {
                    //SqlHelper db_conn = new SqlHelper(); 静态方法调用不需要进行实例化
                    object o = SqlHelper.ExcuteScalar(sql, paras);
                    if (o == null || o == DBNull.Value || (int)o == 0)
                    {
                        MessageBox.Show("查找错误", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int count = (int)o;
                        MessageBox.Show("登陆成功", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Main mainForm = new Main();
                        mainForm.Show();
                        this.Hide();
                    }


                }
                catch(Exception ex) 
                {
                    MessageBox.Show("查找错误", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // 返回结果进行不同的提示
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();// 主页面使用Close() 进行退出
            //Application.Exit();
        }
    }
}
