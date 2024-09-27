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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QlyDVCuoi.Formm
{
    public partial class FormThemCTHD : Form
    {
        CSDL db = new CSDL();
        public FormThemCTHD()
        {
            InitializeComponent();
        }

        private void FormThemCTHD_Load(object sender, EventArgs e)
        {
            cbMa.SelectedIndex = -1;
            table.DataSource = db.DS4();
            cbMa.DataSource = db.Do_DL_cbTenDV();
            cbMa.DisplayMember = "Ma_DV";
            cbMa.ValueMember = "Ma_DV";
        }

        private void cbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMa.SelectedIndex != -1)
            { 
               
                string selectedName = cbMa.Text;
                System.Data.DataTable searchResult2 = db.HienthiTenDV(selectedName);
                dataGridView1.DataSource = searchResult2;
                if (dataGridView1.Rows.Count > 0)
                {
                    txtTenDV.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                int slg = Convert.ToInt32(txtSoLg.Text);
                float dg = float.Parse(txtDgia.Text);
                db.ThemCTHD(txtMaD.Text, cbMa.Text, slg, dg);
                FormThemCTHD_Load(sender, e);
                MessageBox.Show("Thêm hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm thông tin! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
