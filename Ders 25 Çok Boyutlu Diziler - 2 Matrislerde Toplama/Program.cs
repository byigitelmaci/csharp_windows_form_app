using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_25_Çok_Boyutlu_Diziler___2_Matrislerde_Toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("*Matrislerde Toplama*");
            //int[,] matris1 = { { 10, 12, 14, 18 }, { 20, 14, 16, 13 }, { 25, 14, 41, 21 }, { 32, 36, 41, 57 } };
            //int[,] matris2 = { { 40, 30, 20, 10 }, { 7, 9, 8, 6 }, { 21, 22, 23, 24 }, { 34, 35, 36, 37 } };

            //int[,] toplam = new int[4, 4];

            //for (int i = 0 ; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        toplam[i, j] = matris1[i, j] + matris2[i, j];

            //    }
            //}

            //for (int k = 0; k < 4; k++)
            //{
            //    Console.WriteLine();
            //    for (int m = 1; m < 2; m++)
            //    {
            //        Console.Write(toplam[k, m] + " ");
            //    }
            //}
            //Console.Read();
            //--------------------------------------------------------------------------------------------------------------



            string[,] dizi = {
                { "Ahmet", "Deniz" },
                { "Ali", "Can" },
                { "Yiğit", "Günbey" }
            };

            for (int i = 0; i < 3; i++)
            {
                var rnd = new Random().Next(0, 2);
                Console.WriteLine(" {0}{1}", dizi[i, 0], dizi[rnd,1]);
            }
            Console.Read();



            //----------------------------------------------------------------------------------------------
            //string ahmet, deniz, ali, can, yigit, gunbey;
            //string[,] matris1 = { { ahmet, deniz } };
            //string[,] matris2 = { { ali, can } };
            //string[,] matris3 = { { yigit, gunbey } };

            //string[,] toplam = new int [ 1, 3 ];

            //for (int ahmet = 0; ahmet < 3; ahmet++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //           toplam[ahmet, deniz, ali, can, yigit, gunbey] = matris1[ ahmet,deniz  ] + matris2[ ali,can ] + matris3[ yigit,gunbey];
            //        }
            //    }
            //}

            //for (int q = 0;  q < 3; q++)
            //{
            //    for (int l = 0;  l < 3; l++)
            //    {
            //        Console.WriteLine();
            //        for(int m = 0; m < 3; m++)
            //        {
            //            Console.Write(toplam[q, l,m] + " ");
            //        }
            //    }
            //}

            //---------------------------------------------------------------------------------------------
        }






    }



}
