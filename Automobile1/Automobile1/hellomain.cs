using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile1
{
    public partial class hellomain : Form
    {
        public hellomain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hello1 F = new hello1(); //显示主页面
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hello2 F = new hello2(); //显示主页面
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hello3 F = new hello3(); //显示主页面
            F.Show();
        }
    }
}
