using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_anlatıcam_polymorphism.models
{
    public class win94:silah
    {
        public override void silahlar()
        {
            System.Windows.Forms.MessageBox.Show("42 hasar verme özelliğine sahiptir");
        }
    }
}
