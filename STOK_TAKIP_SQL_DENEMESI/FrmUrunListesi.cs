﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STOK_TAKIP_SQL_DENEMESI.BLL;
using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;

namespace STOK_TAKIP_SQL_DENEMESI
{
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
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

        private void txtUrünstok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun();
            this.Hide();
            frm.dto = dto; 
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Urunler;
        }
        UrunBLL bll = new UrunBLL();
        UrunDTO dto = new UrunDTO();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Urunler;
            cmbKategori.DataSource = dto.Kategoriler;
            cmbKategori.DisplayMember = "KategoriAd";
            cmbKategori.ValueMember = "ID";
            cmbKategori.SelectedIndex = -1;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].HeaderText = "ürün adı";
            dataGridView1.Columns[2].HeaderText = "kategori";
            dataGridView1.Columns[3].HeaderText = "stok miktarı";
            dataGridView1.Columns[4].HeaderText = "ürün Fiyatı";


        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            List<UrunDetayDTO> list = new List<UrunDetayDTO>();
            list = dto.Urunler;
            if (txtUrunAdı.Text.Trim() != "")
                list = list.Where(x => x.UrunAd.Contains(txtUrunAdı.Text)).ToList();
            if(cmbKategori.SelectedIndex != -1 )
                list =list.Where(x=>x.KategoriID==Convert.ToInt32(cmbKategori.SelectedValue)).ToList();
            if (rbBüyük.Checked)
                list=list.Where(x=>x.Fiyat>Convert.ToInt32(txtUrunfiyatı.Text)).ToList();
            if (rbKüçük.Checked)
                list = list.Where(x => x.Fiyat < Convert.ToInt32(txtUrunfiyatı.Text)).ToList();
            if (rbEşit.Checked)
                list = list.Where(x => x.Fiyat == Convert.ToInt32(txtUrunfiyatı.Text)).ToList();
            if (rbsBüyük.Checked)
                list = list.Where(x => x.StokMiktar > Convert.ToInt32(txtUrünstok.Text)).ToList();
            if (rbsKüçük.Checked)
                list = list.Where(x => x.StokMiktar < Convert.ToInt32(txtUrünstok.Text)).ToList();
            if (rbsEşit.Checked)
                list = list.Where(x => x.StokMiktar == Convert.ToInt32(txtUrünstok.Text)).ToList();
            dataGridView1.DataSource = list;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void temizle()
        {
            txtUrunAdı.Clear();
            txtUrunfiyatı.Clear();
            txtUrünstok.Clear();
            cmbKategori.SelectedIndex = -1;
            rbBüyük.Checked = false;
            rbEşit.Checked = false;
            rbKüçük.Checked = false;
            rbsBüyük.Checked = false;
            rbsEşit.Checked = false;
            rbsKüçük.Checked = false;
            dataGridView1.DataSource = dto.Urunler;
        }
        UrunDetayDTO detayDTO = new UrunDetayDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detayDTO.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detayDTO.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detayDTO.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detayDTO.KategoriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (detayDTO.ID== 0)
                MessageBox.Show("Ürün Seçiniz");
            else
            {
                FrmUrun frm = new FrmUrun();
                frm.isupdate = true;
                frm.detaydto = detayDTO;
                frm.dto = dto;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new UrunBLL();
                dto = bll.Select();
                dataGridView1.DataSource = dto.Urunler;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(detayDTO.ID== 0)
                MessageBox.Show("Seçim Yapın");
            DialogResult result = MessageBox.Show("Silinsin mi?", "Dikkat", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (bll.Delete(detayDTO))
                {
                    MessageBox.Show("Silindi");
                    bll = new UrunBLL();
                    dto = bll.Select();
                    dataGridView1.DataSource=dto.Urunler;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
