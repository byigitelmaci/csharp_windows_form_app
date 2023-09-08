using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_anlatıcam_polymorphism.models
{
    public class groza:silah
    {
        public override void silahlar()
        {
            System.Windows.Forms.MessageBox.Show("35 hasar verme özelliğine sahiptir");
        }
    }
}
