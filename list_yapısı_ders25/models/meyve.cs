using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_yapısı_ders25.models
{
    public class meyve
    {
        public meyve()
        {
        }

        public meyve(string _isim, string _vitamin)
        {
            isim = _isim;
            vitamin = _vitamin;
        }
        public string isim { get; set; }
        public string vitamin { get; set; }
        public List<string> Arabalar { get; set; }

    }
}
