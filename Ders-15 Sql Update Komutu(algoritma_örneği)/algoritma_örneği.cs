using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_15_Sql_Update_Komutu_algoritma_örneği_
{
    public partial class algoritma_örneği : Form
    {
        public algoritma_örneği()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
            sayı =Convert.ToInt32(textBox1.Text);

            for(int i = 1; i<=sayı; i++)
            {
                if (sayı % i == 0) 
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
