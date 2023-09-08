using ders_anlatılıcak_erişim_belirteçleri.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucak ucak = new ucak();

            ucak.Pilot // burdan sadece pilota erişebiliyorum çünkü sadece o public
        }
    }
}
