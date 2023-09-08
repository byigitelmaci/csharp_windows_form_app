using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enum_kullanımı_ders_57
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
        //enum ı böyle 3 türlü kullanabiliriz.

        //enum colors { red,blue,white,black,yellow,purple,brown,orange}
        //enum colors { red=5, blue, white, black, yellow, purple, brown, orange }
        enum colors { red, blue, white, black, yellow=7, purple, brown, orange }
        private void button1_Click(object sender, EventArgs e)
        {
            string tt= "red:" + (int)colors.red+Environment.NewLine;
            tt += "blue" + (int)colors.blue + Environment.NewLine;
            tt += "white" + (int)colors.white + Environment.NewLine;
            tt += "black" + (int)colors.black + Environment.NewLine;
            tt += "yellow" + (int)colors.yellow + Environment.NewLine;
            tt += "purple" + (int)colors.purple + Environment.NewLine;
            tt += "brown" + (int)colors.brown + Environment.NewLine;
            tt += "orange" + (int)colors.orange + Environment.NewLine;
            textBox1.Text = tt;
        }
    }
}
