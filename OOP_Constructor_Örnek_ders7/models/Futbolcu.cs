using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructor_Örnek_ders7.models
{
    public class Futbolcu
    {

        public Futbolcu(string _isim,string _ulke)
        {
            Isim = _isim;
            Ulke = _ulke;
            switch (Ulke)
            {
                case "brezilya":
                    Sutgucu = 20;
                    break;
                case "italya":
                    Sutgucu = 15;
                    break;
                case "fransa":
                    Sutgucu = 10;
                    break;

            }
        }





        public string Isim { get; set; }
        public string Ulke { get; set; }
        public int Moral { get; set; }
        public int Sutgucu { get; set; }

    }
}
