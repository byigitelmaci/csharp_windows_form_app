﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using STOK_TAKIP_SQL_DENEMESI.DAL.DAO;
using STOK_TAKIP_SQL_DENEMESI.BLL;
using STOK_TAKIP_SQL_DENEMESI.DAL;

namespace STOK_TAKIP_SQL_DENEMESI.BLL
{
    public class UrunBLL : IBLL<UrunDetayDTO, UrunDTO>
    {
        KategoriDAO kategoriDAO= new KategoriDAO();
        UrunDAO dao = new UrunDAO();
        SatisDAO satisdao = new SatisDAO();
        public bool Delete(UrunDetayDTO entity)
        {
            URUN urun = new URUN();
            urun.ID = entity.ID;
            dao.Delete(urun);
            SATIM satis = new SATIM();
            satis.UrunID = entity.ID;  
            satisdao.Delete(satis);
            return true;
        }

        public bool GetBack( UrunDetayDTO entity)
        {
                return dao.GetBack(entity.ID);
        }

        public bool insert(UrunDetayDTO entity)
        {
            URUN urun = new URUN();
            urun.Fiyat = entity.Fiyat;
            urun.UrunAd = entity.UrunAd;
            urun.KategoriID = entity.KategoriID;
            urun.isDeleted = false;
            return dao.Insert(urun);
        }

        public UrunDTO Select()
        {
            UrunDTO dto = new UrunDTO();
            dto.Kategoriler = kategoriDAO.select();
            dto.Urunler = dao.select();
            return dto;  
        }

        public bool update(UrunDetayDTO entity)
        {
            URUN urun =new URUN();
            if (entity.isKategoriDeleted)
            {
                urun.ID = entity.ID;
                urun.Stok = entity.StokMiktar;

            }
            else
            {
                urun.ID = entity.ID;
                urun.Fiyat = entity.Fiyat;
                urun.KategoriID= entity.KategoriID;
                urun.UrunAd= entity.UrunAd; 
            }
            return dao.Update(urun);
        }
    }
}
