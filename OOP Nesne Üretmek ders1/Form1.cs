using OOP_Nesne_Üretmek_ders1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Nesne_Üretmek_ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sınıfn nesnesini oluşturmakyani instance almak
            //int double
            //string classlar referans tiptir

            //Random rnd = new Random(); //instance almak

            araba Araba = new araba();

            Araba.marka = "nissan";
            Araba.model = "GTR";
            Araba.renk = "mavi";
            Araba.hiz = 240;
            Araba.vites = 6;

            MessageBox.Show($"{Araba.marka} markalı araç {Araba.vites}. vitesle e-5 üzerinde {Araba.hiz} ile seyahat etmektedir");
        }
    }
}
