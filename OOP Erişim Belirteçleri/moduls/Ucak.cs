using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Erişim_Belirteçleri.moduls
{
    public class Ucak
    {
        public string Pilot { get; set; }
        internal string Model { get; set; }

        private void Uc()
        {
            System.Windows.Forms.MessageBox.Show("Uçuyoruz!!!!!");
            
        }


    }
}
