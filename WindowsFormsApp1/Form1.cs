using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var username = sayi1.Text.ToString();
            //var sifre = this.sayi2.Text.ToString();
            //if (username == "admin" && sifre == "1")
            //{
            //    MessageBox.Show("Kullanıcı adı ve şifre doğru");
            //}
            //else
            //{
            //    MessageBox.Show("Kullanıcı adı ve şifre yanlış");
            //}



            int sayi1=Convert.ToInt32(tpl_sayi1.Text);
            int sayi2 = Convert.ToInt32(tpl_sayi2.Text);
            int toplam;
            toplam = sayi1+sayi2;
            MessageBox.Show(toplam.ToString());
        }

        private void bolme_btn_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt32(tpl_sayi1.Text);
            int sayi2 = Convert.ToInt32(tpl_sayi2.Text);
            int cıkarma;
            cıkarma = sayi1 - sayi2;
            MessageBox.Show(cıkarma.ToString());
        }

        private void carpma_btn_Click(object sender, EventArgs e)
        {

            int sayi1 = Convert.ToInt32(tpl_sayi1.Text);
            int sayi2 = Convert.ToInt32(tpl_sayi2.Text);
            int carpma;
            carpma = sayi1 * sayi2;
            MessageBox.Show(carpma.ToString());
        }
    }
}
