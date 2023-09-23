using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.DTO
{
    public class IzinDTO
    {
        public List<DEPARTMAN> Departmanlar { get; set; }
        public List<PozisyonDTO> Pozisyonlar { get; set;}
        public List<IZINDURUM> Izindurumlar { get; set; }
        public List<IzinDetayDTO> Izinler { get; set; }

    }
}
