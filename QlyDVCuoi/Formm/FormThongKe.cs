using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QlyDVCuoi.Formm
{
 
    public partial class FormThongKe : Form
    {
        SqlConnection conn;
        private void openConnect()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-N64K7CG;Initial Catalog=QLY_TiemCuoi;Integrated Security=True;Encrypt=False");
            conn.Open();
        }
        private void closeConnect()
        {
            conn.Close();
        }
        CSDL c = new CSDL();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            dtThongKe.DataSource = c.ThongKe();

                openConnect();
                string sql = "select sum(Tong_Tien) from ChiTietHoaDon;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();
                float count = Convert.ToSingle(result);
                lbTong.Text = "Tổng hóa đơn: " + count;
        }

        private void FormThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void textTong_Load(object sender, EventArgs e)
        {
        }

        private void FormThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = false;
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;


                for (int i = 0; i < dtThongKe.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dtThongKe.Columns[i].HeaderText;
                }


                for (int i = 0; i < dtThongKe.Rows.Count; i++)
                {
                    for (int j = 0; j < dtThongKe.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtThongKe.Rows[i].Cells[j].Value;
                    }
                }


                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FileName = "ThongKe.xlsx";  
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                workbook.Close();
                excelApp.Quit();
                releaseObject(worksheet);
                releaseObject(workbook);
                releaseObject(excelApp);
            }
        }
        private void releaseObject(object obj)
{
    try
    {
        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
        obj = null;
    }
    catch (Exception ex)
    {

        obj = null;
        MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
    }
    finally
    {
        GC.Collect();
    }
}
    }
}
