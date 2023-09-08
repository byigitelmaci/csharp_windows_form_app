using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_anlatıcam_polymorphism.models
{
    public class silah
    {
        public virtual void silahlar()
        {
            System.Windows.Forms.MessageBox.Show("10 hasar verme özelliğine sahip");
        }
    }
}
