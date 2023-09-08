using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodlar_ders_41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            byte[] array = new byte[5];
            rnd.NextBytes(array);
            label1.Text = array[0].ToString();
            label2.Text = array[1].ToString();
            label3.Text = array[2].ToString();
            label4.Text = array[3].ToString();
            label5.Text = array[4].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string allvalid = "qwertyuıopğüişlkjhgfdsazxcvbnmöçQWERTYUIOPĞÜİŞLKJHGFDSAZXCVBNMÖÇ1234567890*-!'^+%&/()=?_${[]}<>.,;:";
            string result = "";
            Random rnd2 = new Random();
            for (int i = 0; i < 6; i++)
            {
                result += allvalid[rnd2.Next(0, Convert.ToInt32(allvalid.Length))];
            }
            label1.Text = result;
        }
    }
    
}
