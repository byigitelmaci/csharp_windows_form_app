using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace STOK_TAKIP_SQL_DENEMESI.DAL.DAO
{
    internal class SatisDAO : StokContext, IDAO<SATIM, SatisDetayDTO>
    {
        public bool Delete(SATIM entity)
        {
            if (entity.ID!=0)
            {
                SATIM satis = db.SATIM.First(x => x.ID == entity.ID);
                satis.isDeleted = true;
                satis.DeletedDate = DateTime.Today;
                db.SaveChanges();
                
            }
            else if (entity.UrunID!=0)
            {
                List<SATIM> list = db.SATIM.Where(x=>x.UrunID==entity.UrunID).ToList();
                foreach (var item in list)
                {
                    item.isDeleted = true;
                    item.DeletedDate = DateTime.Today;
                }
                db.SaveChanges();
            }
            return true;
        }

        public bool GetBack(int ID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(SATIM entity)
        {
            try
            {
                db.SATIM.Add(entity);
                db.SaveChanges();
                return true; 
            }
            catch (Exception )
            {

                throw;
            }
        }

        public List<SatisDetayDTO> select()
        {
            try
            {
                List<SatisDetayDTO> liste = new List<SatisDetayDTO>();
                var list = (from s in db.SATIM.Where(x=>x.isDeleted== false)
                            join u in db.URUN on s.UrunID equals u.ID
                            join k in db.KATEGORI on s.KategoriID equals k.ID
                            join m in db.MUSTERI on s.MusteriID equals m.ID
                            select new
                            {
                                musteriad = m.MusterAd,
                                urunad = u.UrunAd,
                                kategoriad = k.KategoriAd,
                                fiyat = s.SatisFiyat,
                                satistarihi = s.SatisTarihi,
                                satismiktar = s.SatisMiktar,
                                stok = u.Stok,
                                satisID = s.ID,
                                urunID = s.UrunID,
                                musteriID = s.MusteriID,
                                kategoriID = s.KategoriID,

                            }).OrderBy(x => x.satistarihi);
                foreach ( var item in list)
                {
                    SatisDetayDTO dTO = new SatisDetayDTO();
                    dTO.MusteriAd = item.musteriad;
                    dTO.UrunAd = item.urunad;
                    dTO.KategoriAd = item.kategoriad;
                    dTO.Fiyat = item.fiyat;
                    dTO.SatisTarihi = item.satistarihi;
                    dTO.SatisMiktar = item.satismiktar;
                    dTO.StokMiktar = item.stok;
                    dTO.SatisID = item.satisID;
                    dTO.UrunID = item.urunID;
                    dTO.MusteriID = item.musteriID;
                    dTO.KategoriID = item.kategoriID;
                    liste.Add(dTO);

                }

                return liste;
            }
            catch (Exception)
            {

                throw ;
            }
        }
        public List<SatisDetayDTO> select(bool deleted)
        {
            try
            {
                List<SatisDetayDTO> liste = new List<SatisDetayDTO>();
                var list = (from s in db.SATIM.Where(x => x.isDeleted == deleted)
                            join u in db.URUN on s.UrunID equals u.ID
                            join k in db.KATEGORI on s.KategoriID equals k.ID
                            join m in db.MUSTERI on s.MusteriID equals m.ID
                            select new
                            {
                                musteriad = m.MusterAd,
                                urunad = u.UrunAd,
                                kategoriad = k.KategoriAd,
                                fiyat = s.SatisFiyat,
                                satistarihi = s.SatisTarihi,
                                satismiktar = s.SatisMiktar,
                                stok = u.Stok,
                                satisID = s.ID,
                                urunID = s.UrunID,
                                musteriID = s.MusteriID,
                                kategoriID = s.KategoriID,

                            }).OrderBy(x => x.satistarihi);
                foreach (var item in list)
                {
                    SatisDetayDTO dTO = new SatisDetayDTO();
                    dTO.MusteriAd = item.musteriad;
                    dTO.UrunAd = item.urunad;
                    dTO.KategoriAd = item.kategoriad;
                    dTO.Fiyat = item.fiyat;
                    dTO.SatisTarihi = item.satistarihi;
                    dTO.SatisMiktar = item.satismiktar;
                    dTO.StokMiktar = item.stok;
                    dTO.SatisID = item.satisID;
                    dTO.UrunID = item.urunID;
                    dTO.MusteriID = item.musteriID;
                    dTO.KategoriID = item.kategoriID;
                    liste.Add(dTO);

                }

                return liste;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(SATIM entity)
        {
            SATIM ss = db.SATIM.First(x=> x.ID == entity.ID);
            ss.SatisMiktar = entity.SatisMiktar;
            db.SaveChanges();
            return true;
        }
    }
}
