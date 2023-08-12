using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri2_pizzacı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, çevre;

            birkenar = Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            çevre = birkenar * 4;

            label5.Text = alan.ToString();
            label6.Text = çevre.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible=true;
            label7.Visible=false;
            textBox2.Visible=false;
            label1.Text="KARE";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "DİKDÖRTGEN";
            label2.Text = "KISA KENAR";
            panel1.Visible=true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kısa, uzun, alan, çevre;
            
            kısa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);
            
            alan = kısa * uzun;
            çevre = (2 * kısa) + (2 * uzun);

            label5.Text = alan.ToString();
            label6.Text = çevre.ToString();


        }
    }
}
