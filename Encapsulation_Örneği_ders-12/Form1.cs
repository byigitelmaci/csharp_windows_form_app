using Encapsulation_Örneği_ders_12.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation_Örneği_ders_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            player player1=new player(Convert.ToInt32(textBox1.Text));
            player player2=new player(Convert.ToInt32(textBox2.Text));
            player player3=new player(Convert.ToInt32(textBox3.Text));
            label7.Text=player1.sutgucu.ToString();
            label8.Text=player2.sutgucu.ToString();
            label9.Text=player3.sutgucu.ToString();

        }
    }
}
