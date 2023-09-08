using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Property_Type_ders_16.models
{
    internal class personnel
    {
        public string name { get; set; }
        public string surname { get; set; }
        //public string branch { get; set; }
        public branch branch { get; set; } 
    }
}
