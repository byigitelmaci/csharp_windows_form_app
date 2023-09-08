using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_4_Çok_Biçimlilik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            Ekmek ekm = new Ekmek("Uno",2,"Kepekli",100);
            spt.urunekle(ekm);
            MessageBox.Show(spt.toplamtutar().ToString());

        }
    }
}
