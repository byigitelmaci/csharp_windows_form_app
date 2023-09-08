using ders_anlatılıcak_erişim_belirteçleri.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_anlatılıcak_erişim_belirteçleri //namespace altına protected,protected internal ve private alamaz
{
    public partial class Form1 : Form // yani buraya protected,protected internal ve private yazamayız.(eğer ki hiçbirşey yazmazsak en düşük olan internal erişim belirtecini alır)
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucak ucak = new ucak();

            ucak.Pilot = "";
            ucak.marka = "";
            //burdan sadece pilot ve markayı çağırabildik çünkü public ve internal a burdan erişebiliyoruz
        }

        /*
        
        Access Modifiers / Erişim Belirteçleri=
        public,internal,protected,protected internal,private

        public =>proje içinde veya dışında heryerden ulaşılabilir.
        internal =>sadece proje içerisinden heryerden ulaşılabilir.
        private=>sadece bulunduğu sayfada/classda ulaşılabilir.p

        protected=>kalıtım verdiğimiz sınıflarda proje içinde veya dışında kullanabilmemizi sağlar
        protected internal=>hem protected özelliğini hemde bulunduğumuz proje içinde heryerde kullanabilmemizi
        sağlar

        hiçbir bilgi girilmez ise alabileceği en düşük erişim belirtecini alır.
         
         
         
         */
    }
}
