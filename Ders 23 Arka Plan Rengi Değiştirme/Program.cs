using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_23_Arka_Plan_Rengi_Değiştirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkRed;          //arka plan rengini değiştirme 
            //Console.ForegroundColor = ConsoleColor.Yellow;          //yazının rengini değiştirme
            //Console.Title = "18 mart 2016 mart";                   //console sayfasının başlığını değiştirme
            //Console.Clear();
            //Console.WriteLine("18 Mart Çanakkale Şehitleri Anma Günü");
            //Console.ReadLine();

            //---------------------------------------------------------------------------------------------------

            Console.WriteLine("lütfen bi sayı giriniz");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt16(Console.ReadLine());
            Console.BackgroundColor=renk;
            Console.Clear();
            Console.ReadLine();
        }
    }
}
