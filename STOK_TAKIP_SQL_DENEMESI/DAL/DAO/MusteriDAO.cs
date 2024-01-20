using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;

namespace STOK_TAKIP_SQL_DENEMESI.DAL.DAO
{
    internal class MusteriDAO : StokContext, IDAO<MUSTERI, MusteriDetayDTO>
    {
        public bool Delete(MUSTERI entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int ID)
        {
            MUSTERI mm = db.MUSTERI.First(x => x.ID == ID); 
            mm.isDeleted = false;
            db.SaveChanges();
            return true;
        }

        public bool Insert(MUSTERI entity)
        {
            try
            {
                db.MUSTERI.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<MusteriDetayDTO> select()
        {
            try
            {
                List<MusteriDetayDTO> liste = new List<MusteriDetayDTO>();
                var list=db.MUSTERI.Where(x=>x.isDeleted==false);
                foreach (var item in list)
                {
                    MusteriDetayDTO dto = new MusteriDetayDTO();
                    dto.ID = item.ID;
                    dto.MusteriAd = item.MusterAd;
                    liste.Add(dto); 
                }
                return liste;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<MusteriDetayDTO> select(bool deleted)
        {
            try
            {
                List<MusteriDetayDTO> liste = new List<MusteriDetayDTO>();
                var list = db.MUSTERI.Where(x => x.isDeleted == deleted);
                foreach (var item in list)
                {
                    MusteriDetayDTO dto = new MusteriDetayDTO();
                    dto.ID = item.ID;
                    dto.MusteriAd = item.MusterAd;
                    liste.Add(dto);
                }
                return liste;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool Update(MUSTERI entity)
        {
            MUSTERI mm = db.MUSTERI.First(x=> x.ID == entity.ID);
            mm.MusterAd = entity.MusterAd;
            db.SaveChanges();
            return true;
        }
    }
}
