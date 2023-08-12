using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri_4
{
    public partial class sayac : Form
    {
        public sayac()
        {
            InitializeComponent();
        }
             int sayi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            sayi = sayi + 1;
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = sayi + 3;
            label2.Text = sayi.ToString();
        }

        private void sayac_Load(object sender, EventArgs e)
        {

        }
    }
}
