using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class istanbul_kocaeli_seyahat : Form
    {
        public istanbul_kocaeli_seyahat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yigit" && textBox2.Text == "1234")
            {
                istanbul_kocaeli_seyahat2 seyahat = new istanbul_kocaeli_seyahat2();
                seyahat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("yanlış giriş yaptınız lütfen tekrar deneyin");
                textBox1.Clear();
                textBox2.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            istanbul_kocaeli_seyahat2 seyahat = new istanbul_kocaeli_seyahat2();
            seyahat.Show();
            this.Hide();
        }
    }
}
