using DAL1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL1.DAO;
using DAL1;

namespace BLL1
{
    public class PersonelBLL
    {
        public static PersonelDTO GetAll()
        {
            PersonelDTO dto = new PersonelDTO();
            dto.Departmanlar = DepartmanDAO1.DepartmanGetir();
            dto.Pozisyonlar=PozisyonDAO.PozisyonGetir();
            dto.Personeller = PersonelDAO.personelGetir();
            return dto; 
        }

        public static bool isUnique(int v)
        {
            List<PERSONEL> list = PersonelDAO.personelGetir(v);
            if(list.Count > 0) 
                return true;
            else 
                return false;
        }

        public static void PersonelEkle(PERSONEL pr)
        {
            PersonelDAO.PersonelEkle(pr);
        }

        public static List<PERSONEL> PersonelGetir(int v, string text)
        {
            return PersonelDAO.personelGetir(v, text);
        }

        public static void PersonelGuncelle(PersonelDetayDTO pr)
        {
            PersonelDAO.PersonelGuncelle(pr);
        }

        public static void PersonelSil(int personeID)
        {
            PersonelDAO.PersonelSil(personeID);
        }
    }
}
