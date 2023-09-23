using DAL1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1.DAO;
using DAL1.DTO;

namespace BLL1
{
    public class IzinBLL
    {
        

        public static void IzinEkle(IZIN iz)
        {
            IzinDAO.IzinEkle(iz);
        }

        public static IzinDTO GetAll()
        {
            IzinDTO dto = new IzinDTO();
            dto.Departmanlar = DepartmanDAO1.DepartmanGetir();
            dto.Pozisyonlar=PozisyonDAO.PozisyonGetir();
            dto.Izindurumlar=IzinDAO.DUrumGetir();
            dto.Izinler = IzinDAO.IZinGetir();
            return dto;
        }

        public static void IzinGuncelle(IzinDetayDTO detayDTO)
        {
            IzinDAO.IzinGunceller(detayDTO);
        }

        public static void IzinGuncelle(int ızinID, int onaylandı)
        {
            IzinDAO.IzinGunceller(ızinID, onaylandı);
        }

        public static void IzinSil(int izinID)
        {
            IzinDAO.IzinSil(izinID);
        }
    }
}
