using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;

namespace STOK_TAKIP_SQL_DENEMESI.DAL.DTO
{
    public class UrunDTO
    {
        public List<UrunDetayDTO> Urunler {get; set; }
        public List<KategoriDetayDTO> Kategoriler { get; set; }
    }
}
