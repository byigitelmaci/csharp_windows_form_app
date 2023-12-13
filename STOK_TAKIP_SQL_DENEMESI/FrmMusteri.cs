using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using STOK_TAKIP_SQL_DENEMESI.BLL;

namespace STOK_TAKIP_SQL_DENEMESI
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        public MusteriDetayDTO detaydto = new MusteriDetayDTO();
        public bool isupdate = false;
        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            if (isupdate)
                txtMüşteriAdı.Text = detaydto.MusteriAd;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MusteriDetayDTO detay = new MusteriDetayDTO();
        MusteriBLL bll = new MusteriBLL();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMüşteriAdı.Text.Trim()=="")
                MessageBox.Show("Müşteri Adı Boş");
            else
            {

                if (isupdate)
                {
                    if(detay.MusteriAd == txtMüşteriAdı.Text)
                        MessageBox.Show("Değişiklik Yok");
                    else
                    {
                        detaydto.MusteriAd = txtMüşteriAdı.Text;
                        if (bll.update(detaydto))
                        {
                            MessageBox.Show("Güncellendi");
                            this.Close();
                        }

                    }
                }
                else
                {
                    detay.MusteriAd = txtMüşteriAdı.Text;
                    if (bll.insert(detay))
                    {
                        MessageBox.Show("Müşteri Eklendi");
                        txtMüşteriAdı.Clear();
                    }
                }
            }
        }
    }
}
