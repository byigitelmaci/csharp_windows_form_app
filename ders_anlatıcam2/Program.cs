using ders_anlatıcam2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_anlatıcam2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ogrenci abc = new Ogrenci()
            {
                Ad = "Yiğit",
                Soyad = "Elmacı",
                Yas = 16,
                Sinif = 12,
                Sube = "D"
            };

            Console.WriteLine(Matematik.Topla(abc.Sinif, abc.Yas));

            Console.ReadKey();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
