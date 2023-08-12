using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2, toplam;

            Console.WriteLine("Birinci sayıyı giriniz=");
            sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz=");
            sayı2 = Convert.ToInt32(Console.ReadLine());


            toplam = sayı1 + sayı2;
            Console.WriteLine("Toplam = " + toplam);

            Console.Read();

        }
    }
}
