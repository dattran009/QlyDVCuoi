using QlyDVCuoi.Formm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QlyDVCuoi
{
    public partial class FormQuanLy : Form
    {
        CSDL db = new CSDL();
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormQuanLy()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelQly.Visible = false;
            panelCount.Visible = false;
            panelSupport.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelQly.Visible == true)
            {
                panelQly.Visible = false;
                lbCnang.Hide();
                cbCnang.Hide();
                usernameLogin.Hide();
            }
            if (panelCount.Visible == true)
            {
                panelCount.Visible = false;
                lbCnang.Hide();
                cbCnang.Hide();
                usernameLogin.Hide();
            }
            if (panelSupport.Visible == true)
            {
                panelSupport.Visible = false;
                lbCnang.Hide();
                cbCnang.Hide();
                usernameLogin.Hide();
            }

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void showSubMenu1(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Open Sans Semibold", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Open Sans Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            tiledon.Animated = true;
            FormThongKe f = new FormThongKe();
            //textTong.Text = f.textTong.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            showSubMenu(panelQly);
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }*/

        /*private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(panelReport);
            OpenChildForm(new Formm.FormTimKiemDV(), sender);
        }*/

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "TRANG CHỦ";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
            lbCnang.Show();
            cbCnang.Show();
            usernameLogin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormThayDoi(), sender);
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Formm.FormChoThue(), sender);
            //hideSubMenu();
            showSubMenu1(panelKyHD);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormNhanDo(), sender);
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormKiemTra(), sender);
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormThongKe(), sender);
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormBaoCaoNgay(), sender);
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void btnCount_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCount);
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSupport);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormTimKiemDV(), sender);
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormTroGiup(), sender);
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormTimkiemKH(), sender);
            hideSubMenu();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCnang.SelectedIndex = -1;

        }
        private void guna2ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCnang.SelectedItem == "Đổi mật khẩu")
            {
                FormDoiMK f = new FormDoiMK();
                f.txtUser.Text = usernameLogin.Text;
                f.ShowDialog();
            }
            if (cbCnang.SelectedItem == "Xóa tài khoản")
            {
                if (MessageBox.Show("Bạn có muốn xóa tài khoản '" + usernameLogin.Text.ToString() + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        db.xoaTaikhoan(usernameLogin.Text);
                        FormQuanLy_Load(sender, e);
                        MessageBox.Show("Tài khoản '" + usernameLogin.Text.ToString() + "' không còn tồn tại", "Thông báo xóa tài khoản thành công");
                        FormDangNhap f = new FormDangNhap();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Thông báo lỗi");
                    }
                }
            }
            if (cbCnang.SelectedItem == "Đăng xuất")
            {
                if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FormDangNhap f = new FormDangNhap();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    this.Close();
                }
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                guna2CirclePictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textTong_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textTong_MouseClick(object sender, MouseEventArgs e)
        {
            //FormThongKe f = new FormThongKe();
            //textTong.Text = f.textTong.Text;
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormThemHDcs(), sender);
            hideSubMenu();
        }

        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormThemCTHD(), sender);
            hideSubMenu();
        }

        private void btnKyHDnho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormChoThue(), sender);
            hideSubMenu();
        }

        private void btnThanhLyHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormThanhLyHD(), sender);
            hideSubMenu();
        }

        private void btnKtra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formm.FormKiemTra(), sender);
            hideSubMenu();
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
