using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar_yapıları_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir;

            Console.WriteLine("türkiyenin Baskenti Neresidir?");
            sehir = Console.ReadLine();

            
            if (sehir == "Ankara") 
            {
                Console.WriteLine("doğru şehir girişi");
            }
            else
            {
                Console.WriteLine("yanlış şehir girişi");
            }
            Console.Read();

        }
    }
}
