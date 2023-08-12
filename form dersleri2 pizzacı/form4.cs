using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri2_pizzacı
{
    public partial class form4 : Form
    {
        public form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin"&& textBox2.Text=="1234") 
            {
                form3 yeni=new form3();
                yeni.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hatalı giriş yaptınız");
            }
        }
    }
}
