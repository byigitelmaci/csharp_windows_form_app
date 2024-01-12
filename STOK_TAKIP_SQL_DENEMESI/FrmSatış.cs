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
using STOK_TAKIP_SQL_DENEMESI.BLL;
using STOK_TAKIP_SQL_DENEMESI.DAL.DAO;

namespace STOK_TAKIP_SQL_DENEMESI
{
    public partial class FrmSatış : Form
    {
        public FrmSatış()
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }
        public SatisDTO dto = new SatisDTO();
        public SatisDetayDTO detaydto = new SatisDetayDTO();  
        public bool isupdate = false;
        private void FrmSatış_Load(object sender, EventArgs e)
        {
            if (isupdate)
            {
                panel1.Visible = false;
                txtMüşteri.Text = detaydto.MusteriAd;
                txtUrunAdı.Text = detaydto.UrunAd;
                txtUrunfiyatı.Text = detaydto.Fiyat.ToString();
                List<UrunDetayDTO> urunler = dto.Urunler;
                UrunDetayDTO urun = urunler.First(x => x.ID == detaydto.UrunID);
                txtStok.Text = urun.StokMiktar.ToString();

            }
            else
            {
                gridMusteriler.DataSource = dto.Musteriler;
                gridMusteriler.Columns[0].Visible = false;
                gridMusteriler.Columns[1].HeaderText = "Müşteri Adı";
                gridUrunler.DataSource = dto.Urunler;
                gridUrunler.Columns[0].Visible = false;
                gridUrunler.Columns[5].Visible = false;
                gridUrunler.Columns[6].Visible = false;
                gridUrunler.Columns[3].Visible = false;
                gridUrunler.Columns[4].Visible = false;
                gridUrunler.Columns[1].HeaderText = "Ürün Adı";
                gridUrunler.Columns[2].HeaderText = "Kategori";
                cmbKategori.DataSource = dto.Kategoriler;
                cmbKategori.DisplayMember = "KategoriAd";
                cmbKategori.ValueMember = "ID";
                cmbKategori.SelectedIndex = -1;
                if (dto.Kategoriler.Count > 0)
                    combofull = true;
            }




        }
        bool combofull = false;
        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                List<UrunDetayDTO> list = dto.Urunler;
                if (cmbKategori.SelectedIndex != -1)
                {
                    list=list.Where(x=>x.KategoriID==Convert.ToInt32(cmbKategori.SelectedValue)).ToList();
                    gridUrunler.DataSource = list;


                }

            }
        }

        private void txtMüşteriAdı_TextChanged(object sender, EventArgs e)
        {
            List<MusteriDetayDTO> list = dto.Musteriler.Where(x=> x.MusteriAd.Contains(txtMüşteriAdı.Text)).ToList();
            gridMusteriler.DataSource = list;

        }
        SatisDetayDTO detay = new SatisDetayDTO();

        private void gridUrunler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.UrunID = Convert.ToInt32(gridUrunler.Rows[e.RowIndex].Cells[0].Value);
            detay.Fiyat = Convert.ToInt32(gridUrunler.Rows[e.RowIndex].Cells[4].Value);
            detay.StokMiktar = Convert.ToInt32(gridUrunler.Rows[e.RowIndex].Cells[3].Value);
            detay.KategoriID = Convert.ToInt32(gridUrunler.Rows[e.RowIndex].Cells[5].Value);
            detay.UrunAd = gridUrunler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStok.Text = detay.StokMiktar.ToString();
            txtUrunAdı.Text=detay.UrunAd;
            txtUrunfiyatı.Text = detay.Fiyat.ToString();


            
        }

        private void gridMusteriler_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.MusteriID = Convert.ToInt32(gridMusteriler.Rows[e.RowIndex].Cells[0].Value);
            detay.MusteriAd = gridMusteriler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMüşteri.Text = detay.MusteriAd;
        }
        SatisBLL bll = new SatisBLL();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtSatisMiktar.Text.Trim()=="")
                MessageBox.Show("Lütfen Satış Miktarı Giriniz");
          
            else
            {
                if (isupdate)
                {
                    if (detay.StokMiktar <= Convert.ToInt32(txtSatisMiktar.Text))
                        MessageBox.Show("Yeterli Stok Yok");
                    else
                    {
                        int temp = detaydto.SatisMiktar + Convert.ToInt32(txtStok.Text);
                        if (temp < Convert.ToInt32(txtSatisMiktar.Text))
                            MessageBox.Show("Elinizde Yeterli Stok Yok");
                        else
                        {
                            detaydto.SatisMiktar = Convert.ToInt32(txtSatisMiktar.Text);
                            detaydto.StokMiktar = Convert.ToInt32(txtStok.Text);
                            if (bll.update(detaydto))
                            {
                                MessageBox.Show("Güncellendi");
                                this.Close();
                            }
                        }
                    }

                }
                else
                {
                    if (detay.UrunID == 0)
                        MessageBox.Show("Ürün Seçiniz");
                    else if (detay.MusteriID == 0)
                        MessageBox.Show("Müşteri Seçiniz");

                    else if (detay.StokMiktar <= Convert.ToInt32(txtSatisMiktar.Text))
                        MessageBox.Show("Yeterli Stok Yok");
                    else
                    {
                        detay.SatisMiktar = Convert.ToInt32(txtSatisMiktar.Text);
                        if (bll.insert(detay))
                        {
                            MessageBox.Show("Eklendi");
                            txtSatisMiktar.Clear();
                            dto = bll.Select();
                            gridUrunler.DataSource = dto.Urunler;
                        }
                    }
                   
                }
            }

        }
    }
}
