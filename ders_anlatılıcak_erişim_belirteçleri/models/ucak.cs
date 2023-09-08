using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_anlatılıcak_erişim_belirteçleri.models
{
    public class ucak
    {
        public string Pilot { get; set; }
        internal string marka { get; set; }

        private void Uc()
        {
            System.Windows.Forms.MessageBox.Show("Uçuyoruz");
        }

    }
}
