﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace C__Ders_12_Veri_Tabanı_Görüntüleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan= new SqlConnection("Data Source=LAPTOP-K7OR68QK;Initial Catalog=test;Integrated Security=True");
        private void verilerimigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from bilgiler",baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text=oku["adsoyad"].ToString();
                ekle.SubItems.Add(oku["şehir"].ToString());
                ekle.SubItems.Add(oku["okul"].ToString());
                listView1.Items.Add(ekle);


            }
            baglan.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerimigöster();
        }
    }
}
