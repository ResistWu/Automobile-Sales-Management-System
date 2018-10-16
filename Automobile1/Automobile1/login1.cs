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
    public partial class login1 : Form
    {
        public login1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientmng F = new clientmng(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellmng F = new sellmng(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            clientstas F = new clientstas(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manumng F = new manumng(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            automng F = new automng(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ordermng F = new ordermng(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            storagemng F = new storagemng(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            sellstas F = new sellstas(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            manustas F = new manustas(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            autostas F = new autostas(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            orderstas F = new orderstas(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            storagestas F = new storagestas(); //显示主页面
            F.Show();
           // this.Hide();
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            clientstas F = new clientstas(); //显示主页面
            F.Show();
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
           sellstas F = new sellstas(); //显示主页面
            F.Show();
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            manustas F = new manustas(); //显示主页面
            F.Show();
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
           autostas F = new autostas(); //显示主页面
            F.Show();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            orderstas F = new orderstas(); //显示主页面
            F.Show();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            storagestas F = new storagestas(); //显示主页面
            F.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string a = "F://test";
            BackUpDataBase(a);

        }
        public bool BackUpDataBase(string databasefile)
        {
            string st = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(st);

           
            //还原的数据库MyDataBase
            string sql = "BACKUP DATABASE " + "AutoMobile" + " TO DISK = '" + databasefile + ".bak' ";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.Text;
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                string str = err.Message;
                conn.Close();

                return false;
            }

            conn.Close();//关闭数据库连接
            MessageBox.Show("备份成功！F:\\test.bak", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string path = "F:\\test.bak";
            RestoreDatabase(path);
        }

        public string RestoreDatabase(string backfile)
        {
            ///杀死原来所有的数据库连接进程
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=51WU;Initial Catalog=master;User ID=sa;Password=wu777wow;";
            conn.Open();
            string strSQL = "select spid from master..sysprocesses where dbid=db_id('AutoMobile')";
            SqlDataAdapter Da = new SqlDataAdapter(strSQL, conn);

            DataTable spidTable = new DataTable();
            Da.Fill(spidTable);

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = conn;

            for (int iRow = 0; iRow <= spidTable.Rows.Count - 1; iRow++)
            {
                Cmd.CommandText = "kill " + spidTable.Rows[iRow][0].ToString(); //强行关闭用户进程
                Cmd.ExecuteNonQuery();
            }

            //这里一定要是master数据库，而不能是要还原的数据库，因为这样便变成了有其它进程
            //占用了数据库。
            string constr = @"Data Source=51WU;Initial Catalog=master;User ID=sa;Password=wu777wow;";
            string database = "test";
            string path = backfile;
            string BACKUP = String.Format("use master RESTORE DATABASE {0} FROM DISK = '{1}'", database, path);
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(BACKUP, con);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("还原成功,点击退出系统！");
                Application.Exit();
            }
            catch (SqlException ee)
            {

                MessageBox.Show(ee.ToString());

            }
            finally
            {
                con.Close();
            }
            return "成功与否字符串";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            if (this.NewPass.Text.Trim().ToString() == "" || this.NewPass.Text.Trim().ToString() == null)
            {
                MessageBox.Show("新密码不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.NewPass.Focus();
                return;
            }
            else if (this.NewPassOK.Text.Trim().ToString() == "" || this.NewPassOK.Text.Trim().ToString() == null)
            {
                MessageBox.Show("确认密码不能为空！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.NewPassOK.Focus();
                return;
            }
            else if (this.NewPass.Text.Trim().ToString() != this.NewPassOK.Text.Trim().ToString())
            {
                MessageBox.Show("您输入的两次密码不一致！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.NewPass.Text = "";
                this.NewPassOK.Text = "";
                return;
            }
            else
            {
                string sql = string.Format("UPDATE admininfo set userpwd='{0}' where userid='{1}'",
                 NewPass.Text, textBox2.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                MessageBox.Show("密码修改成功！");
            }

            //try
            //{
            //    int row = sqlCmd.ExecuteNonQuery();
            //if (row == 1)
            //    MessageBox.Show("添加成功！");
            // }
            //catch (SqlException ex)
            //{
            //     MessageBox.Show("更新错误" + ex.Message, "出现错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally

            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //复选框被勾选，明文显示  
                NewPass.PasswordChar = new char();
            }
            else
            {
                //复选框被取消勾选，密文显示  
                NewPass.PasswordChar = '*';
            }  
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //复选框被勾选，明文显示  
                NewPassOK.PasswordChar = new char();
            }
            else
            {
                //复选框被取消勾选，密文显示  
                NewPassOK.PasswordChar = '*';
            }  
        }

        private void login1_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“automobile111DataSet1.admininfo”中。您可以根据需要移动或删除它。
            this.admininfoTableAdapter.Fill(this.automobile111DataSet1.admininfo);
            // TODO:  这行代码将数据加载到表“automobile111DataSet.userinfo”中。您可以根据需要移动或删除它。
           // this.admininfoTableAdapter.Fill(this.automobile111DataSet.admininfo);

        }


        public static string MD5Encrypt16(string password)
        {
            var md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes(password)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);

            conn.Open();
            string selectsql = "Select userpwd from admininfo where admininfo.userid='superadmin'";
            
            Convert.ToString(selectsql);
            string t2=MD5Encrypt16(selectsql);

            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox4.Text = t2;
            }
            conn.Close();

            conn.Open();
            string selectsql2 = "Select authority from admininfo where admininfo.userid='superadmin'";
            cmd = new SqlCommand(selectsql2, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox5.Text = sdr["authority"].ToString();
            }
            conn.Close();

            conn.Open();
            selectsql = "Select userpwd from admininfo where admininfo.userid='admin'";

            Convert.ToString(selectsql);
            string t3 = MD5Encrypt16(selectsql);

            cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox7.Text = t3;
            }
            conn.Close();

            conn.Open();
            string selectsql3 = "Select authority from admininfo where admininfo.userid='admin'";
            cmd = new SqlCommand(selectsql3, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox8.Text = sdr["authority"].ToString();
            }
            conn.Close();

            conn.Open();
            selectsql = "Select userpwd from admininfo where admininfo.userid='user'";

            Convert.ToString(selectsql);
            string t4 = MD5Encrypt16(selectsql);

            cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox10.Text = t4;
            }
            conn.Close();

            conn.Open();
            string selectsql4 = "Select authority from admininfo where admininfo.userid='user'";
            cmd = new SqlCommand(selectsql4, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox11.Text = sdr["authority"].ToString();
            }
            conn.Close();
        }


       
    }
}
