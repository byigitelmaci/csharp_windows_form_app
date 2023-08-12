using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar_yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim;

            isim = "mehmett";

            if (isim == "mehmet")
            {
                Console.Write("dogru isim girişi");
            }
            else
            {
                Console.Write("hatalı isim girişi");
            }
            Console.Read();
        }
    }
}
