using DevComponents.DotNetBar.Validator;
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

namespace QlyDVCuoi
{
    public partial class FormDoiMK : Form
    {
        SqlConnection con;
        public FormDoiMK()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=DESKTOP-N64K7CG;Initial Catalog=QLY_TiemCuoi;Integrated Security=True;Encrypt=False");
        }

        private void FormDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select  count(*) from Qly_Taikhoan where username='" + txtUser.Text + "' and password='" + txtMkcu.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (txtMKmoi.Text == txtReMKmoi.Text)
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("update Qly_Taikhoan set password='" + txtMKmoi.Text + "' where username='" + txtUser.Text + "' and password='" + txtMkcu.Text + "'", con);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
