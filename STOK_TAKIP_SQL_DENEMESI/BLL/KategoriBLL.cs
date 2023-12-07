using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using STOK_TAKIP_SQL_DENEMESI.DAL;
using STOK_TAKIP_SQL_DENEMESI.DAL.DAO;

namespace STOK_TAKIP_SQL_DENEMESI.BLL
{
    internal class KategoriBLL : IBLL<KategoriDetayDTO, KategoriDTO>
    {
        KategoriDAO dao=new KategoriDAO();
        public bool Delete(KategoriDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool GetBack(int TableID, KategoriDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool insert(KategoriDetayDTO entity)
        {
            KATEGORI kategori = new KATEGORI();
            kategori.KategoriAd = entity.KategoriAd;
            kategori.isDeleted = false;
            return dao.Insert(kategori);
        }

        public KategoriDTO Select()
        {
            KategoriDTO dto = new KategoriDTO();
            dto.Kategoriler = dao.select();
            return dto;
        }

        public bool update(KategoriDetayDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
