using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_anlatıcam_polymorphism.models
{
    public class M249:silah
    {
        public override void silahlar()
        {
            MessageBox.Show("15 hasar verme özelliğine sahip");
            
        }
    }
}
