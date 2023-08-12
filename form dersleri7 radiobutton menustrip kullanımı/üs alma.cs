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
    public partial class üs_alma : Form
    {
        public üs_alma()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1,sayi2, üs;
            sayi1=Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            üs = Math.Pow(sayi1, sayi2);
            label4.Text = üs.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayı3, karekok;
            sayı3 = Convert.ToDouble(textBox3.Text);
            karekok = Math.Sqrt(sayı3);
            label6.Text = karekok.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayı1, sayi2;
            int mod;

            sayı1 = 60 % 16;
            label9.Text = sayı1.ToString();

            sayi2=Convert.ToInt32(textBox4.Text);
            mod = 100 % sayi2;

            label10.Text = mod.ToString();

        }
    }
}
