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

namespace Automobile1
{
    public partial class automng : Form
    {
        public automng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            //name
            string selectsql = "Select * from automobileinfo where automobileinfo.ano = '" + textBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["ano"].ToString();
                textBox2.Text = sdr["aname"].ToString();
                textBox3.Text = sdr["mno"].ToString();
                textBox4.Text = sdr["aprice"].ToString();
                textBox5.Text = sdr["astatus"].ToString();
                
            }
            else
            {
                MessageBox.Show("找不到该车型信息！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string sql = string.Format("INSERT INTO automobileinfo (ano,aname,mno,aprice,astatus) values('{0}','{1}','{2}','{3}','{4}')",
            textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            MessageBox.Show("添加成功！");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = string.Format("UPDATE automobileinfo set aname='{0}',mno='{1}',aprice='{2}',astatus='{3}' where ano='{4}'",
                  textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox1.Text);

            SqlCommand cmd = new SqlCommand(sql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            MessageBox.Show("修改成功！");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = string.Format("DELETE FROM automobileinfo where ano='{0}'", textBox1.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            MessageBox.Show("删除成功！");
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            //name
            string selectsql = "Select * from automobileinfo where automobileinfo.aname like '%" + textBox2.Text + "%'";

            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["ano"].ToString();
                textBox2.Text = sdr["aname"].ToString();
                textBox3.Text = sdr["mno"].ToString();
                textBox4.Text = sdr["aprice"].ToString();
                textBox5.Text = sdr["astatus"].ToString();
            }
            else
            {
                MessageBox.Show("找不到该客户信息！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
