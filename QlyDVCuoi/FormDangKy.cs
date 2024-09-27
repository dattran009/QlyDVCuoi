using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyDVCuoi
{
    public partial class FormDangKy : Form
    {
        CSDL db = new CSDL();
        public FormDangKy()
        {
            InitializeComponent();
        }
        bool kiemtra_du_lieu()
        {
            if (kiemtra(username.Text) || kiemtra(password.Text))
            {
                if (kiemtra(username.Text))
                {
                    MessageBox.Show("Tên người dùng trống, vui lòng điền đủ!");
                    username.Focus();
                }
                else if (kiemtra(password.Text))
                {
                    MessageBox.Show("Mật khẩu trống, vui lòng điền đủ!");
                    password.Focus();
                }
                return false;
            }

            return true;
        }
        bool kiemtra(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return true;
            else return false;
        }

        void reset()
        {
            username.ResetText();
            password.ResetText();
            repassword.ResetText();
        }
        private void HienThongBaoLoi(string thuocTinh, string thongBao)
        {
            MessageBox.Show($"'{thuocTinh}': {thongBao}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
                if (kiemtra_du_lieu())
                {
                if (repassword.Text == password.Text)
                {
                    if (db.kTraTK(username.Text))
                    {
                        HienThongBaoLoi("Mời nhập tài khoản hợp lệ", "Tài khoản tồn tại");
                        username.Focus();
                    }
                    else
                    {
                        try
                        {
                            db.DkyTaikhoan(username.Text, password.Text);
                            reset();
                            MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi trong quá trình đăng ký! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    MessageBox.Show("Mật khẩu không khớp!!!");
                repassword.ResetText();
                    repassword.Focus();
            }
            }

        private void label8_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            this.Hide();
            f.ShowDialog();
            this.Show();
            this.Close();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
