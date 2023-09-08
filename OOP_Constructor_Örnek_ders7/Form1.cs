using OOP_Constructor_Örnek_ders7.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Constructor_Örnek_ders7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();  
        kaleci kaleci = new kaleci();
        Futbolcu oyuncu1;
        private void btnsec_Click(object sender, EventArgs e)
        {
            string ulke = cmbulke.SelectedItem.ToString();
            oyuncu1 = new Futbolcu(txtısım.Text,ulke);
            MessageBox.Show($"{oyuncu1.Isim} adlı {oyuncu1.Ulke}'li futbolcuyu seçtiniz");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyuncu1.Moral = rnd.Next(1, 10);
            oyuncu1.Sutgucu = oyuncu1.Moral;
            kaleci=new kaleci();
            kaleci.savunma = rnd.Next(1, 10);

            if (oyuncu1.Sutgucu > kaleci.savunma)
            {
                MessageBox.Show("Gooooooooooooooooooolll");
            }
            else
            {
                MessageBox.Show("kaleci panter gibi yakaladı");
            }
        }
    }
}
