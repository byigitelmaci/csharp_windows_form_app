using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4_Çok_Biçimlilik
{
    public class ceptelefonu:ürün
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }
        public ceptelefonu(string ad,double fiyat,string marka) 
        {
            urunadi = ad;
            Fiyat = fiyat;
            Marka = marka;
            
        }
    }
}
