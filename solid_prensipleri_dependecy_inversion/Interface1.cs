using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_prensipleri_dependecy_inversion
{
    interface logtut
    {
        string mesaj { get; set; }
        void sakla();
    }

    class filelog : logtut
    {
        public string mesaj { get ; set; }


        public void sakla()
        {
            throw new NotImplementedException();
        }
    }

    class datalog : logtut
    {
        public string mesaj { get ; set ; }

        public void sakla()
        {
            throw new NotImplementedException();
        }
    }

    class logyonet 
    {
        private logtut logtut;
        
        public logyonet(logtut logt)
        {
            logtut = logt;
        }
        public void logla() 
        {
            logtut.sakla();
        }
    }
}
