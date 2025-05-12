using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listBox1.Items.Add("Ceket");
            listBox1.Items.Add("Gömlek");
            listBox1.Items.Add("Kazak");
            listBox1.Items.Add("Pantolon");

            // Adetleri ekle
            for (int i = 1; i <= 10; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            

        }
        int toplamFiyat = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            
            // Seçilen değerleri al
            string urun = listBox1.SelectedItem.ToString();
            int adet = Convert.ToInt32(comboBox1.SelectedItem);
            int birimFiyat = 0;

            // Ürünün fiyatını belirle
            if (urun == "Ceket") birimFiyat = 200;
            else if (urun == "Gömlek") birimFiyat = 80;
            else if (urun == "Kazak") birimFiyat = 100;
            else if (urun == "Pantolon") birimFiyat = 120;
            lblFiyat.Text =  birimFiyat + " TL";

            // Hesapla ve listeye ekle

            int araToplam = birimFiyat * adet;
            listBox2.Items.Add($"{urun} - {adet} adet: {araToplam} TL");

            // Toplamı güncelle
            toplamFiyat += araToplam;

            lblToplam.Text =  toplamFiyat + " TL";
        }
    }
}
