using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while_do_while_döngüleri_ders_36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loopWorkAmount = 0, loopControlValue = 10;
            int inloopWorkAmount = 0, inlooControlValue = 0;

            while(loopControlValue < 20) 
            {
                inlooControlValue=0;
                while (inlooControlValue<8)
                {
                    inlooControlValue++;
                    inloopWorkAmount++;
                    textBox1.Text += loopControlValue.ToString() + " " + inlooControlValue + Environment.NewLine;

                }
                loopControlValue++;
                loopWorkAmount++;
            }
            MessageBox.Show("out loop woek amount works"+ loopWorkAmount.ToString()+"times in loop work amount work"+inloopWorkAmount.ToString()+"times");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int loopWorkAmount = 0, loopControlValue = 10;
            do
            {
                loopControlValue++;
                loopWorkAmount++;
                textBox1.Text += loopControlValue.ToString() + Environment.NewLine;
            }
            while (loopControlValue < 20);
            MessageBox.Show(loopWorkAmount.ToString());

        }
    }
}
