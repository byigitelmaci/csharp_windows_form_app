using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Kalıtım_.models
{
    internal class wizard : character
    {
        public int DoMagic()
        {
            return Damage*5;
        }

    }
}
