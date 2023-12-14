using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STOK_TAKIP_SQL_DENEMESI.DAL.DAO;
using STOK_TAKIP_SQL_DENEMESI.BLL;
using STOK_TAKIP_SQL_DENEMESI.DAL;


namespace STOK_TAKIP_SQL_DENEMESI.BLL
{
    internal class SatisBLL : IBLL<SatisDetayDTO, SatisDTO>
    {
        KategoriDAO kategoridao = new KategoriDAO();
        MusteriDAO musteridao = new MusteriDAO();
        UrunDAO urunDAO = new UrunDAO();
        SatisDAO dao  = new SatisDAO(); 
         public bool Delete(SatisDetayDTO entity)
        {
            SATIM satis = new SATIM();
            satis.ID = entity.SatisID;
            dao.Delete(satis);
            urunDAO.stokguncelle(entity);
            return true;
        }

        public bool GetBack(int TableID, SatisDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool insert(SatisDetayDTO entity)
        {
            SATIM satis = new SATIM();
            satis.UrunID = entity.UrunID;
            satis.MusteriID = entity.MusteriID;
            satis.SatisMiktar = entity.SatisMiktar;
            satis.SatisTarihi = entity.SatisTarihi;
            satis.SatisFiyat = entity.Fiyat;
            satis.KategoriID = entity.KategoriID;
            dao.Insert(satis);
            URUN urun = new URUN();
            urun.ID = entity.UrunID;
            int temp = entity.StokMiktar-entity.SatisMiktar;
            urun.Stok = temp;
            urunDAO.Update(urun);

            return true;

        }

        public SatisDTO Select()
        {
            SatisDTO dto = new SatisDTO();
            dto.Kategoriler = kategoridao.select();
            dto.Musteriler = musteridao.select();
            dto.Urunler = urunDAO.select();
            dto.Satislar = dao.select();
            return dto;
        }

        public bool update(SatisDetayDTO entity)
        {
            SATIM satis = new SATIM();
            satis.SatisMiktar = entity.SatisMiktar;
            satis.ID = entity.SatisID;
            dao.Update(satis);
            int temp = entity.StokMiktar;
            URUN urun = new URUN();
            urun.Stok = entity.StokMiktar - (entity.SatisMiktar-temp);
            urun.ID=entity.UrunID;
            urunDAO.Update(urun);

            return true;
        }
    }
}
