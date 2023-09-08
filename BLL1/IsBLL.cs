using DAL1.DAO;
using DAL1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL1
{
    public class IsBLL
    {
        public static IsDTO GetAll()
        {
            IsDTO dto = new IsDTO();
            dto.Departmanlar = DepartmanDAO1.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
            dto.Personeller = PersonelDAO.personelGetir();
            dto.Durumlar = IsDAO.DurumGetir();
            return dto;
        }
    }
}
