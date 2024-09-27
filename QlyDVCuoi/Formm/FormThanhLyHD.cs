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
    public partial class FormThanhLyHD : Form
    {
        CSDL db = new CSDL();
        public FormThanhLyHD()
        {
            InitializeComponent();
        }

        private void FormThanhLyHD_Load(object sender, EventArgs e)
        {
            //cbMaD.SelectedIndex = -1;
            table.DataSource = db.HopDong();
            cbMaD.DataSource = db.Do_DL_cbMaDon();
            cbMaD.DisplayMember = "Ma_Don";
            cbMaD.ValueMember = "Ma_Don";
        }

        private void btnChothue_Click(object sender, EventArgs e)
        {
            string t = cbMaD.Text;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    db.xoaHD(cbMaD.Text);
                    FormThanhLyHD_Load(sender, e);
                    MessageBox.Show("Hợp đồng '" + t + "' không còn tồn tại", "Thông báo thanh lý hợp đồng thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Thông báo lỗi");
                }
            }
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
