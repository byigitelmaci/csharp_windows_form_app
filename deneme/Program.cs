using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int sayilar1;
            // sayilar1 sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10;




            // Console.WriteLine("birinci sayıyı giriniz");
            // sayi1=Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("ikinci sayıyı giriniz");
            // sayi2 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("üçüncü sayıyı giriniz");
            // sayi3 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("dördüncü sayıyı giriniz");
            // sayi4 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("beşinci sayıyı giriniz");
            // sayi5 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("altıncı sayıyı giriniz");
            // sayi6 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("yedinci sayıyı giriniz");
            // sayi7 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("sekizinci sayıyı giriniz");
            // sayi8 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("dokuzuncu sayıyı giriniz");
            // sayi9 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("onuncu sayıyı giriniz");
            // sayi10 = Convert.ToInt32(Console.ReadLine());

            //Console.ReadLine();


            //------------------------------------------------------------------------------------------------------


            //int sayi = 10;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write((i + 1).ToString() + " .Sayiyi Girin: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.Read();

            //----------------------------------------------------------------------------------------------------------

            //int[] sayilar = new int[10];
            //int toplam = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write((i + 1).ToString() + " .Sayiyi Girin: ");

            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (int i in sayilar)
            //{
            //    if (i % 2 == 1)
            //    {
            //        toplam = toplam + i;
            //    }
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();



            //--------------------------------------------------------------------------------------


            //int[] sayilar = { 4, 1, 7, -8, 23, 14, 51, 84, -75, 26, -8, 9 };
            //foreach (int i in sayilar)
            //{
            //    if (i > 0 && i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read();

            //-----------------hexdecimali binary ye çevirme----------------------
            string x = "11011011";
            
            x = "B26";
            Console.WriteLine(Convert.ToString(Convert.ToInt32(x, 16), 2));

            Console.Read();

        }
    }
}
