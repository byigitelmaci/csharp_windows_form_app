using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4_Çok_Biçimlilik
{
    public class Sepet
    {
        private List<ürün> urunler = new List<ürün>();
        public double toplamtutar()
        {
            double toplamfiyat = 0;
            foreach(ürün item in urunler) 
            {
                toplamfiyat += item.kdvuygula();

            }
            return toplamfiyat;

        }
        public void urunekle(ürün yeniürün) 
        {
            urunler.Add(yeniürün);
        }
    }
}
