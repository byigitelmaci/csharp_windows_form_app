using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STOK_TAKIP_SQL_DENEMESI.DAL.DAO;
using STOK_TAKIP_SQL_DENEMESI.DAL;

namespace STOK_TAKIP_SQL_DENEMESI.BLL
{
    public class MusteriBLL : IBLL<MusteriDetayDTO, MusteriDTO>
    {
        MusteriDAO dao = new MusteriDAO();
        public bool Delete(MusteriDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int TableID, MusteriDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool insert(MusteriDetayDTO entity)
        {
            MUSTERI musteri = new MUSTERI();
            musteri.MusterAd = entity.MusteriAd;
            musteri.isDeleted = false;
            return dao.Insert(musteri);
        }

        public MusteriDTO Select()
        {
            MusteriDTO dto = new MusteriDTO();
            dto.Musteriler = dao.select();
            return dto;
        }

        public bool update(MusteriDetayDTO entity)
        {
            MUSTERI musteri = new MUSTERI();
            musteri.ID = entity.ID;
            musteri.MusterAd = entity.MusteriAd;
            return dao.Update(musteri);
        }
    }
}
