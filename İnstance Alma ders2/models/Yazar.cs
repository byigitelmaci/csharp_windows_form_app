using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnstance_Alma_ders2.models
{
    public class Yazar
    {
        //neyi var????
        public string yazarismi { get; set; }
        public string soyisim { get; set; }
         //ne yapabilir??

        public void Yaz(string Kitapadi)
        {
            System.Windows.Forms.MessageBox.Show($"{Kitapadi} kitap {yazarismi} {soyisim} adli yazarın eseridir.");

        }

    }
}
