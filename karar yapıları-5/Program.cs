
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar_yapıları_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, ort;


            Console.WriteLine("birinci sinavinizi giriniz");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            ort = (sinav1 + sinav2) / 2;
            Console.WriteLine("ort= " + ort);

            if (ort >=50) 
            {
                Console.WriteLine("öğrenci dersi geçti");

            }
            else
            {
                Console.WriteLine("öğrenci dersi geçemedi");

            }

            Console.Read();



        }
    }
}
