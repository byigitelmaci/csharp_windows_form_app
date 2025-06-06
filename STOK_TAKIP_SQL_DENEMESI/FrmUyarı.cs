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
    public partial class FrmUyarı : Form
    {
        public FrmUyarı()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
            
        }
        UrunBLL bll = new UrunBLL();
        UrunDTO dto = new UrunDTO();
        private void FrmUyarı_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dto.Urunler = dto.Urunler.Where(x => x.StokMiktar<=100).ToList();
            if (dto.Urunler.Count == 0)
            {
                FrmMain frm = new FrmMain();
                this.Visible = false;
                frm.ShowDialog();


            }
           

            dataGridView1.DataSource = dto.Urunler;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[1].HeaderText = "ürün adı";
            dataGridView1.Columns[2].HeaderText = "kategori";
            dataGridView1.Columns[3].HeaderText = "stok miktarı";
            dataGridView1.Columns[4].HeaderText = "Ürün Fiyatı";

           
            
        }
    }
}
