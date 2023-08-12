using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ders_dögüler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-------------------------1 den 100 e kadar 9 u bölen sayılar------------------------------------- 

            //int i;
            //for(i = 0; i <=100;  i++)
            //{
            //    if (i %9  == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read();

            //-----------------------------------------fibonaçi---------------------------------------------------------------------
            int a = 1;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);
             for (int i = 1; i <=8; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);

            }
            Console.Read();
        }
    }
}
