using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace _15.ders_foreach_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] sehirler = {"mersin", "adana", "amasya", "trabzon", "maraş", "urfa"};

            // foreach (string i in sehirler)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();
            //-------------------------------------------------------------------------------------------------------------------------------------
            //            int[] sayılar = { 1, 2, 56, 76, 87, 345, 25, 567, 235, 234, 675 };

            //            foreach (int i in sayılar)
            //            {
            //                Console.WriteLine(i);
            //            }
            //            Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------
            int[] sayilar = { 45, 56, 78, 34, 12 };
            int toplam = 0;
            foreach (int i in sayilar)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("toplam:" + toplam);
            Console.Read();
        }
    }
}
