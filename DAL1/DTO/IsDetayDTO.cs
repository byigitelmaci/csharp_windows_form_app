using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DAL1.DTO
{
    public class IsDetayDTO
    {
        
        public string baslik { get; set; }
        public int UserNO { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DepartmanAd { get; set; }
        public string PozisyonAd { get; set; }
        public int DepartmanID { get; set; }
        public int PozisyonID { get; set; }
        public int PersoneID { get; set; }
        public string icerik { get; set; }
        public string IsDurumAd { get; set; }
        public int IsDurumID { get; set; }
        public DateTime IsBaslamaTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int IsID { get; set; }




    }
}
