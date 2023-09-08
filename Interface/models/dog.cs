using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.models
{
    public class dog : baseclass, IAnimal
    {
        public void Ses()
        {
            System.Windows.Forms.MessageBox.Show("hav hav");
        }
    }
}
