using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Keyword_ders21.models
{
    public abstract class boss:karakter
    {
        public sealed override void yuru()
        {
            System.Windows.Forms.MessageBox.Show("boss gibi yürü");

        }
    }
}
