using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.DTO
{
    public class PersonelDetayDTO
    {
        public int PersoneID { get; set; }
        public int UserNO { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DepartmanAd { get; set; }
        public string PozisyonAd { get; set; }
        public int DepartmanID { get; set; }
        public int PozisyonID { get; set; }
        public int Maas { get; set; }
        public string password { get; set; }
        public bool isadmin { get; set; }
        public string Resim { get; set; }
        public string Adres { get; set; }
        public DateTime? DogumTarihi { get; set; }

    }
}
