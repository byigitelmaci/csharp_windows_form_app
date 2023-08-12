using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_26_çok_boyutlu_diziler___3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int satir, sutun;
            //Console.Write("satır sayısını giriniz; ");
            //satir =Convert.ToInt16(Console.ReadLine());
            //Console.Write("sütun sayısını giriniz; ");
            //sutun =Convert.ToInt16(Console.ReadLine());
            //int[,] matris = new int[satir, sutun];

            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sutun; j++)
            //    {
            //        Console.Write("matrisin {0} × {1} değeri ; ", i + 1, j + 1); 
            //        matris[i, j] = Convert.ToInt16(Console.ReadLine()); 
            //    }
            //}
            //for (int k = 0; k < satir; k++)
            //{
            //    for (int n = 0; n < sutun; n++)
            //    {
            //        Console.Write(matris[k, n] + " ");
            //    }
            //    Console.WriteLine();
            //}
            ////transpoze
            //Console.WriteLine();

            //for (int x = 0; x < satir; x++)
            //{
            //    for (int y = 0; y < sutun; y++)
            //    {
            //        Console.Write(matris[y, x] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            ////kat sayı ile çarpımı

            //for (int s = 0; s < satir; s++)
            //{
            //    for (int p = 0; p < sutun; p++)
            //    {
            //        Console.Write(matris[s, p] * 5 + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();     
            //------------------------------------------------------------------------------------

            int a, b, c, d, sonuc;
            Console.Write("A Değeri ; ");
            a=Convert.ToInt16(Console.ReadLine());
            Console.Write("B Değeri ; ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("C Değeri ; ");
            c=Convert.ToInt16(Console.ReadLine());
            Console.Write("D Değeri ; ");
            d=Convert.ToInt16(Console.ReadLine());

            sonuc = Math.Abs((a * d) - (b * c));
            Console.WriteLine("Determinant: " + sonuc);

            Console.Read();

            
        }
    }
}
