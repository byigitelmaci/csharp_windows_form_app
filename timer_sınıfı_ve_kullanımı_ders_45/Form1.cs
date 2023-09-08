using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_sınıfı_ve_kullanımı_ders_45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 60;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("timer was stopped");
            }
            progressBar1.Value = counter;
            counter--;
            label1.Text=counter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = 60.ToString();
        }
    }
}
