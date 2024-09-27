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

namespace QlyDVCuoi.Formm
{
    public partial class FormThayDoi : Form
    {
        CSDL db = new CSDL();   
        public FormThayDoi()
        {
            InitializeComponent();
        }
        /*private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            C.ForeColor = ThemeColor.PrimaryColor;
        }*/

        private void FormActivate_Load(object sender, EventArgs e)
        {
            tableKHHDCTHD.DataSource = db.ThayDoi();
        }

        private void tableKHHDCTHD_SelectionChanged(object sender, EventArgs e)
        {
            int dongchon = -1;
            dongchon = tableKHHDCTHD.CurrentRow.Index;
            try
            {
                if (dongchon >= 0)
                {
                    txtMaKH.Text = tableKHHDCTHD.Rows[dongchon].Cells["Ma_KH"].Value.ToString();
                    txtTenKH.Text = tableKHHDCTHD.Rows[dongchon].Cells["Ten_KH"].Value.ToString();
                    txtDC.Text = tableKHHDCTHD.Rows[dongchon].Cells["Dia_Chi"].Value.ToString();
                    txtSDT.Text = tableKHHDCTHD.Rows[dongchon].Cells["SoDienThoai"].Value.ToString();
                    txtMaDon.Text = tableKHHDCTHD.Rows[dongchon].Cells["Ma_Don"].Value.ToString();
                    txtDate.Value = Convert.ToDateTime(tableKHHDCTHD.Rows[dongchon].Cells["Ngay_Thue"].Value);
                    txtMaDV.Text = tableKHHDCTHD.Rows[dongchon].Cells["Ma_DV"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }
        bool kiemtra_du_lieu()
        {
            if (kiemtra(txtTenKH.Text) || kiemtra(txtDC.Text) || kiemtra(txtSDT.Text) || kiemtra(txtMaDV.Text))
            {
                return false;
            }
            return true;
        }
        void reset()
        {
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDC.ResetText();
            txtMaDV.ResetText();
        }
        private void HienThongBaoLoi(string thuocTinh, string thongBao)
        {
            MessageBox.Show($"Lỗi ở thuộc tính '{thuocTinh}': {thongBao}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (kiemtra_du_lieu())
            {
                try
                {
                    int sdt = int.Parse(txtSDT.Text);
                    db.ThaydoiKH(txtTenKH.Text, txtDC.Text, sdt, txtMaKH.Text);
                    FormActivate_Load(sender, e);
                    MessageBox.Show("Thay đổi thông tin khách hàng thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu sửa không hợp lệ");
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            if (kiemtra_du_lieu())
            {
                try
                {
                    db.ThaydoiHDDV(txtMaDV.Text,txtDate.Value, txtTenKH.Text, txtMaKH.Text, txtMaDon.Text);
                    FormActivate_Load(sender, e);
                    reset();
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Dữ liệu sửa không hợp lệ");
            }
        }
    }
}
