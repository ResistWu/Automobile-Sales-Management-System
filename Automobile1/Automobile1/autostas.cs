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
using System.Drawing.Drawing2D;

namespace Automobile1
{
    public partial class autostas : Form
    {
        public autostas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public string ExportExcel(DataSet ds, string saveFileName)
        {

            try
            {
                if (ds == null)
                    return "数据库为空";

                bool fileSaved = false;
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    return "无法创建Excel对象，可能您的机子未安装Excel";
                }
                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
                //写入字段
                for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = ds.Tables[0].Columns[i].ColumnName;
                }
                //写入数值
                for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
                {
                    for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                    {
                        worksheet.Cells[r + 2, i + 1] = ds.Tables[0].Rows[r][i];
                    }
                    System.Windows.Forms.Application.DoEvents();
                }
                worksheet.Columns.EntireColumn.AutoFit();//列宽自适应。
                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);
                        fileSaved = true;
                    }
                    catch (Exception ex)
                    {
                        fileSaved = false;
                        MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                    }
                }
                else
                {
                    fileSaved = false;
                }
                xlApp.Quit();
                GC.Collect();//强行销毁
                if (fileSaved && System.IO.File.Exists(saveFileName)) System.Diagnostics.Process.Start(saveFileName); //打开EXCEL
                return "成功保存到Excel";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        private void autostas_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“automobile111DataSet4.automobileinfo”中。您可以根据需要移动或删除它。
            this.automobileinfoTableAdapter.Fill(this.automobile111DataSet4.automobileinfo);

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            int height = 500, width = 700;
            Bitmap image = new Bitmap(width, height);
            //创建Graphics类对象
            Graphics g = Graphics.FromImage(image);

            try
            {
               // 清空图片背景色
                g.Clear(Color.White);

                Font font = new Font("Arial", 10, FontStyle.Regular);
                Font font1 = new Font("宋体", 20, FontStyle.Bold);

                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height),
                Color.Blue, Color.BlueViolet, 1.2f, true);
                g.FillRectangle(Brushes.WhiteSmoke, 0, 0, width, height);
                 Brush brush1 = new SolidBrush(Color.Blue);

                g.DrawString(" 年龄分布柱状图", font1, brush, new PointF(70, 30));
                //画图片的边框线
                g.DrawRectangle(new Pen(Color.Blue), 0, 0, image.Width - 1, image.Height - 1);


                Pen mypen = new Pen(brush, 1);
               // 绘制线条
                //绘制横向线条
                int x = 100;
                for (int i = 0; i < 14; i++)
                {
                    g.DrawLine(mypen, x, 80, x, 340);
                    x = x + 40;
                }
                Pen mypen1 = new Pen(Color.Blue, 2);
                x = 60;
                g.DrawLine(mypen1, x, 80, x, 340);

                //绘制纵向线条
                int y = 106;
                for (int i = 0; i < 9; i++)
                {
                    g.DrawLine(mypen, 60, y, 620, y);
                    y = y + 26;
                }
                g.DrawLine(mypen1, 60, y, 620, y);

               // x轴
                String[] n = { "<20", "20-30", "30-40", "40-50", "50-60", "60-70", ">70" };
                x = 78;
                for (int i = 0; i < 7; i++)
                {
                    g.DrawString(n[i].ToString(), font, Brushes.Blue, x, 348); //设置文字内容及输出位置
                    x = x + 78;
                }

                //y轴
                String[] m = {" 10"," 9", " 8", " 7", " 6", " 5", " 4", " 3"," 2", " 1", " 0"};
                y = 72;
                for (int i = 0; i < 10; i++)
                {
                    g.DrawString(m[i].ToString(), font, Brushes.Blue, 25, y); //设置文字内容及输出位置
                    y = y + 26;
                }

                int[] Count1 = new int[7];
           

                

                string cmdtxt2 = "SELECT * FROM clientstatus ";
                SqlDataAdapter da = new SqlDataAdapter(cmdtxt2, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Count1[0] = Convert.ToInt32(ds.Tables[0].Rows[0]["<20"].ToString());
                Count1[1] = Convert.ToInt32(ds.Tables[0].Rows[0]["20-30"].ToString());
                Count1[2] = Convert.ToInt32(ds.Tables[0].Rows[0]["30-40"].ToString());
                Count1[3] = Convert.ToInt32(ds.Tables[0].Rows[0]["40-50"].ToString());
                Count1[4] = Convert.ToInt32(ds.Tables[0].Rows[0]["50-60"].ToString());
                Count1[5] = Convert.ToInt32(ds.Tables[0].Rows[0]["60-70"].ToString());
                Count1[6] = Convert.ToInt32(ds.Tables[0].Rows[0][">70"].ToString());


                //绘制柱状图.
                x = 80;
                Font font2 = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                SolidBrush mybrush = new SolidBrush(Color.Red);
                SolidBrush mybrush2 = new SolidBrush(Color.Green);

               // 一
                g.FillRectangle(mybrush, x, 340 - Count1[0], 20, Count1[0]);
                g.DrawString(Count1[0].ToString(), font2, Brushes.Red, x, 340 - Count1[0] - 15);

             


               // 二
                x = x + 60;
                g.FillRectangle(mybrush, x, 340 - Count1[1], 20, Count1[1]);
                g.DrawString(Count1[1].ToString(), font2, Brushes.Red, x, 340 - Count1[1] - 15);


              


               // 三
                x = x + 60;
                g.FillRectangle(mybrush, x, 340 - Count1[2], 20, Count1[2]);
                g.DrawString(Count1[2].ToString(), font2, Brushes.Red, x, 340 - Count1[2] - 15);

               

               // 四
                x = x + 60;
                g.FillRectangle(mybrush, x, 340 - Count1[3], 20, Count1[3]);
                g.DrawString(Count1[3].ToString(), font2, Brushes.Red, x, 340 - Count1[3] - 15);

              

               // 五
                x = x + 60;
                g.FillRectangle(mybrush, x, 340 - Count1[4], 20, Count1[4]);
                g.DrawString(Count1[4].ToString(), font2, Brushes.Red, x, 340 - Count1[4] - 15);

               

               // 六
                x = x + 60;
                g.FillRectangle(mybrush, x, 340 - Count1[5], 20, Count1[5]);
                g.DrawString(Count1[5].ToString(), font2, Brushes.Red, x, 340 - Count1[5] - 15);

              

               // 七
                x = x + 60;
                g.FillRectangle(mybrush, x, 340 - Count1[6], 20, Count1[6]);
                g.DrawString(Count1[6].ToString(), font2, Brushes.Red, x, 340 - Count1[6] - 15);


             
            
               //// 绘制标识
               // Font font3 = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
               // g.DrawRectangle(new Pen(Brushes.Blue), 170, 400, 250, 50); //绘制范围框
               // g.FillRectangle(Brushes.Red, 270, 410, 20, 10); //绘制小矩形
                

               // g.FillRectangle(Brushes.Green, 270, 430, 20, 10);
               // g.DrawString("通过人数", font3, Brushes.Green, 292, 428);

               // System.IO.MemoryStream ms = new System.IO.MemoryStream();
               // image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
               // Response.ClearContent();
               // Response.ContentType = "image/Jpeg";
               // Response.BinaryWrite(ms.ToArray());

                conn.Close();
            }

            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            DataSet dataset = new DataSet();
            string selectsql = "Select * from automobileinfo ";
            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dr;
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dataset);
            ExportExcel(dataset, "F:\\汽车信息统计.xlsx");
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
