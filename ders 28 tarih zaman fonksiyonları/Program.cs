using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_28_tarih_zaman_fonksiyonları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime zaman;
            //zaman = DateTime.Now;
            //Console.WriteLine("tarih ve saat: {0}", zaman);
            //Console.Read();
            //--------------------------------------------------------------------

            //DateTime zaman;
            //zaman= DateTime.Now;
            //int ay = zaman.Month;
            //int gun = zaman.Day;
            //int yıl = zaman.Year;
            //DayOfWeek haftanıngunu = zaman.DayOfWeek;
            //Console.WriteLine("gun: {0}", gun);
            //Console.WriteLine("ay: {0}", ay);
            //Console.WriteLine("yıl: {0}", yıl);
            //Console.WriteLine("haftanın günü: {0}", haftanıngunu);
            //Console.Read();
            //------------------------------------------------------------------------

            DateTime zaman;
            zaman = DateTime.Now;
            Console.WriteLine("csharp dersleri tarih saat fonksiyonları");
            Console.WriteLine();
            Console.WriteLine("kısa tarih: {0:d}", zaman);
            Console.WriteLine("uzun tarih: {0:D}", zaman);
            Console.WriteLine("tam tarih: {0:f}", zaman);
            Console.WriteLine("tam tarih 2: {0:F}", zaman);
            Console.WriteLine("sayısal tarih formatı:{0:g}",zaman);
            Console.WriteLine("sayısal tarih formatı:{0:G}", zaman);
            Console.WriteLine("ay: {0:m}", zaman);
            Console.WriteLine("biçim: {0:r}", zaman);
            Console.WriteLine("biçim 2: {0:s}", zaman);
            Console.WriteLine("saat: {0:t}", zaman);
            Console.WriteLine("saat 2: {0:T}", zaman);
            Console.WriteLine("yıl: {0:Y}", zaman);
            Console.Read();









        }
    }
}
