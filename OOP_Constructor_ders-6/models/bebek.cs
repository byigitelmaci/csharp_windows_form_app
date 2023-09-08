using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructor_ders_6.models
{
    public class bebek
    {
        public bebek()
        {
            BirthDate = DateTime.Now;
        }


        public string Name { get; set; }
        public DateTime BirthDate { get; set; }


    }


   

    
}
