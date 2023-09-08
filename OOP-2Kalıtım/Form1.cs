using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_2Kalıtım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            insan ins = new insan();

            ins.ad = "yiğit";
            ins.soyad = "elmacı";
            ins.yas = 17;
            ins.kilo = 70;

            personel pers = new personel();
            pers.departman = "eğitim";
            pers.boy = 180;
            pers.yer = "şube-1";

            label1.Text = ins.ad.ToString();
            label2.Text = ins.soyad.ToString();
            label3.Text = ins.yas.ToString();
            label4.Text = ins.kilo.ToString();


            label5.Text = pers.departman.ToString();
            label6.Text = pers.boy.ToString();
            label7.Text = pers.yer.ToString();

            pers.ad = "murat";
            pers.soyad = "elmacı";

            label8.Text = pers.ad.ToString();
            label9.Text = pers.soyad.ToString();

            pers.mevkii = "müdür yardımcısı";
            label10.Text=pers.mevkii.ToString();




        }

       
    }
}
