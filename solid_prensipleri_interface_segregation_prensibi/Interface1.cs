using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_prensipleri_interface_segregation_prensibi
{

    //Nesnelerin kullanmayacakları method'lara bağımlı olmaması gerektiğini savunmaktadır
    public interface Interface1
    {
        string ad { get; set; }
        string marka { get; set; }
        int fiyat { get; set; }
    }

    interface yiyecek
    {
        int kalori { get; set; }
        
    }
    interface giyim
    {
        string bedenolcusu { get; set; }
    }
    class yemek : Interface1, yiyecek
    {
        public string ad { get ; set; }
        public string marka { get ; set; }
        public int fiyat { get ; set ; }
        public int kalori { get ; set ; }
    }

    class kıyafet : Interface1, giyim
    {
        public string bedenolcusu { get ; set ; }
        public string ad { get  ; set ; }
        public string marka { get ; set ; }
        public int fiyat { get ; set ; }
    }
}
