using list_yapısı_ders25.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_yapısı_ders25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> meyveler = new List<string>();
            //meyveler.Add("elma");
            //meyveler.Add("armut");
            //meyveler.Remove("elma"); //silmek için remove kullanıyoruz.


            List<meyve> meyveler = new List<meyve>()
            {
                new meyve("elma","D")
                new meyve("armut","a")  

            };
            
            meyve meyve = new meyve();
            meyve.isim = "elma";
            meyve.vitamin = "C";
            meyveler.Add(meyve);


        }
    }
}
