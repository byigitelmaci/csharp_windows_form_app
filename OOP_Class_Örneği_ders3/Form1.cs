using OOP_Class_Örneği_ders3.moduls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Class_Örneği_ders3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        buyucu oyuncu1 = new buyucu();
        int dusmancani;
        

        private void button1_Click(object sender, EventArgs e)
        {
            oyuncu1.oyuncuismi = txtoyuncu.Text;
            oyuncu1.brans = txtbrans.Text;
            oyuncu1.ırk = txtırk.Text;
            oyuncu1.silah = txtsilah.Text;
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dusmancani=lbldusmancani.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            oyuncu1.Saldir();
            dusmancani -= oyuncu1.saldırıgucu;
            lbldusmancani.Width = dusmancani;
            MessageBox.Show($"düsmana {oyuncu1.saldırıgucu}kadar vurdunuz");
            if (dusmancani <= 0)
            {
                MessageBox.Show("düsmanı yendiniz!!!!!1");
            }
        }
    }
}
