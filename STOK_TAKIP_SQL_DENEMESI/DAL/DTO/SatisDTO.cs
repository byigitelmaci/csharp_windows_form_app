﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOK_TAKIP_SQL_DENEMESI.DAL.DTO
{
    public class SatisDTO
    {
        public List<SatisDetayDTO> Satislar { get; set; }
        public List<KategoriDetayDTO> Kategoriler { get; set; }
        public List<UrunDetayDTO> Urunler { get; set; }
        public List<MusteriDetayDTO> Musteriler { get; set; }
    }
}
