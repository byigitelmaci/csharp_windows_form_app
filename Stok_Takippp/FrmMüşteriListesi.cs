using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takippp
{
    public partial class FrmMüşteriListesi : Form
    {
        public FrmMüşteriListesi()
        {
            InitializeComponent();
        }

        private void FrmMüşteriListesi_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmMusteri frm = new frmMusteri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
