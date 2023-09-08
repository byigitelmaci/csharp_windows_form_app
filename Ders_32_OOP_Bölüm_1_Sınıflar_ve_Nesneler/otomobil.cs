using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_32_OOP_Bölüm_1_Sınıflar_ve_Nesneler
{
    internal class otomobil
    {
        public string marka { get; set; }
        public string model { get; set; }
        public int modelyılı { get; set; }
        public string renk { get; set; }
        public string vitestipi { get; set; }
        public string markagetir()
        {
            return marka;
        }
    }
}
