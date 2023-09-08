using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_32_OOP_Bölüm_1_Sınıflar_ve_Nesneler
{
    internal class ev
    {
        public string turu { get; set; }
        public string renk { get; set; }

        public int odasayısı { get; set; }
        public int kat { get; set; }

        public string evigoster()
        {
            return turu;
        }
    }
}
