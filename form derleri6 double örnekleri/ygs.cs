using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_derleri6_double_örnekleri
{
    public partial class ygs : Form
    {
        public ygs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkce, matematik, fen, sosyal;
            double ygs1, ygs2, ygs3, ygs4, ygs5, ygs6;

            turkce = Convert.ToDouble(textBox1.Text);
            sosyal = Convert.ToDouble(textBox2.Text);
            matematik = Convert.ToDouble(textBox3.Text);
            fen = Convert.ToDouble(textBox4.Text);

            ygs1 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik * 3.998) + (fen * 2.999);
            label6.Text = ygs1.ToString();

            ygs2 = 100.160 + (turkce * 1.999) + (sosyal * 1) + (matematik*2.999) +(fen * 3.998);
            label7.Text = ygs2.ToString();

            ygs3 = 100.160 + (turkce * 3.998) + (sosyal *2.999) + (matematik * 1.999) + (fen * 1);
            label9.Text = ygs3.ToString();

            ygs4 = 100.160 + (turkce *2.999) +(sosyal* 3.998) +(matematik *1.999) +(fen * 1);
            label11.Text = ygs4.ToString();

            ygs5 = 100.120 + (turkce * 3.699) + (sosyal * 1.999) + (matematik * 3.299) + (fen * 1);
            label13.Text = ygs5.ToString();

            ygs6 = 100.120 + (turkce * 3.299) + (sosyal * 1) + (matematik * 3.699) + (fen * 1.999);
            label15.Text= ygs6.ToString();
        }
    }
}
