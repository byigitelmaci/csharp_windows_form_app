using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ders_döngüler__for_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //for (i=1; i <=10; i++) 
            //{
            //    Console.WriteLine("merhaba dünya");
            //}
            //Console.Read();

            //-----------------------------------------------------------------------------------------------------------------------------


            int i;
            int toplam = 0;
            for (i = 1; i <= 10; i+=2)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("toplam =" + toplam);
            Console.Read();

           


        }
    }
}
