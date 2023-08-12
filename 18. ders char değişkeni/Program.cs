using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ders_char_değişkeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char cinsiyet;
            //Console.Write("cinsiyeti giriniz ; ");
            //cinsiyet=Convert.ToChar(Console.ReadLine());
            //if (cinsiyet=='e' || cinsiyet=='E')
            //{
            //    Console.Write("cinsiyet erkektir");
            //}
            //else if (cinsiyet=='k' ||  cinsiyet=='K')
            //{
            //    Console.Write("cinsiyet kadındır");
            //}
            //Console.Read();
            //----------------------------------------------------------------------
            char ders;
            Console.WriteLine("****YGS Ders Listesi**** \n");
            Console.WriteLine("Türkçe...");
            Console.WriteLine("Matematik...");
            Console.WriteLine("Sosyal Bilgiler...");
            Console.WriteLine("Fen Bilgisi....");
            Console.Write("Hangi Dersin Bilgilerini Görmek İstersiniz ; ");

            ders=Convert.ToChar(Console.ReadLine());
            if (ders == 't' || ders == 'T')
            {
                Console.WriteLine("türkçe dersi paragraf ağırlıklı olup dil bilgisi içerir");
            }
            else if (ders == 'm' || ders == 'M')
            {
                Console.WriteLine("matemaik dersi temel mat1 konulaı ve 8 9 tane geometri sorusu içerir");
            }
            else if (ders == 's' || ders == 'S')
            {
                Console.WriteLine("sosyal bilgiler dersi tarih ve coğeafya konularını9 içerir");
            }
            else if (ders == 'f' || ders == 'F')
            {
                Console.WriteLine("fen bilgisi fizik,kimya ve biyoloji konularını içerir");
            }

            Console.Read();

        }
    }
}
