using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QlyDVCuoi
{
    public partial class FormDangNhap : Form
    {
        CSDL db = new CSDL();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (db.DN(username.Text, password.Text))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                FormQuanLy f = new FormQuanLy();
                f.usernameLogin.Text = username.Text;
                this.Hide();
                f.ShowDialog();
                this.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản không hợp lệ, mời đăng nhập lại!!!", "Thông báo");
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormDangKy f = new FormDangKy();
            this.Hide();
            f.ShowDialog();
            this.Show();
            this.Close();
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1.Checked == true)
            {
                if (password.PasswordChar == '*')
                {
                    password.PasswordChar = '\0';
                }
            }
            else
            {
                if (password.PasswordChar == '\0')
                {
                    password.PasswordChar = '*';
                }
            }
        }
    }
}
