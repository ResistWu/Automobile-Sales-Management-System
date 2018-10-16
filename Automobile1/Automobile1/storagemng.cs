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
    public partial class storagemng : Form
    {
        public storagemng()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            //name
            string selectsql = "Select * from storageinfo where storageinfo.sno = '" + textBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["sno"].ToString();
                textBox2.Text = sdr["saddr"].ToString();
                textBox3.Text = sdr["simport"].ToString();
                textBox4.Text = sdr["sexport"].ToString();
                textBox5.Text = sdr["scount"].ToString();
                textBox6.Text = sdr["stel"].ToString();
            }
            else
            {
                MessageBox.Show("找不到该仓库信息！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string sql = string.Format("INSERT INTO storageinfo (sno,saddr,simport,sexport,scount,stel) values('{0}','{1}','{2}','{3}','{4}','{5}')",
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
            string sql = string.Format("UPDATE storageinfo set saddr='{0}',simport='{1}',sexport='{2}',scount='{3}',stel='{4}' where sno='{5}'",
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
            string sql = string.Format("DELETE FROM storageinfo where sno='{0}'", textBox1.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            MessageBox.Show("删除成功！");
            conn.Close();
        }

        private void storagemng_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
