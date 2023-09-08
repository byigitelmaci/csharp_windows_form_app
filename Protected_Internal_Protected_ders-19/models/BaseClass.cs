using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_Internal_Protected_ders_19.models
{
    public abstract class BaseClass //miras vericek olan sınıf.
    {
        protected int protectedProperty { get; set; }
        internal protected int InternalProtected { get; set; }
    }
}
