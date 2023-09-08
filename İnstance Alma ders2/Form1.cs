using İnstance_Alma_ders2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnstance_Alma_ders2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Yazar yazar1 = new Yazar();
            yazar1.yazarismi = "agatha";
            yazar1.soyisim = "uıaerhf";
            yazar1.Yaz ("ölüm sessiz geldi");

            Yazar yazar2 = new Yazar();
            yazar2.yazarismi = "yakup kadri";
            yazar2.soyisim = "karaosmanoğlu";
            yazar2.Yaz("kiralık konak");

        }
    }
}
