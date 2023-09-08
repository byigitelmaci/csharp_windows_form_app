using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_32_OOP_Bölüm_1_Sınıflar_ve_Nesneler
{
    public partial class OOP_1_Örnek_2 : Form
    {
        public OOP_1_Örnek_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ev evim = new ev();

            evim.turu = "Daire";
            evim.renk = "Beyaz";
            evim.odasayısı = 5;
            evim.kat = 4;

            string turu = evim.evigoster();

            label5.Text = evim.turu.ToString();
            label6.Text= evim.renk.ToString();
            label7.Text=evim.odasayısı.ToString();
            label8.Text=evim.kat.ToString();


        }
    }
}
