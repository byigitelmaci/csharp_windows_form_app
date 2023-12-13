using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using STOK_TAKIP_SQL_DENEMESI.BLL;

namespace STOK_TAKIP_SQL_DENEMESI
{
    public partial class FrmSatışListesi : Form
    {
        public FrmSatışListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrunfiyatı_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrunfiyatı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void txtsatışmiktarı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmSatış frm = new FrmSatış();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Satislar;
            Temizle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SatisDTO dto = new SatisDTO();
        SatisBLL bll = new SatisBLL();
        private void FrmSatışListesi_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            cmbKategori.DataSource = dto.Kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Satislar;
            dataGridView1.Columns[0].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[2].HeaderText = "kategori";
            dataGridView1.Columns[3].HeaderText = "Fiyatı";
            dataGridView1.Columns[4].HeaderText = "Satış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Satış Miktarı";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            List<SatisDetayDTO> list = dto.Satislar;
            if (txtUrunAdı.Text.Trim() != "")
                list = list.Where(x => x.UrunAd.Contains(txtUrunAdı.Text)).ToList();
            if (txtMüşteriAdı.Text.Trim() != "")
                list = list.Where(x => x.MusteriAd.Contains(txtMüşteriAdı.Text)).ToList();
            if (cmbKategori.SelectedIndex != -1)
                list = list.Where(x => x.KategoriID == Convert.ToInt32(cmbKategori.SelectedValue)).ToList();
            if (rbBüyük.Checked)
                list = list.Where(x => x.Fiyat > Convert.ToInt32(txtUrunfiyatı.Text)).ToList();
            if (rbKüçük.Checked)
                list = list.Where(x => x.Fiyat < Convert.ToInt32(txtUrunfiyatı.Text)).ToList();
            if (rbEşit.Checked)
                list = list.Where(x => x.Fiyat == Convert.ToInt32(txtUrunfiyatı.Text)).ToList();
            if (rbsBüyük.Checked)
                list = list.Where(x => x.SatisMiktar > Convert.ToInt32(txtsatışmiktarı.Text)).ToList();
            if (rbsKüçük.Checked)
                list = list.Where(x => x.SatisMiktar < Convert.ToInt32(txtsatışmiktarı.Text)).ToList();
            if (rbsEşit.Checked)
                list = list.Where(x => x.SatisMiktar == Convert.ToInt32(txtsatışmiktarı.Text)).ToList();
            if (chtarih.Checked)
                list = list.Where(x=> x.SatisTarihi >dpBaslamaTarihi.Value && x.SatisTarihi <dpBitisTarihi.Value).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtMüşteriAdı.Clear();
            txtUrunAdı.Clear();
            txtUrunfiyatı.Clear();
            txtsatışmiktarı.Clear();
            cmbKategori.SelectedIndex = -1;
            rbBüyük.Checked = false;
            rbEşit.Checked = false;
            rbKüçük.Checked = false;
            rbsBüyük.Checked = false;
            rbsEşit.Checked = false;
            rbsKüçük.Checked = false;
            dpBaslamaTarihi.Value = DateTime.Today;
            dpBitisTarihi.Value= DateTime.Today;
            chtarih.Checked = false;
            dataGridView1.DataSource = dto.Satislar;
        }
    }
}
