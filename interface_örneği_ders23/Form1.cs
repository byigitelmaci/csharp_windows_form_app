using interface_örneği_ders23.interfaces;
using interface_örneği_ders23.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_örneği_ders23
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
            ucak ucak = new ucak(textBox1.Text,textBox2.Text,comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString());
            selamla(ucak);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tren tren = new tren(textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            selamla(tren);
        }


        private void selamla(Iarac arac)
        {
            MessageBox.Show($"sn {arac.isim} {arac.soyisim} {arac.baslangıcnoktası} - {arac.bitisnoktası} arasında yapacağınız {arac.GetType().Name} seyahatinizin güzel geçmesini diliyoruz");
        }
    }
}
