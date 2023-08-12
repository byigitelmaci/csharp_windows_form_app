using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri_5_qeokrg_oqkerf
{
    public partial class ardışık__sayıları_toplama : Form
    {
        public ardışık__sayıları_toplama()
        {
            InitializeComponent();
        }
        //int i = 0;
        //int toplam=0;

        int i = 1;
        int faktorıyel=1;
        private void button1_Click(object sender, EventArgs e)
        {
            //for(int i = 0;  i < 6; i++)
            //{
            //    toplam = toplam + i;
            //    label1.Text = toplam.ToString();
            //    listBox1.Items.Add(i);
            //    listBox2.Items.Add(toplam);
            //}
            for ( i = 1; i <= 7; i++) 
            {
                faktorıyel = faktorıyel * i;
                listBox1.Items.Add(faktorıyel);
                label1.Text=faktorıyel.ToString();
            }
        }
    }
}
