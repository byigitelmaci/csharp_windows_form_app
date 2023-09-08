using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ders_18.models
{
    public abstract class karakter
    {
        public virtual void saldir()
        {

            System.Windows.Forms.MessageBox.Show("Normal saldırı yap");
        }

    }

}
