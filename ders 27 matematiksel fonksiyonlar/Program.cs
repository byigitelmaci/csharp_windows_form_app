using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_27_matematiksel_fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double sayi;
            //Console.Write("sayıyı giriniz ;");
            //sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("sayının üste yuvarlanmış hali ;" + Math.Ceiling(sayi));
            //Console.Read();

            //-------------------------------------------------------------------------------

            //double sayi;
            //Console.Write("sayıyı giriniz ;");
            //sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("sayının alta yuvarlanmış hali ;" + Math.Floor(sayi));
            //Console.Read();

            //------------------------------------------karekökünü alma-------------------------------------

            //double sayi;
            //Console.Write("sayıyı giriniz ;");
            //sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("aonuç ;" + Math.Sqrt(sayi));
            //Console.Read();

            //----------------------------kosinüs---------------------------------------------------

            //double sayi;
            //Console.Write("sayıyı giriniz ;");
            //sayi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("sonuç ;" + Math.Cos(sayi));
            //Console.Read();

            //---------------------------büyük sayıyı bulma----------------------------------------

            //double sayi1, sayi2;
            //Console.Write("1.sayıyı giriniz ;");
            //sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz ;");
            //sayi2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("büyük sayi;" + Math.Max(sayi1, sayi2));
            //Console.Read();


            //--------------------------kuçük sayıyı bulma-----------------------------------------

            double sayi1, sayi2;
            Console.Write("1.sayıyı giriniz ;");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. sayıyı giriniz ;");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("küçük sayi;" + Math.Min(sayi1, sayi2));
            Console.Read();

        }
    }
}
