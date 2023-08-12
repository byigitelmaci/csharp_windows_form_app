using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ders_random_komutu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random rastgele = new Random();
            //int a;
            //a=rastgele.Next(0,10);
            //Console.WriteLine(a);
            //Console.ReadLine();

            //---------------------------------------------------------------------------

            //Random rastgele = new Random();
            //int a;
            //int b;
            //a = rastgele.Next(0,10);
            //b = rastgele.Next(0,10);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.ReadLine();

            //----------------------------------------------------------------------------

            //Random rastgele = new Random();
            //int a;
            //a = rastgele.Next(50);
            //Console.WriteLine(a);
            //Console.ReadLine();

            //----------------------------------------------------------------------------

            //Random rastgele = new Random();
            //Console.WriteLine("****şehirler listesi****");
            //string[] sehirler = { "amasya", "istanbul", "trabzon", "malatya", "mardin", "samsun", "şanlıurfa", "ığdır", "karabük", "elazığ", "kahramanmaraş", "tokat", "rize", "batman", "konya" };
            //int a;
            //a = rastgele.Next(0,sehirler.Length); //sehirler.length yazmamızın sebebebi mesela bi çekiliş olucak ama kaç kişinin katıldığı bilinmiyo o yüzden sehirler.length yazdık kı dizinin son sayısına kadar geçerli olsun 
            //Console.WriteLine(a);
            //Console.WriteLine(sehirler[a]);
            //Console.ReadLine();
            //---------------------------------------------------------------------------
            
            Random rastgele = new Random();
            Console.WriteLine("****milli piyango çekilişi****");
            int a;
            int b;
            int c;
            int d;
            int e;
            int f;
            int g;
            a = rastgele.Next(0, 9);
            b = rastgele.Next(0, 9);
            c = rastgele.Next(0, 9);
            d = rastgele.Next(0, 9);
            e = rastgele.Next(0, 9);
            f = rastgele.Next(0, 9);
            g = rastgele.Next(0, 9);
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);
            Console.Write(f);
            Console.Write(g);
            Console.ReadLine();

        }
    }
}
