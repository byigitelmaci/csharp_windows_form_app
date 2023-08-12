using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _20.ders_decimal_değişkeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //decimal sayi;
            //sayi = 12.345m; //m koymamızın sebebi ondalıklı bi değer giriceğimiz zaman m yi zorunlu kılması
            //Console.Write(sayi);
            //Console.Read();

            //------------------------------------------------------
            //decimal s1;
            //int s2;
            //s1 = 2.45M;
            //s2 = 6;
            //decimal toplam;
            //toplam = s1 + s2;
            //Console.WriteLine("toplam ; " +toplam);

            //Console.Read();
            //--------------------------------------------------------------------------------

            //decimal x = 0.996M;
            //decimal y = 999999;
            //Console.WriteLine("para1 {0:C}", x);
            //Console.WriteLine("para2 {0:C}", y);
            //Console.WriteLine("x:" + x);
            //Console.WriteLine("y:" + y);
            //Console.Read();
            //--------------------------------------------------------------------------------

            decimal urun1, urun2, toplam;
            int s1, s2;
            urun1 = 14.85M;
            urun2 = 21.48m;
            Console.Write("1. Ürünün Satış Miktarı: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.Ürünün Satış Miktarı: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 * urun1 + s2 * urun2;
            Console.WriteLine("Gün Sonunda Kasada Olması Gereken Tutar: " + toplam + " TL'dir");
            Console.Read();
        }
    }
}
