using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL1;
using DAL1;

namespace PersonelTakip
{
    public partial class FrmPozisyonBilgileri : Form
    {
        public FrmPozisyonBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<DEPARTMAN> departmanlar = new List<DEPARTMAN>();
        private void FrmPozisyonBilgileri_Load(object sender, EventArgs e)
        {
            departmanlar = DAL1.DAO.DepartmanDAO1.DepartmanGetir();
            cmbDepartmanAdı.DataSource = departmanlar;
            cmbDepartmanAdı.DisplayMember = "DepartmanAd";
            cmbDepartmanAdı.ValueMember = "ID";
            cmbDepartmanAdı.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtPozisyonAd.Text.Trim()=="")
                MessageBox.Show("Pozisyon Adını Giriniz");
            else if (cmbDepartmanAdı.SelectedIndex == -1)
                MessageBox.Show("Departman Seçiniz");
            else
            {
                POZISYON pz = new POZISYON();
                pz.PozisyonAd = txtPozisyonAd.Text;
                pz.DepartmanID = Convert.ToInt32(cmbDepartmanAdı.SelectedValue);
                PozisyonBLL.PozisyonEkle(pz);
                MessageBox.Show("Pozisyon Eklendi");
                txtPozisyonAd.Clear();
                cmbDepartmanAdı.SelectedIndex = -1;

            }
        }
    }
}
