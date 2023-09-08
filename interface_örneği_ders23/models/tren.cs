using interface_örneği_ders23.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_örneği_ders23.models
{
    public class tren:Iarac
    {
        public tren(string _isim, string _soyisim, string _baslangıcnoktası, string _bitisnoktası)
        {
            isim = _isim;
            soyisim = _soyisim;
            baslangıcnoktası = _baslangıcnoktası;
            bitisnoktası = _bitisnoktası;


        }

        public string isim { get; set; }
        public string soyisim { get; set; }
        public string baslangıcnoktası { get; set; }
        public string bitisnoktası { get; set; }

        public string yataklımı { get; set; }
    }
}
