using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Keyword_ders21.models
{
    public abstract class karakter
    {
        public string name { get; set; }
         public virtual void yuru()
        {
            System.Windows.Forms.MessageBox.Show("normal yurume");
        }
    }
}
