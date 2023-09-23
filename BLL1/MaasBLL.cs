using DAL1;
using DAL1.DAO;
using DAL1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class MaasBLL
    {
        public static MaasDTO GetAll()
        {
            MaasDTO dto = new MaasDTO();
            dto.Departmanlar = DepartmanDAO1.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
            dto.Personeller = PersonelDAO.personelGetir();
            dto.Aylar = MaasDAO.getAylar();
            dto.Maaslar = MaasDAO.MaasGetir();
            return dto;
        }

        public static void MaasEkle(MAASST maas, bool control)
        {
            MaasDAO.MaasEkle(maas);
            if (control)
            {
                MaasDetayDTO dto = new MaasDetayDTO();
                dto.PersoneID = maas.PersonelID;
                dto.MaasMiktar = maas.Miktar;
                PersonelDAO.PersonelMaasGuncelle(dto);
            }
        }

        public static void MaasGuncelle(MaasDetayDTO maas, bool control)
        {
            MaasDAO.MaasGuncelle(maas);
            if (control)
                PersonelDAO.PersonelMaasGuncelle(maas);
        }

        public static void MaasSil(int maasID)
        {
            MaasDAO.MaasSil(maasID);
        }
    }
}
