using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri7_radiobutton_menustrip_kullanımı
{
    public partial class radiobutton_örnek2 : Form
    {
        public radiobutton_örnek2()
        {
            InitializeComponent();
        }


        int sayi1 = 5;
        int sayi2 = 10;
        int toplama, cıkarma, carpma, bolme;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            carpma = sayi1 * sayi2;
            label1.Text = carpma.ToString(); 

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            bolme = sayi1 / sayi2;
            label1.Text = bolme.ToString();

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cıkarma = sayi1 - sayi2;
            label1.Text = cıkarma.ToString();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            toplama = sayi1 + sayi2;
            label1.Text = toplama.ToString();

        }
    }
}
