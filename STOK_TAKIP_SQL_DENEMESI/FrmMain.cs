using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STOK_TAKIP_SQL_DENEMESI.DAL.DAO;


namespace STOK_TAKIP_SQL_DENEMESI
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
        
        UrunDTO dto = new UrunDTO();
        private void btnÇıkıs_Click(object sender, EventArgs e)
        {
           Application.Exit();
           
        }

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriListesi frm = new FrmMusteriListesi();
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
    }
}
