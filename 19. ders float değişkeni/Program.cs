using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ders_float_değişkeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    float s1, s2, toplam;
            //    s1 = 25;
            //    s2 = 45;
            //    toplam = s1 + s2;
            //    Console.WriteLine("toplam;" +toplam);
            //    Console.Read();
            //    ---------------------------------------------------------------------------------------

            //float sayi;
            //sayi = 2.1427358f; //f koymamızın sebebi float da ondalık bi sayı yazıcak f yazmak zorundayız yoksa hata verir.(büyük F de yazabiliriz)
            //Console.Write(sayi);
            //Console.Read();
            //---------------------------------------------------------------------------

            int x = 3;
            float y = 2.5F;
            int z = 4;
            float toplam;
            toplam = x + y + z;
            Console.Write("Toplam: " + toplam);
            Console.Read();
        }
    }
}
