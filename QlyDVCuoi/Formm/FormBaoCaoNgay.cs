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

namespace QlyDVCuoi.Formm
{
    public partial class FormBaoCaoNgay : Form
    {
        public FormBaoCaoNgay()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        CSDL c= new CSDL();
        private void FormBaoCaoNgay_Load(object sender, EventArgs e)
        {
            dtThongKe.DataSource = c.ThongKe();

            int currentYear = DateTime.Now.Year;

            List<int> years = new List<int>();

            for (int year = 1900; year <= currentYear; year++)
            {
                years.Add(year);
            }

            cbbNam.DataSource = years;

            List<int> months = new List<int>();
            for(int i=1; i<=12;i++)
            {
                months.Add(i);
            }
            cbbThang.DataSource = months;

            List<int> days = new List<int>();
            for (int i = 1; i <= 31; i++)
            {
                days.Add(i);
            }
            cbbNgay.DataSource = days;

            cbbNgay.Enabled = false;
            cbbThang.Enabled = false;
            cbbNam.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
   
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            if (rdbY.Checked)
            {
                cbbNgay.Enabled = false;
                cbbThang.Enabled = false;
                cbbNam.Enabled = true;
            }
            else if (rdbM.Checked)
            {
                cbbNgay.Enabled = false;
                cbbThang.Enabled = true;
                cbbNam.Enabled = true;
            }
            else if (rdbD.Checked)
            {
                cbbNgay.Enabled = true;
                cbbThang.Enabled = true;
                cbbNam.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nam=0, thang=0, ngay=0;
            try
            {
             nam=int.Parse(cbbNam.Text);
             thang = int.Parse(cbbThang.Text); 
             ngay = int.Parse(cbbNgay.Text);
            }
            catch
            {
                MessageBox.Show("loi convert");

            }
           
            if (rdbY.Checked)
            {
                dtThongKe.DataSource = c.BaoCaoNam(nam);
            }
            else if (rdbM.Checked)
            {
              dtThongKe.DataSource = c.BaoCaoThang(thang,nam);
            }
            else if (rdbD.Checked)
            {
                dtThongKe.DataSource = c.BaoCaoNgay(ngay,thang, nam);
            }
        }
    }
}
