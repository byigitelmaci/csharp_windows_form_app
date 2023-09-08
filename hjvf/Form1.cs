using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hjvf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isim = new string[10];
        string[] telefon = new string[10];
        string[] ilce = new string[10];
        int i = 0;
        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            isim[i] = textBox1.Text;
            telefon[i] = textBox2.Text;
            ilce[i] = textBox3.Text;
            i++;
            temizle();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            i--;
            label9.Text = isim[i];
            label8.Text = telefon[i];
            label7.Text = ilce[i];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            label9.Text = isim[i];
            label8.Text = telefon[i];
            label7.Text = ilce[i];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            label9.Text = isim[i];
            label8.Text = telefon[i];
            label7.Text = ilce[i];
        }
    }
}
