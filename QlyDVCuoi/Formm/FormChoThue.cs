using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;
using Microsoft.Office.Interop.Word;
//using FastReport.RichTextParser;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using _Application = Microsoft.Office.Interop.Word._Application;
using System.Web.UI.WebControls;

namespace QlyDVCuoi.Formm
{
    public partial class FormChoThue : Form
    {
        CSDL db = new CSDL();
        public FormChoThue()
        {
            InitializeComponent();
        }
        private void FormChoThue_Load(object sender, EventArgs e)
        {
            cbMaD.SelectedIndex = -1;
            table.DataSource = db.HopDong();
            cbMaD.DataSource = db.Do_DL_cbMaDon();
            cbMaD.DisplayMember = "Ma_Don";
            cbMaD.ValueMember = "Ma_Don";
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        /*bool kiemtra_du_lieu()
        {
           *//* if (kiemtra(txtMaKH.Text) || kiemtra(txtTenKH.Text) || kiemtra(txtSDT.Text) || kiemtra(txtDC.Text) || kiemtra(txtMaDV.Text) || kiemtra(txtTenDV.Text) || kiemtra(txtDgia.Text))
            {
                return false;
            }
            return true;*//*
        }*/
        void reset()
        {
            /*txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDC.ResetText();
            txtMaDV.ResetText();
            txtTenDV.ResetText();
            txtDgia.ResetText();*/
        }
        private void HienThongBaoLoi(string thuocTinh, string thongBao)
        {
            MessageBox.Show($"Lỗi ở thuộc tính '{thuocTinh}': {thongBao}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnChothue_Click(object sender, EventArgs e)
        {
            string html = "<p style='width:100%;margin-left:auto;margin-right:auto;font-size:22px;font-weight:bold;text-align:center'>HỢP ĐỒNG SỬ DỤNG DỊCH VỤ CƯỚI HỎI TRỌN GÓI</p>";
            html += "<table cellpadding='5' cellspacing='0' style='border:1px solid black;font-size:9pt;font-family:TimeNewRoman;width:100%;margin-left:auto;margin-right:auto'>";
            html += "<tr>";
            foreach (DataGridViewColumn column in table.Columns)
            {
                html += "<th style='background-color:#B8DBFD;border:1px solid black'>" + column.HeaderText + "</th>";
            }
            html += "</tr>";
            foreach (DataGridViewRow row in table.Rows)
            {
                html += "<tr>";
                foreach (DataGridViewCell cellx in row.Cells)
                {
                    html += "<td style='width:120px;border:1px solid black'>" + cellx.Value + "</td>";
                }
                html += "</tr>";
            }
            html += "</table>";
            html += "<table cellpadding='5' cellspacing='0' style='border:1px solid white;font-size:9pt;font-family:TimeNewRoman;width:100%;margin-left:auto;margin-right:auto'>";
            html += "<tr>";
            html += "<td style ='text-align: center;'>Người cho thuê</td>";
            html += "<td style ='text-align: center;'>Người thuê</td>";
            html += "</tr>";
            html += "<tr>";
            html += "<td style ='text-align: center;'>(ký, ghi đầy đủ họ tên)</td>";
            html += "<td style ='text-align: center;'>(ký, ghi đầy đủ họ tên)</td>";
            html += "</tr>";
            html += "<tr>";
            html += "<td style ='text-align: center;'>            </td>";
            html += "<td style ='text-align: center;'>           </td>";
            html += "</tr>";
            html += "<tr>";
            html += "<td style ='text-align: center;'>            </td>";
            html += "<td style ='text-align: center;'>           </td>";
            html += "</tr>";
            html += "</table>"; 

            string htmlFilePath = @"C:\Users\trand\OneDrive\Máy tính\HopDongg.htm";
            File.WriteAllText(htmlFilePath, html);
            _Application word = new Microsoft.Office.Interop.Word.Application();
            _Document wordDoc = word.Documents.Open(FileName: htmlFilePath, ReadOnly: false);
            wordDoc.SaveAs(FileName: @"C:\Users\trand\OneDrive\Máy tính\HopDong.doc", FileFormat: WdSaveFormat.wdFormatRTF);
            ((_Document)wordDoc).Close();
            ((_Application)word).Quit();
            File.Delete(htmlFilePath);
            MessageBox.Show("Đã xuất Hợp Đồng");
        }

        private void cbMaD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaD.SelectedIndex != -1)
            {
                string selectedName = cbMaD.Text;
                System.Data.DataTable searchResult2 = db.TimHopDong(cbMaD.Text);
                table.DataSource = searchResult2;
            }
        }
    }
}
