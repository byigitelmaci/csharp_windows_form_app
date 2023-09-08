using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_18_Algoritmik_Örnekler
{
    public partial class mükemmel_sayi_bulma : Form
    {
        public mükemmel_sayi_bulma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int sayi = 0;
            sayi=Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= sayi / 2; i++) 
            {
                if (sayi%i == 0)
                {
                    toplam=toplam +i;  
                }
                if (sayi == toplam)
                {
                    label2.Text="sayı mükemmel sayıdır";

                }
                else
                {
                    label2.Text = "sayı mükemmel sayı değildir";
                }
            }
        }
    }
}
