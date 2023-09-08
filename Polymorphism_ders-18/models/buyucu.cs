using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ders_18.models
{
    internal class buyucu : karakter
    {
        public override void saldir()
        {
            System.Windows.Forms.MessageBox.Show("büyü ile saldır");

        }


    }
}
