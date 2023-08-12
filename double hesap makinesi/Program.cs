using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_hesap_makinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, toplam, cıkarma, carpma, bolme;


            Console.WriteLine("****hesap makinesi****");
            Console.WriteLine();

            Console.WriteLine("birinci sayiyi giriniz");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz");
            sayi2 = Convert.ToDouble(Console.ReadLine());


            toplam = sayi1 + sayi2;
            Console.WriteLine("toplam= " + toplam);

            cıkarma = sayi1 - sayi2;
            Console.WriteLine("cıkarma= " + cıkarma);

            carpma = sayi1 * sayi2;
            Console.WriteLine("carpma= " + carpma);

            bolme = sayi1 / sayi2;
            Console.WriteLine("bolme= " + bolme);

            Console.Read();

        }
    }
}
