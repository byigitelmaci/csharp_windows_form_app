﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri1_hello_world
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void HesapMakinesi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int sonuc;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            sonuc = sayi1 + sayi2;

            label3.Text = sonuc.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi3;
            int sayi4;
            int sonuc;

            sayi3 = Convert.ToInt32(textBox3.Text);
            sayi4 = Convert.ToInt32(textBox4.Text);

            sonuc = sayi3 * sayi4;

            label7.Text = sonuc.ToString();

        }
    }
}
