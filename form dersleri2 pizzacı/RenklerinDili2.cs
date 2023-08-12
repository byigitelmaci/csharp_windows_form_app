using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace form_dersleri2_pizzacı
{
    public partial class RenklerinDili2 : Form
    {
        public RenklerinDili2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "mavi")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "rengi=" + "mutluluğun ve pozitifliğin rengidir";
                button1.BackColor = Color.Blue;
            }

            if (comboBox1.Text == "sarı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "rengi=" + "iyimserliğin rengidir";
                button1.BackColor = Color.Yellow;
            }

            if (comboBox1.Text == "yeşil")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "rengi=" + "bereketin rengidir";
                button1.BackColor = Color.Green;
            }

            if (comboBox1.Text == "siyah")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "rengi=" + "karamsarlığın rengidir";
                button1.BackColor = Color.Black;
            }

            if (comboBox1.Text == "kırmızı")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "rengi=" + "tutkunun rengidir";
                button1.BackColor = Color.Red;
            }

            if (comboBox1.Text == "beyaz")
            {
                label4.Text = textBox1.Text + " " + comboBox1.Text + "rengi=" + "bereketin rengidir";
                button1.BackColor = Color.White;
            }

        }



    }
}
