using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_Object_ders_20.models
{
    internal class student
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int yas { get; set; }

        public override string ToString()
        {
            return isim + soyisim;
        }


    }
}
