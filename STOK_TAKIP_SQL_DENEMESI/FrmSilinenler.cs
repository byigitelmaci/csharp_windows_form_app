﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace STOK_TAKIP_SQL_DENEMESI
{
    public partial class FrmSilinenler : Form
    {
        public FrmSilinenler()
        {
            InitializeComponent();
        }
        SatisDTO dto = new SatisDTO();
        SatisBLL bll = new SatisBLL();  

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSilinenler_Load(object sender, EventArgs e)
        {
            cmbTablolar.Items.Add("Kategoriler");
            cmbTablolar.Items.Add("Ürünler");
            cmbTablolar.Items.Add("Müşriler");
            cmbTablolar.Items.Add("Satış");
            dto = bll.Select(true);
            dataGridView1.DataSource = dto.Satislar;
            dataGridView1.Columns[0].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            dataGridView1.Columns[2].HeaderText = "kategori Adı";
            dataGridView1.Columns[3].HeaderText = "Fiyatı";
            dataGridView1.Columns[4].HeaderText = "Satış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Satış Miktarı";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbTablolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTablolar.SelectedIndex==0)
            {
                dataGridView1.DataSource = dto.Kategoriler;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Kategori Adı";
            }
            else if (cmbTablolar.SelectedIndex==1)
            {
                dataGridView1.DataSource=dto.Urunler;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[1].HeaderText = "ürün adı";
                dataGridView1.Columns[2].HeaderText = "kategori";
                //dataGridView1.Columns[3].HeaderText = "stok miktarı";
                dataGridView1.Columns[4].HeaderText = "ürün Fiyatı";
            }
            else if (cmbTablolar.SelectedIndex == 2)
            {
                dataGridView1.DataSource = dto.Musteriler;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
            }
            else
            {
                dataGridView1.DataSource = dto.Satislar;
                dataGridView1.Columns[0].HeaderText = "Ürün Adı";
                dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
                dataGridView1.Columns[2].HeaderText = "kategori Adı";
                dataGridView1.Columns[3].HeaderText = "Fiyatı";
                dataGridView1.Columns[4].HeaderText = "Satış Tarihi";
                dataGridView1.Columns[5].HeaderText = "Satış Miktarı";
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
            }
        }
        SatisDetayDTO satis = new SatisDetayDTO();
        UrunDetayDTO urun = new UrunDetayDTO();
        KategoriDetayDTO kategori = new KategoriDetayDTO();
        MusteriDetayDTO musteri = new MusteriDetayDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbTablolar.SelectedIndex == 0)
            {
                kategori.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                kategori.KategoriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbTablolar.SelectedIndex == 1)
            {
                urun.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                urun.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                urun.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                urun.KategoriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            }
            else if (cmbTablolar.SelectedIndex == 2)
            {
                musteri.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                musteri.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            }
            else if (cmbTablolar.SelectedIndex == 3)
            {
                satis.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                satis.UrunAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                satis.Fiyat = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                satis.SatisID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
                satis.UrunID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                satis.MusteriID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                satis.SatisMiktar = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            }
        }

    }
}
