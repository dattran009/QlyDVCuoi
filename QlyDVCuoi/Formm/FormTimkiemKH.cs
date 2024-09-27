using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyDVCuoi.Formm
{
    public partial class FormTimkiemKH : Form
    {
        CSDL db = new CSDL();
        public FormTimkiemKH()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable searchResult1 = db.TkiemKHTheoMa(textMaKH.Text);
            DataTable searchResult2 = db.TkiemKHTheoTen(textTenKH.Text);
            if (cbTK.SelectedItem == "Mã Khách Hàng")
            {
                if (searchResult1 != null && searchResult1.Rows.Count > 0)
                {
                    tableKH.DataSource = searchResult1;
                }
                else
                {
                    tableKH.DataSource = null;
                    if (tableKH.Columns.Count == 0)
                    {
                        tableKH.Columns.Add("NoResultColumn", "");
                    }
                    tableKH.Rows.Add("Không có kết quả tìm kiếm");
                }
            }
            else if (cbTK.SelectedItem == "Tên Khách Hàng")
            {
                if (searchResult2 != null && searchResult2.Rows.Count > 0)
                {
                    tableKH.DataSource = searchResult2;
                }
                else
                {
                    tableKH.DataSource = null;
                    if (tableKH.Columns.Count == 0)
                    {
                        tableKH.Columns.Add("NoResultColumn", "");
                    }
                    tableKH.Rows.Add("Không có kết quả tìm kiếm");
                }
            }
            else
                MessageBox.Show("Chưa chọn phương thức tìm kiếm", "Thông báo");
        }

        private void cbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTKiemTheo.Visible = false;
            if (cbTK.SelectedItem == "Mã Khách Hàng")
            {
                textMaKH.Enabled = true;
                textTenKH.ResetText();
                textTenKH.Enabled = false;
            }
            if (cbTK.SelectedItem == "Tên Khách Hàng")
            {
                textTenKH.Enabled = true;
                textMaKH.ResetText();
                textMaKH.Enabled = false;
            }
        }

        private void cbTK_MouseClick(object sender, MouseEventArgs e)
        {
            cbTK.SelectedIndex = -1;
            lbTKiemTheo.Visible = true;
            textMaKH.Enabled = true;
            textTenKH.Enabled = true;
            textMaKH.ResetText();
            textTenKH.ResetText();
        }
    }
}
