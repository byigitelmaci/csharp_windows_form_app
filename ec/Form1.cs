using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int firstnumber = Convert.ToInt32(textBox1.Text);
                int second = Convert.ToInt32(textBox2.Text);
                int result=firstnumber / second;
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("you cannot divide any number to zero");
            }
            catch(Exception ex) 
            { 
                throw new Exception("please use only number");
            }
            finally
            {
                MessageBox.Show("program finished");

            }
        }
    }
}
