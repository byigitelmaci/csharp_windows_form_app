using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ders_ornek_program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;

            Console.WriteLine("sayı girin");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 5  ==0)
            {
                Console.Write("sayı 5 e tam bölünür");
            }
            else
            {
                Console.Write("sayı 5 e tam bölünmez");

            }
            Console.Read();
        }
    }
}
