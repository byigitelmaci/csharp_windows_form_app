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
            throw new NotImplementedException();
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
                var list = (from s in db.SATIM
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
                    dTO.SatisID = item.satisID;
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

        public bool Update(SATIM entity)
        {
            throw new NotImplementedException();
        }
    }
}
