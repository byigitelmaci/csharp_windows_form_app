using Inheritance_Constructor_ders_14.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance_Constructor_ders_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ögrenci ogrenci = new ögrenci();

            MessageBox.Show(ogrenci.KayıtTarihi.ToShortDateString());
        }
    }
}
