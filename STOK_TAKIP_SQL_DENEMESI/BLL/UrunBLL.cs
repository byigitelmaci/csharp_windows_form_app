using System;
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

        public bool Delete(UrunDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int TableID, UrunDetayDTO entity)
        {
            throw new NotImplementedException();
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
            if (entity.isStokEkle)
            {
                urun.ID = entity.ID;
                urun.Stok = entity.StokMiktar;

            }
            return dao.Update(urun);
        }
    }
}
