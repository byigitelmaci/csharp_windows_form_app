﻿using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOK_TAKIP_SQL_DENEMESI.DAL.DAO
{
    internal class KategoriDAO :StokContext, IDAO<KATEGORI, KategoriDetayDTO>
    {
        public bool Delete(KATEGORI entity)
        {
            KATEGORI kk = db.KATEGORI.First(x=>x.ID== entity.ID);
            kk.isDeleted = true;
            kk.DeleteDate = DateTime.Now;
            db.SaveChanges();
            return true;
        }

        public bool GetBack(int ID)
        {
            KATEGORI kk = db.KATEGORI.First(x => x.ID == ID);
            kk.isDeleted = false;
            db.SaveChanges();
            return true;
        }

        public bool Insert(KATEGORI entity)
        {
            try
            {
                db.KATEGORI.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<KategoriDetayDTO> select()
        {
            try
            {
                var list = db.KATEGORI.Where(x=>x.isDeleted==false);
                List<KategoriDetayDTO> liste = new List<KategoriDetayDTO>();
                foreach (var item in list)
                {
                    KategoriDetayDTO dto = new KategoriDetayDTO();
                    dto.ID = item.ID;
                    dto.KategoriAd = item.KategoriAd;
                    liste.Add(dto);
                }
                return liste;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<KategoriDetayDTO> select(bool deleted)
        {
            try
            {
                var list = db.KATEGORI.Where(x => x.isDeleted == deleted);
                List<KategoriDetayDTO> liste = new List<KategoriDetayDTO>();
                foreach (var item in list)
                {
                    KategoriDetayDTO dto = new KategoriDetayDTO();
                    dto.ID = item.ID;
                    dto.KategoriAd = item.KategoriAd;
                    liste.Add(dto);
                }
                return liste;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Update(KATEGORI entity)
        {
            KATEGORI kt = db.KATEGORI.First(x=>x.ID == entity.ID);  
            kt.KategoriAd=entity.KategoriAd;
            db.SaveChanges();
            return true;
        }
    }
}
