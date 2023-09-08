using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace not_ortalaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sinav1, sinav2, sinav3, proje, ort;
            string isim, soyisim, numara;

            Console.WriteLine("öğrenci bilgileri");
            Console.WriteLine();

            Console.Write("isminiz=");
            isim = Console.ReadLine();

            Console.Write("soy isminiz=");
            soyisim = Console.ReadLine();

            Console.Write("numaranız=");
            numara = Console.ReadLine();

            Console.WriteLine("*****Not bilgileri*****");
            Console.WriteLine();

            Console.WriteLine("birinci sinavi giriniz");
            
            sinav1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ikinci sinavi giriniz");
            sinav2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ücüncü sinavi giriniz");
            sinav3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("projeyi giriniz");
            proje = Convert.ToDouble(Console.ReadLine());


            ort = (sinav1 + sinav2 + sinav3 + proje) / 4;
            Console.WriteLine(isim,soyisim,numara);


            Console.WriteLine("ort=" + ort);



            Console.Read();
        }
    }
}
