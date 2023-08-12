using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ders_diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 10, 45, 67, 87, 34, 76, 15, 59 };
            //Console.WriteLine(sayilar[5]);
            //Console.Read();
            //Console.ReadLine();

            //----------------------------------------------------------------------------------------------------

            //string[] sehirler = new string[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("sehir:");
            //    sehirler[i] = Console.ReadLine();
            //}
            //Console.WriteLine("******sehirler listesi*******");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}
            //Console.Read();


            int[] sayilar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write( "Sayiyi Girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadLine();

        }
    }
}
