using Abstraction_ders_17.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction_ders_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kare kare = new kare();
            dikdörtgen dg = new dikdörtgen();
            GeometrikŞekil geo = new GeometrikŞekil();

        }
        //abstraction
    }
}
