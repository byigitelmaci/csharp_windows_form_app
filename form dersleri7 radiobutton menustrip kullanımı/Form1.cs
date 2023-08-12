using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri7_radiobutton_menustrip_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı, kare;
            sayı = Convert.ToInt32(textBox1.Text);
            kare = sayı * sayı;

            label3.Text=kare.ToString();



        }
    }
}
