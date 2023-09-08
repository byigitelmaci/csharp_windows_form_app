using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4_Çok_Biçimlilik
{
    public class ürün
    {
        public string urunadi { get; set; }
        public double Fiyat { get; set;}
        public virtual double kdvuygula() 
        {
            return Fiyat * 1.08;
        }
        public ürün()
        {
            
        }
        public ürün(string ad, double fiyat)
        {
            urunadi= ad;
            Fiyat=fiyat;
        }


    }
}
