using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace form_derleri6_double_örnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam, cıkarma, carpma, bolme;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = sayi1 + sayi2;
            cıkarma = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;

            label4.Text = toplam.ToString();
            label8.Text = cıkarma.ToString();
            label9.Text = carpma.ToString();
            label10.Text = bolme.ToString();
        }
    }
}
