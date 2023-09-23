using DAL1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.DAO
{
    public class IsDAO : PersonelDataContext
    {
        public static List<ISDURUM> DurumGetir()
        {
            return db.ISDURUMs.ToList();
        }

        public static void IsEkle(I iss)
        {
            try
            {
                db.Is.InsertOnSubmit(iss);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<IsDetayDTO> IsGetir()
        {
            List<IsDetayDTO> liste = new List<IsDetayDTO>();
            var list=(from i in db.Is
                      join p in db.PERSONELs on i.PersonelID equals p.ID
                      join d in db.DEPARTMANs on p.DepartmanID equals d.ID
                      join pz in db.POZISYONs on p.PozisyonID equals pz.ID
                      join durum in db.ISDURUMs on i.IsDurumID equals durum.ID
                      select new
                      {
                          isID=i.ID,
                          baslik=i.Baslik,
                          icerik=i.Icerik,
                          baslamatarihi=i.IsBaslamaTarih,
                          bitistarihi=i.IsBitisTarih,
                          userno=p.UserNo,
                          ad=p.Ad,
                          soyad=p.Soyad,
                          departman=d.DepartmanAd,
                          pozisyon=pz.PozisyonAd,
                          departmanID=p.DepartmanID,
                          pozisyonID=p.PozisyonID,
                          isdurumu=durum.IsDurumAd,
                          isdurumID=i.IsDurumID,
                          personelID=i.PersonelID
                      }
                      ).OrderBy(x=> x.baslamatarihi).ToList();
            foreach (var item in list)
            {
                IsDetayDTO dto = new IsDetayDTO();
                dto.IsID = item.isID;
                dto.baslik = item.baslik;
                dto.icerik = item.icerik;
                dto.IsBaslamaTarihi = item.baslamatarihi;
                dto.IsBitisTarihi = item.bitistarihi;
                dto.UserNO = item.userno;
                dto.Ad = item.ad;
                dto.Soyad = item.soyad;
                dto.DepartmanAd = item.departman;
                dto.PozisyonAd = item.pozisyon;
                dto.DepartmanID = item.departmanID;
                dto.PozisyonID = item.pozisyonID;
                dto.IsDurumAd = item.isdurumu;
                dto.IsDurumID = item.isdurumID;
                dto.PersoneID = item.personelID;
                liste.Add(dto);


            }
            return liste;
        }

        public static void IsGuncell(IsDetayDTO dto)
        {
            try
            {
                I iss = db.Is.First(x => x.ID == dto.IsID);
                iss.Baslik = dto.baslik;
                iss.Icerik = dto.icerik;
                iss.PersonelID = dto.PersoneID;
                iss.IsDurumID = dto.IsDurumID;
                db.SubmitChanges(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void IsSil(int isID)
        {
            try
            {
                I iss = db.Is.First(x=> x.ID == isID);
                db.Is.DeleteOnSubmit(iss);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }    
        }
    }
}
