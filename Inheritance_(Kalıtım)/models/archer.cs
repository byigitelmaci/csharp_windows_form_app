using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Kalıtım_.models
{
    internal class archer:RangedCharacter
    {
        public archer() 
        {
            walk();
            Damage = 3;
            RangeDamage();
        }
    }
}
