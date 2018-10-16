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
    public partial class sellmng : Form
    {
        public sellmng()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            //name
            string selectsql = "Select autosellinfo.*,aname from autosellinfo,automobileinfo where autosellinfo.asno = '" + textBox1.Text + "'and autosellinfo.ano=automobileinfo.ano";

            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                textBox1.Text = sdr["asno"].ToString();
                textBox2.Text = sdr["aname"].ToString();
                textBox3.Text = sdr["ascost"].ToString();
                textBox4.Text = sdr["asprice"].ToString();
                textBox5.Text = sdr["ano"].ToString();
                textBox6.Text = sdr["mno"].ToString();
                textBox7.Text = sdr["ascount"].ToString();
                textBox8.Text = sdr["asprofit"].ToString();
            }
            else
            {
                MessageBox.Show("找不到该销售信息！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string sql = string.Format("INSERT INTO autosellinfo (asno,ascost,asprice,ano,mno,ascount,asprofit) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            textBox1.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            conn.Close();
            
            /*str = @"Data Source=51WU;Initial Catalog=AutoMobile;User ID=sa;Password=wu777wow;";
            conn = new SqlConnection(str);
            conn.Open();

            sql = string.Format("INSERT INTO autosellinfo (asno,ano,mno,ascount,ascost,asprice,asprofit) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            textBox2.Text);
            cmd = new SqlCommand(sql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            
            sdr = cmd.ExecuteReader();
            conn.Close();*/

            MessageBox.Show("添加成功！");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = string.Format("UPDATE autosellinfo set ascost='{0}',asprice='{1}',ano='{2}',mno='{3}',ascount='{4}',asprofit='{5}' where asno='{6}'",
                  textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox1.Text);

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
            string sql = string.Format("DELETE FROM autosellinfo where asno='{0}'", textBox1.Text);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
