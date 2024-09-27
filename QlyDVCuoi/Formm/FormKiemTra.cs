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
    public partial class FormKiemTra : Form
    {
        CSDL db = new CSDL();
        public FormKiemTra()
        {
            InitializeComponent();
        }

        private void FormKiemTra_Load(object sender, EventArgs e)
        {
            tableDV.DataSource = db.TableKtra();
        }
    }
}
