using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOK_TAKIP_SQL_DENEMESI.DAL.DAO
{
    internal class UrunDAO : StokContext, IDAO<URUN, UrunDetayDTO>
    {
        public bool Delete(URUN entity)
        {
            if (entity.ID!=0)
            {
                URUN urun = db.URUN.First(x => x.ID == entity.ID);
                urun.isDeleted = true;
                urun.DeleteDate = DateTime.Today;
                db.SaveChanges();
            }
            else if (entity.KategoriID!=0)
            {
                List<URUN> list = db.URUN.Where(x=>x.KategoriID ==entity.KategoriID).ToList();
                foreach (var item in list)
                {
                    item.isDeleted = true;
                    item.DeleteDate = DateTime.Today;
                    List<SATIM> satis =db.SATIM.Where(x=> x.UrunID == item.ID).ToList();
                    foreach (var item2 in satis)
                    {
                        item2.isDeleted = true;
                        item2.DeletedDate = DateTime.Today;
                    }
                    db.SaveChanges ();
                }

                db.SaveChanges();
            }
            return true;
        }

        public bool GetBack(int ID)
        {
            URUN urun = db.URUN.First(x => x.ID == ID);
            urun.isDeleted = false;
            db.SaveChanges ();
            return true;
        }

        public bool Insert(URUN entity)
        {
            try
            {
                db.URUN.Add(entity);
                db.SaveChanges();
                return true; 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<UrunDetayDTO> select()
        {
            List<UrunDetayDTO> liste = new List<UrunDetayDTO>();
            var list = (from u in db.URUN.Where(x => x.isDeleted == false)
                        join 
                        k in db.KATEGORI on u.KategoriID equals k.ID
                        select new
                        {
                            urunad = u.UrunAd,
                            stok = u.Stok,
                            fiyat = u.Fiyat,
                            urunID = u.ID,
                            kategoriad = k.KategoriAd,
                            kID = k.ID,

                        }).OrderBy(x => x.urunad).ToList();
            foreach (var item in list)
            {
                UrunDetayDTO dto = new UrunDetayDTO();
                dto.Fiyat = item.fiyat;
                dto.ID = item.urunID;
                dto.KategoriAd = item.kategoriad;
                dto.KategoriID = item.kID;
                dto.StokMiktar=item.stok;
                dto.UrunAd = item.urunad;
                liste.Add(dto);
            }
            return liste;
        }
        public List<UrunDetayDTO> select(bool deleted)
        {
            List<UrunDetayDTO> liste = new List<UrunDetayDTO>();
            var list = (from u in db.URUN.Where(x => x.isDeleted == deleted)
                        join
                        k in db.KATEGORI on u.KategoriID equals k.ID
                        select new
                        {
                            urunad = u.UrunAd,
                            stok = u.Stok,
                            fiyat = u.Fiyat,
                            urunID = u.ID,
                            kategoriad = k.KategoriAd,
                            kID = k.ID,
                            kategoriisdeleted=k.isDeleted
                        }).OrderBy(x => x.urunad).ToList();
            foreach (var item in list)
            {
                UrunDetayDTO dto = new UrunDetayDTO();
                dto.Fiyat = item.fiyat;
                dto.ID = item.urunID;
                dto.KategoriAd = item.kategoriad;
                dto.KategoriID = item.kID;
                dto.StokMiktar = item.stok;
                dto.UrunAd = item.urunad;
                dto.isKategoriDeleted = item.kategoriisdeleted;
                liste.Add(dto);
            }
            return liste;
        }
        public bool Update(URUN entity)
        {
            try
            {
                URUN urun = db.URUN.First(x => x.ID == entity.ID);
                if (entity.Fiyat==0) 
                { 
                    urun.Stok = entity.Stok;
                }
                else
                {
                    urun.KategoriID=entity.KategoriID;
                    urun.UrunAd=entity.UrunAd;
                    urun.Fiyat =entity.Fiyat;
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal void stokguncelle(SatisDetayDTO entity)
        {
            URUN urun = db.URUN.First(x => x.ID == entity.UrunID);
            int temp = urun.Stok + entity.SatisMiktar;
            urun.Stok = temp;
            db.SaveChanges();
        }
    }
}
