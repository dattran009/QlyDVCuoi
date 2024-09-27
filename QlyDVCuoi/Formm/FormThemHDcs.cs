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
    public partial class FormThemHDcs : Form
    {
        CSDL db = new CSDL();
        public FormThemHDcs()
        {
            InitializeComponent();
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        bool kiemtra_du_lieu()
        {
            if (kiemtra(txtMaKH.Text) || kiemtra(txtTenKH.Text) || kiemtra(txtMaD.Text) || kiemtra(txtMaDV.Text))
            {
                return false;
            }
            return true;
        }
        void reset()
        {
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtMaD.ResetText();
            txtMaDV.ResetText();
        }
        private void HienThongBaoLoi(string thuocTinh, string thongBao)
        {
            MessageBox.Show($"Lỗi ở thuộc tính '{thuocTinh}': {thongBao}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FormThemHDcs_Load(object sender, EventArgs e)
        {
            tableHD.DataSource =db.DS3() ;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (kiemtra_du_lieu())
            {
                if (db.kTraKH(txtMaD.Text))
                {
                    HienThongBaoLoi("ID", "Trùng mã");
                    txtMaD.Focus();
                }
                else
                {
                    try
                    {
                        db.ThemHD(txtMaD.Text,txtMaDV.Text,dateNgayThue.Value,txtTenKH.Text,txtMaKH.Text);
                        reset();
                        FormThemHDcs_Load(sender,e);
                        MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm thông tin! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo lỗi");
            }
        }
    }
}
