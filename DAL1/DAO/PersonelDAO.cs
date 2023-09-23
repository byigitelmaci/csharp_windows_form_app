using DAL1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.DAO
{
    public class PersonelDAO : PersonelDataContext
    {
        public static void PersonelEkle(PERSONEL pr)
        {
			try
			{
				db.PERSONELs.InsertOnSubmit(pr);
				db.SubmitChanges();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

        public static List<PERSONEL> personelGetir(int v)
        {
            return db.PERSONELs.Where(x=> x.UserNo == v).ToList();
        }

        public static List<PersonelDetayDTO> personelGetir()
        {
            List<PersonelDetayDTO> liste = new List<PersonelDetayDTO>();
            var list = (from p in db.PERSONELs
                        join d in db.DEPARTMANs on p.DepartmanID equals d.ID
                        join pz in db.POZISYONs on p.PozisyonID equals pz.ID
                        select new
                        {
                            personelID = p.ID,
                            ad = p.Ad,
                            soyad = p.Soyad,
                            password = p.Password,
                            departman = d.DepartmanAd,
                            pozisyon = pz.PozisyonAd,
                            departmanID = d.ID,
                            pozisyonID = p.PozisyonID,
                            isadmin = p.isAdmin,
                            maas = p.Maas,
                            resim = p.Resim,
                            dogumtarihi = p.DogumGunu,
                            adres = p.Adres,
                            UserNo =  p.UserNo


                        }).OrderBy(x=>x.personelID).ToList();
            foreach (var item in list)
            {
                PersonelDetayDTO dto = new PersonelDetayDTO();
                dto.PersoneID=item.personelID;
                dto.Ad = item.ad;
                dto.Soyad = item.soyad;
                dto.password = item.password;
                dto.DepartmanAd = item.departman;
                dto.PozisyonAd = item.pozisyon;
                dto.DepartmanID=item.departmanID;
                dto.PozisyonID=item.pozisyonID;
                dto.isadmin = item.isadmin;
                dto.Maas = item.maas;
                dto.Resim = item.resim;
                dto.DogumTarihi = item.dogumtarihi;
                dto.Adres = item.adres; 
                dto.UserNO = item.UserNo;
                liste.Add(dto);
            }
            return liste;
        }

        public static List<PERSONEL> personelGetir(int v, string text)
        {
            return db.PERSONELs.Where(x=> x.UserNo == v && x.Password == text).ToList();
        }

        public static void PersonelGuncelle(PozisyonDetayDTO detay)
        {
            List<PERSONEL> list = db.PERSONELs.Where(x=> x.PozisyonID == detay.ID).ToList();
            foreach (var item in list)
            {
                item.DepartmanID = detay.DepartmanID;
            }
            db.SubmitChanges();
        }

        public static void PersonelGuncelle(PersonelDetayDTO pr)
        {
            try
            {
                PERSONEL per = db.PERSONELs.First(x => x.ID == pr.PersoneID);
                per.UserNo = pr.UserNO;
                per.Ad=pr.Ad;
                per.Adres=pr.Adres;
                per.DepartmanID= pr.DepartmanID;
                per.DogumGunu = pr.DogumTarihi;
                per.isAdmin = pr.isadmin;
                per.Maas = pr.Maas;
                per.Password = pr.password;
                per.PozisyonID = pr.PozisyonID;
                per.Resim = pr.Resim;
                per.Soyad = pr.Soyad;
                db.SubmitChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public static void PersonelMaasGuncelle(MaasDetayDTO maas)
        {
            try
            {
                PERSONEL pr = db.PERSONELs.First(x => x.ID == maas.PersoneID);
                pr.Maas = maas.MaasMiktar;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
             
        }

        public static void PersonelSil(int personeID)
        {
            try
            {
                List<IZIN> iz = db.IZINs.Where(x=> x.PersonelID==personeID).ToList();
                db.IZINs.DeleteAllOnSubmit(iz);
                db.SubmitChanges();
                List<I> iss = db.Is.Where(x=>x.PersonelID == personeID).ToList();
                db.Is.DeleteAllOnSubmit(iss);
                db.SubmitChanges();
                List<MAASST> maas = db.MAASSTs.Where(x=> x.PersonelID== personeID).ToList();
                db.MAASSTs.DeleteAllOnSubmit(maas);
                db.SubmitChanges();
                PERSONEL pr = db.PERSONELs.First(x => x.ID == personeID);
                db.PERSONELs.DeleteOnSubmit(pr);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public class PersonelGetir : List<PERSONEL>
        {
        }
    }
}
