using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Ders_22_Bool_Değişkeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi;
            //Console.WriteLine("sayıyı girin");
            //sayi= Convert.ToInt32(Console.ReadLine());
            //bool durum1 = sayi > 0;
            //bool durum2 = sayi > 10;
            //Console.WriteLine("sayı pozitif mi {0}", durum1);
            //Console.WriteLine("sayı 10 dan büyük mü {0}", durum2);
            //Console.ReadLine();
            //------------------------------------------------------------------------------------------

            Console.Write("şifreyi giriniz: ");
            int sifre;
            sifre = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sifre == 1234;
            Console.WriteLine("şifre doğru mu {0} ", durum1);
            Console.ReadLine();
        }
    }
}
