using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_anlatıcam2.models
{
    public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; } 

        public string TamIsim()
        {
            return $"{Ad} {Soyad}";
        }
    }
}
