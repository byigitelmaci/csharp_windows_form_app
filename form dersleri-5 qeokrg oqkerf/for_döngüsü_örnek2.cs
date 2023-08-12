using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri_5_qeokrg_oqkerf
{
    public partial class for_döngüsü_örnek2 : Form
    {
        public for_döngüsü_örnek2()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            i++;
            label1.Text = i.ToString();
        }
    }
}
