using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STOK_TAKIP_SQL_DENEMESI.DAL.DAO;


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
            throw new NotImplementedException();
        }

        public bool GetBack(int TableID, SatisDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public bool insert(SatisDetayDTO entity)
        {
            throw new NotImplementedException();
        }

        public SatisDTO Select()
        {
            SatisDTO dto = new SatisDTO();
            dto.Kategoriler = kategoridao.select();
            dto.Musteriler = musteridao.select();
            dto.Urunler = urunDAO.select();
            return dto;
        }

        public bool update(SatisDetayDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
