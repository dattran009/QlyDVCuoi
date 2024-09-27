using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace QlyDVCuoi.Formm
{
    public partial class FormTimKiemDV : Form
    {
        CSDL db = new CSDL();
        public FormTimKiemDV()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // tableKHHDCTHD.DataSource = db.TkiemDV(textMaDV.Text, textTenDV.Text);
            DataTable searchResult1 = db.TkiemDVTheoMa(textMaDV.Text);
            DataTable searchResult2 = db.TkiemDVTheoTen(textTenDV.Text);
            if (cbTK.SelectedItem == "Mã Dịch Vụ")
            {
                if (searchResult1 != null && searchResult1.Rows.Count > 0)
                {
                    tableKHHDCTHD.DataSource = searchResult1;
                }
                else
                {
                    tableKHHDCTHD.DataSource = null;
                    if (tableKHHDCTHD.Columns.Count == 0)
                    {
                        tableKHHDCTHD.Columns.Add("NoResultColumn", "");
                    }
                    tableKHHDCTHD.Rows.Add("Không có kết quả tìm kiếm");
                }
            }
            else if (cbTK.SelectedItem == "Tên Dịch Vụ")
            {
                if (searchResult2 != null && searchResult2.Rows.Count > 0)
                {
                    tableKHHDCTHD.DataSource = searchResult2;
                }
                else
                {
                    tableKHHDCTHD.DataSource = null;
                    if (tableKHHDCTHD.Columns.Count == 0)
                    {
                        tableKHHDCTHD.Columns.Add("NoResultColumn", "");
                    }
                    tableKHHDCTHD.Rows.Add("Không có kết quả tìm kiếm");
                }
            }
            else
                MessageBox.Show("Chưa chọn phương thức tìm kiếm","Thông báo");
        }

        private void FormTimKiemDV_Load(object sender, EventArgs e)
        {
           
        }

        private void cbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTKiemTheo.Visible=false;
            if (cbTK.SelectedItem == "Mã Dịch Vụ")
            {
                textMaDV.Enabled = true;
                textTenDV.ResetText();
                textTenDV.Enabled = false;
            }
            if (cbTK.SelectedItem == "Tên Dịch Vụ")
            {
                textTenDV.Enabled = true;
                textMaDV.ResetText();
                textMaDV.Enabled = false;
            }
        }

        private void cbTK_MouseClick(object sender, MouseEventArgs e)
        {
            cbTK.SelectedIndex = -1;
            lbTKiemTheo.Visible = true;
            textMaDV.Enabled=true;
            textTenDV.Enabled=true;
            textMaDV.ResetText();
            textTenDV.ResetText();
        }
    }
}
