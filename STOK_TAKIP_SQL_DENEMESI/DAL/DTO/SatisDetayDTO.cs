﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOK_TAKIP_SQL_DENEMESI.DAL.DTO
{
    public class SatisDetayDTO
    {
        public int UrunAd { get; set; }
        public string MusteriAd { get; set; }
        public int KategoriAd { get; set; }
        public int Fiyat { get; set; }
        public int SatisTarihi { get; set; }
        public int SatisMiktar { get; set; }
        public int StokMiktar { get; set; }
        public int SatisID { get; set; }
        public int UrunID { get; set; }
        public int MusteriID { get; set; }
        public int KategoriID { get; set; }

    }
}