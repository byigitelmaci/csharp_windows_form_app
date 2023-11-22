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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            FrmMüşteriListesi frm = new FrmMüşteriListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            FrmUrunListesi frm = new FrmUrunListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnSatış_Click(object sender, EventArgs e)
        {
            FrmSatışListesi frm = new FrmSatışListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnStokEkleme_Click(object sender, EventArgs e)
        {
            FrmStokEkleme frm = new FrmStokEkleme();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnSilinenler_Click(object sender, EventArgs e)
        {
            FrmSilinenler frm = new FrmSilinenler();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FrmKategoriListesi frm = new FrmKategoriListesi();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnÇıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
