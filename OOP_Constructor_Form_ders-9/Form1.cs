using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Constructor_Form_ders_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnbackground_Click(object sender, EventArgs e)
        {
            int Red = trcred.Value;
            int Green = trcgreen.Value;
            int Blue = trcblue.Value;
            Form2 frm2 = new Form2(Red,Green,Blue);
            frm2.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnname_Click(object sender, EventArgs e)
        {
            string Name =txtname.Text;
            Form2 frm2 = new Form2(Name);
            frm2.Show();
        }
    }
}
