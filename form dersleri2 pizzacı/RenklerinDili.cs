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
    public partial class RenklerinDili : Form
    {
        public RenklerinDili()
        {
            InitializeComponent();
        }

        private void RenklerinDili_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "yiğit" && textBox2.Text == "12345")
            {
                RenklerinDili2 renkler = new RenklerinDili2();
                renkler.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı giriş yaptınız");
                textBox1.Clear();
                textBox2.Clear();
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
