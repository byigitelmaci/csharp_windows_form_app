using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Örneği_ders_12.models
{
    public class player
    {
        

        public player(int _Sutgucu) 
        {
            sutgucu = _Sutgucu;  //encapsulation
        }
        int _sutgucu;

        public int sutgucu 
        {
            get
            {
                return _sutgucu;
            } 
            set 
            {
                if (value <= 30 && value >0) 
                {
                    _sutgucu = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("0 ile 30  aralığında  şut gücü girilmelidir. şut gücü 15 olarak ayarlanmıştır");
                    _sutgucu = 15;
                }
                
            }

        
        
        }

    }
}
