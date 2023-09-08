using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Constructor_ders_14.models
{
    public class baseclass
    {
        public string Name { get; set; }
        public DateTime KayıtTarihi { get; set; }
        private string deneme;
        public baseclass() 
        {
            KayıtTarihi = DateTime.Now;
        }  
    }
}
