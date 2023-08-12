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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //34fac
            //0011 0100 1111 1010 1100
            //b26


            Random rastgele = new Random();
            int sayı = rastgele.Next(0, 50);
            label1.Text = sayı.ToString();




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
