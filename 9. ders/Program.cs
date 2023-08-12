using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi;

            //Console.WriteLine("1 ile 7 arasında bi rakam giriniz");
            //sayi = Convert.ToInt32(console.readline);



            //switch (sayi)
            //{
            //    case 1: Console.WriteLine("Gün Pazartesi");
            //        break;
            //    case 2: Console.WriteLine("Gün Salı");
            //        break;
            //    case 3: Console.WriteLine("Gün çarşamba");
            //        break;
            //    case 4: Console.WriteLine("Gün Perşembe");
            //        break;
            //    case 5: Console.WriteLine("Gün Cuma");
            //        break;
            //    case 6: Console.WriteLine("Gün Cumartesi");
            //        break;
            //    case 7: Console.WriteLine("Gün Pazar");
            //        break;
            //    default:Console.WriteLine("hatalı gün girişi");
            //        break;


            //}
            //Console.Read();
            //----------------------------------------------------------------------------------------------------


            //    string mevsim;
            //    Console.WriteLine("lütfen mevsimi küçük harflerle yazınız");
            //    mevsim = Console.ReadLine();

            //    switch (mevsim)
            //    {
            //        case "kış":Console.WriteLine("aralık,ocak,şubat");
            //            break;
            //        case "ilkbahar":Console.WriteLine("mart,nisan,mayıs");
            //            break;
            //        case "yaz":Console.WriteLine("haziran,temmuz,ağustos");
            //            break;
            //        case "sonbahar":Console.WriteLine("eylül,ekim,kasım");
            //            break;
            //        default:Console.WriteLine("hatalı mevsim girişi");
            //            break;

            //    }
            //    Console.Read();



            //    -------------------------------------------------------------------------------------------

            string sehir;
            Console.WriteLine("lüten şehri giriniz");
            sehir = Console.ReadLine();

            switch (sehir)
            {
                case "adana":Console.WriteLine("iistanbul adana arası 939 km");
                    break;
                case "amasya":Console.WriteLine("istanbul amasya arası 640 km");
                    break;
                case "trabzon":Console.WriteLine("istanbul aydın arası 800 km");
                    break;
                case "mardin":Console.WriteLine("istanbul mardin arası 1500 km");
                    break;
                case "ankara":Console.WriteLine("istanbul ankara arası 700 km");
                    break;
                default:Console.WriteLine("yanlış şehir girdiniz");
                    break;


            }
            Console.ReadLine();
        }



    }
}
