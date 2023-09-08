using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_anlatıcam2.models
{
    public class Otomobil 
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Beygir { get; set; }
        public virtual int KapiSayisi { get; set; } = 2;

        public string Isim()
        {
            return $"{this.Marka} {this.Model}";
        }

        //public static string Isim(Otomobil otomobil)
        //{
        //    return $"{otomobil.Marka} {otomobil.Model}";
        //}
    }
}
