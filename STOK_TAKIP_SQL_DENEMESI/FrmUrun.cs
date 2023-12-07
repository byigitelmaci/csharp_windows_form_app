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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUrunfiyatı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }
        public UrunDTO dto = new UrunDTO(); 
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = dto.Kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedIndex = -1;
        }
        UrunBLL bll = new UrunBLL();
        UrunDetayDTO detay = new UrunDetayDTO();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAdı.Text.Trim() == "")
                MessageBox.Show("Ürün adı boş");
            else if (txtUrunfiyatı.Text.Trim() == "")
                MessageBox.Show("Fiyat alanı boş");
            else if (cmbKategori.SelectedIndex == -1)
                MessageBox.Show("Kategori Seçiniz");
            else
            {
                detay.UrunAd = txtUrunAdı.Text;
                detay.Fiyat = Convert.ToInt32(txtUrunfiyatı.Text);
                detay.KategoriID = Convert.ToInt32(cmbKategori.SelectedValue);
                if(bll.insert(detay))
                {
                    MessageBox.Show("Ürün Eklendi");
                    txtUrunAdı.Clear();
                    txtUrunfiyatı.Clear();
                    cmbKategori.SelectedIndex = -1;
                }
            }
        }
    }
}
