using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solid_prensipleri_dependecy_inversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var datalog = new datalog();
            datalog.mesaj = "Database logtur";
            var logyonet = new logyonet(datalog);
            logyonet.logla();
        }
    }
}
