using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDEMY_messagebox_ders_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("firt message", "message title", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            //bişey denedim
            //label1.BackColor = Color.Red;
            //label1.ForeColor = Color.White; 
        }
    }
}
