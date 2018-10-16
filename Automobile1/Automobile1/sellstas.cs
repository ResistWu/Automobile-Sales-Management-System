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
    public partial class sellstas : Form
    {
        public sellstas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=51WU;Initial Catalog=automobile111;User ID=sa;Password=wu777wow;";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            DataSet dataset = new DataSet();
            string selectsql = "Select * from autosellinfo ";
            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter dr;
            dr = new SqlDataAdapter(cmd);
            dr.Fill(dataset);
            ExportExcel(dataset, "F:\\销售情况统计.xlsx");
            conn.Close();
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

        private void sellstas_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“automobile111DataSet7.autosellinfo”中。您可以根据需要移动或删除它。
            this.autosellinfoTableAdapter.Fill(this.automobile111DataSet7.autosellinfo);

        }
    }
}
