using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4_Çok_Biçimlilik
{
    internal class tekstil:ürün
    {
        public string Kumasturu { get; set; }
        public int Beden { get; set; }
        public string Ureticifirma { get; set; }

        public tekstil(string ad, double fiyat, string kumasturu,int beden) 
        {
            urunadi=ad;
            Fiyat=fiyat;
            Kumasturu=kumasturu;
            Beden=beden;

        }
    }
}
