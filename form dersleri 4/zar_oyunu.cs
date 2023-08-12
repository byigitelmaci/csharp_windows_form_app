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
    public partial class zar_oyunu : Form
    {
        public zar_oyunu()
        {
            InitializeComponent();
        }
        Random sayıuret = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int a = sayıuret.Next(1, 7);
            int b = sayıuret.Next(1,7);
            label1.Text = a.ToString();
            label2.Text = b.ToString();

        }

        private void zar_oyunu_Load(object sender, EventArgs e)
        {

        }
    }
}
