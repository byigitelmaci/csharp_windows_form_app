using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_ve_decimal_ödev_vergi_hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //float ürün1, ürün2, ürün3, ürün4, ürün5, toplam1, toplam2, toplam3, toplam4, toplam5, kdv;
            //Console.WriteLine("ürünlerin fiyatını giriniz");
            //kdv = 20;
            //ürün1 = Convert.ToInt16(Console.ReadLine());
            //ürün2 = Convert.ToInt16(Console.ReadLine());
            //ürün3 = Convert.ToInt16(Console.ReadLine());
            //ürün4 = Convert.ToInt16(Console.ReadLine());
            //ürün5 = Convert.ToInt16(Console.ReadLine());
            //toplam1 = ürün1 * (1 + kdv / 100);
            //toplam2 = ürün2 * (1 + kdv / 100);
            //toplam3 = ürün3 * (1 + kdv / 100);
            //toplam4 = ürün4 * (1 + kdv / 100);
            //toplam5 = ürün5 * (1 + kdv / 100);
            //Console.WriteLine("ödenecek tutar" + toplam1);
            //Console.WriteLine("ödenecek tutar" + toplam2);
            //Console.WriteLine("ödenecek tutar" + toplam3);
            //Console.WriteLine("ödenecek tutar" + toplam4);
            //Console.WriteLine("ödenecek tutar" + toplam5);

            //Console.Read();

            //---------------------------------------------------------------------------




            //float[] urunler = new float[5];
            //float kdv = 20;
            //float toplam = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write((i + 1).ToString() + " .Ürünün Fiyatını Girin: ");

            //    urunler[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (int i in urunler)
            //{
            //    toplam = toplam+ i *(1 + kdv / 100);

            //}
            //Console.WriteLine(toplam);



            //Console.ReadLine();

            decimal[] urunler = new decimal[5];
            decimal kdv = 20;
            decimal toplam = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write((i + 1).ToString() + " .Ürünün Fiyatını Girin: ");

                urunler[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in urunler)
            {
                toplam = toplam + i * (1 + kdv / 100);

            }
            Console.WriteLine(toplam);



            Console.ReadLine();




        }
    }
}
