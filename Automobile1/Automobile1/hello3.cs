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
using System.Security.Cryptography;

namespace Automobile1
{
    public partial class hello3 : Form
    {
        public hello3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IDBox.Text == "")
                MessageBox.Show("用户名不能为空！", "提示");
            else if (PwdBox.Text == "")
                MessageBox.Show("密码不能为空！", "提示");
            try //try...catch...异常处理语句
            {
                string name, pass;
                bool flag = false;
                name = IDBox.Text;
                pass = PwdBox.Text; //获取用户名，密码

                byte[] result = Encoding.Default.GetBytes(PwdBox.Text.Trim());

                MD5 md5 = new MD5CryptoServiceProvider();

                byte[] output = md5.ComputeHash(result);

                CheckPWD.Text = BitConverter.ToString(output).Replace("-", "");

                string str = "Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
                SqlConnection myConn = new SqlConnection(str);//创建数据库连接类的对象
                myConn.Open(); //将连接打开
                //SQL语句：从数据库的登录表中搜索登录名，密码
                string sqlstring = "select userid,userpwd from admininfo where userid='" + name + "'and userpwd='" + pass + "'";
                //执行con对象的函数，返回一个SqlCommand类型的对象
                SqlCommand command = new SqlCommand(sqlstring, myConn);
                //用cmd的函数执行语句，返回SqlDataReader对象thisReader,thisReader就是返回的结果集（也就是数据库中查询到的表数据）
                SqlDataReader thisReader = command.ExecuteReader();
                //判断用户名及密码是否正确，对flag进行赋值
                while (thisReader.Read())
                {
                    if ((thisReader.GetValue(0).ToString().Trim()) == (name.ToString().Trim()))
                    {
                        if (thisReader.GetValue(1).ToString().Trim() == pass.ToString().Trim())
                        {
                            flag = true;
                        }
                    }
                }
                //用完后关闭连接，以免影响其他程序访问
                myConn.Close();
                if (flag)
                {
                    MessageBox.Show("登录成功！");
                    login3 F = new login3(); //显示主页面
                    F.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("请检查你的用户名和密码!");
                    IDBox.Focus();
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("连接远程SQL数据库发生错误：" + ex2.ToString(), "错误！");
            }
        }

        private void PwdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
