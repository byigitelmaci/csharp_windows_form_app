using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STOK_TAKIP_SQL_DENEMESI.BLL;
using STOK_TAKIP_SQL_DENEMESI.DAL;
using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;

namespace STOK_TAKIP_SQL_DENEMESI
{
    public partial class FrmStokEkleme : Form
    {
        public FrmStokEkleme()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void txtUrünStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }
        UrunBLL bll = new UrunBLL();
        UrunDTO dto = new UrunDTO();
        bool combofull = false;
        private void FrmStokEkleme_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Urunler;
            cmbKategori.DataSource = dto.Kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedIndex = -1;
            combofull = true;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[1].HeaderText = "ürün adı";
            dataGridView1.Columns[2].HeaderText = "kategori";
            dataGridView1.Columns[3].HeaderText = "stok miktarı";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull) 
            {
                List<UrunDetayDTO> list = new List<UrunDetayDTO>();
                list = dto.Urunler;
                int kID=Convert.ToInt32(cmbKategori.SelectedValue);
                list =list.Where(x=> x.KategoriID==kID).ToList();
                dataGridView1.DataSource = list; 
            }
        }
        UrunDetayDTO detay = new UrunDetayDTO();

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detay.StokMiktar = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detay.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detay.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUrunAdı.Text = detay.UrunAd;
            txtUrunfiyatı.Text = detay.Fiyat.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (detay.ID==0)
                MessageBox.Show("Ürün seçiniz");
            else if (txtUrünStok.Text=="")
                MessageBox.Show("Stok Miktarı Giriniz");
            else
            {
                detay.isKategoriDeleted = true;
                int toplam = detay.StokMiktar;
                toplam += Convert.ToInt32(txtUrünStok.Text);
                detay.StokMiktar = toplam;
                if (bll.update(detay))
                {
                    MessageBox.Show("Stok Eklendi");
                    dto = bll.Select();
                    dataGridView1.DataSource = dto.Urunler;
                    txtUrünStok.Clear();
                }
            }
        }
    }
}
