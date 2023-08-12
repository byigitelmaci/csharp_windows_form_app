using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ders_örnek_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sinav1, sinav2, proje, ort;

            Console.WriteLine("birinci sinavi giriniz");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sinavi giriniz");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("projeyi giriniz");
            proje = Convert.ToInt32(Console.ReadLine());

            ort = (sinav1 + sinav2 + proje) / 3;
            Console.WriteLine("ort= " + ort);

            if (ort > 0 && ort < 30)
            {
                Console.Write("durum;kötü");
            }
            else if (ort > 30 && ort < 50)
            {
                Console.Write("durum;idare eder");
            }
            else if (ort > 50 && ort < 70)
            {
                Console.Write("durum;iyi");
            }
            else if (ort > 70 && ort < 90)
            {
                Console.Write("durum;çok iyi");
            }
            
            else if (ort > 90 && ort < 100)
            {
                Console.Write("durum;mükemmel");
            }
                
            
            Console.Read();
        }
    }
}
