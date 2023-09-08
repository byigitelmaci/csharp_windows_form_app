using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Kalıtım_.models
{
    public class character
    {
        public string CharacterName { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }

        public void walk()
        {
            System.Windows.Forms.MessageBox.Show("Kıralarda yürüyorum");
        }
    }
}
