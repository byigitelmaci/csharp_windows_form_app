using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri_4
{
    public partial class maçkolik1 : Form
    {
        public maçkolik1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text=="yigit" && textBox2.Text == "12")
            {
                maçkolik2 oyun = new maçkolik2();
                oyun.Show();
                this.Hide();
            }
               
            

            
        }

        private void maçkolik1_Load(object sender, EventArgs e)
        {

        }
    }
}
