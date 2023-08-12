using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kara_yapıları_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;

            Console.WriteLine("sayıyı giriniz");
            sayı = Convert.ToInt32(Console.ReadLine());

            if (sayı > 0)
            {
                Console.WriteLine("pozitif tam sayı girdiniz");
            }
            else
            {
                Console.WriteLine("negatif tam sayı girdiniz");
            }

            Console.Read();
        }
    }
}
