
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ders_1.örnek_mevsim_ayları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mevsim;
            Console.WriteLine("mevsim giriniz");
            mevsim = Console.ReadLine();

            if (mevsim == "kış" || mevsim == "yaz" || mevsim == "sonbahar" || mevsim == "ilkbahar")
            {
                Console.WriteLine("doğru mevsim girişi");
            }
            else
            {
                Console.WriteLine("yanlış mevsim girişi");
            }




            if (mevsim == "kış")
            {
                Console.WriteLine("kış mevsim ayları;aralık,ocak,şubat");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.WriteLine("ilkbahar mevsim ayları;mart,nisan,mayıs");
            }
            else if (mevsim == "yaz")
            {
                Console.WriteLine("yaz mevsimi ayları;haziran,temmuz,agustos");
            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine("sonbahar mevsimi ayları;eylul,ekım,kasım");
            }
            else
            {
                Console.WriteLine("hatslı mevsim girişi");
            }

            Console.Read();


            //------------------------------------------------------------------------------------------------------------

            //double x, indirim, ödenecek;

            //Console.WriteLine("alışveriş tutarını giriniz");
            //x = Convert.ToDouble(Console.ReadLine());

            //if (x < 100)
            //{
            //    indirim = x * 10 / 100;
            //    ödenecek = x - indirim;
            //    Console.WriteLine("indirim;" + indirim);
            //    Console.WriteLine("toplam miktar;" + ödenecek);

            //}

            //if (x >= 100 && x <= 150)
            //{
            //    indirim = x * 15 / 100;
            //    ödenecek = x - indirim;
            //    Console.WriteLine("indirim;" + indirim);
            //    Console.WriteLine("toplam miktar;" + ödenecek);
            //}
            //if (x >= 150 && x <= 200)
            //{
            //    indirim = x * 20 / 100;
            //    ödenecek = x - indirim;
            //    Console.WriteLine("indirim;" + indirim);
            //    Console.WriteLine("toplam miktar;" + ödenecek);

            //}

            //Console.Read();

        }
    }
}
