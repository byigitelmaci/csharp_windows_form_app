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
    public partial class saat_ve_dakika : Form
    {
        public saat_ve_dakika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1;
            int saat, dakika;

            sayı1 = Convert.ToInt32(textBox1.Text);

            saat = sayı1 / 60;
            label3.Text=saat.ToString();

            dakika=sayı1 % 60;
            label5.Text=dakika.ToString();
        }
    }
}
