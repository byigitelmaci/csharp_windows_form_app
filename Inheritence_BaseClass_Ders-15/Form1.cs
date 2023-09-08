using Inheritence_BaseClass_Ders_15.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritence_BaseClass_Ders_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucakgemisi uck=new ucakgemisi();
            
            denizaltı dnz=new denizaltı();


            gemi dnz2 = new gemi();

            denizaltı dnz3 = dnz2 as denizaltı; // cast sistemi ile dönüştürdüm

            dnz3.rotabelirle();
        }
    }
}
