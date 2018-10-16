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
    public partial class manumng : Form
    {
        public manumng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            //name
            string selectsql = "Select * from manufacturerinfo where manufacturerinfo.mno = '" + textBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["mno"].ToString();
                textBox2.Text = sdr["mname"].ToString();
                textBox3.Text = sdr["maddr"].ToString();
                textBox4.Text = sdr["mstatus"].ToString();
                textBox5.Text = sdr["mcount"].ToString();
                textBox6.Text = sdr["mtel"].ToString();
            }
            else
            {
                MessageBox.Show("找不到该厂商信息！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string sql = string.Format("INSERT INTO manufacturerinfo (mno,mname,maddr,mstatus,mcount,mtel) values('{0}','{1}','{2}','{3}','{4}','{5}')",
            textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
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
            string sql = string.Format("UPDATE manufacturerinfo set mname='{0}',maddr='{1}',mstatus='{2}',mcount='{3}',mtel='{4}' where mno='{5}'",
                  textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox1.Text);

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
            string sql = string.Format("DELETE FROM manufacturerinfo where mno='{0}'", textBox1.Text);
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
            string selectsql = "Select * from manufacturerinfo where manufacturerinfo.mname like '%" + textBox2.Text + "%'";

            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["mno"].ToString();
                textBox2.Text = sdr["mname"].ToString();
                textBox3.Text = sdr["maddr"].ToString();
                textBox4.Text = sdr["mstatus"].ToString();
                textBox5.Text = sdr["mcount"].ToString();
                textBox6.Text = sdr["mtel"].ToString();
            }
            else
            {
                MessageBox.Show("找不到该厂商信息！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
