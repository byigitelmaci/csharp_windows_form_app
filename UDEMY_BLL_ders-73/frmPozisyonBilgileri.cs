using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL_;

namespace UDEMY_BLL_ders_73
{
    public partial class frmPozisyonBilgileri : Form
    {
        public frmPozisyonBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<Departman> departmanlar = new List<Departman>();
        private void frmPozisyonBilgileri_Load(object sender, EventArgs e)
        {
            departmanlar = DAL_.DAO.DepartmanDAO.DepartmanGetir();
            cmbDepartman.DataSource = departmanlar;
            cmbDepartman.DisplayMember = "DepartmanAd";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.SelectedIndex = -1;        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtPozisyonAd.Text.Trim() == "")
                MessageBox.Show("Pozisyon adı giriniz");
            else if (cmbDepartman.SelectedIndex == -1)
                MessageBox.Show("Departman seçiniz");
            else
            {
                POZİSYON pz = new POZİSYON();
                pz.PozisyonAd = txtPozisyonAd.Text;
                pz.DepartmanID=Convert.ToInt32(cmbDepartman.SelectedValue);
                PozisyonBLL.PozisyonEkle(pz);
                MessageBox.Show("pozisyon eklendi");
                txtPozisyonAd.Clear();
                cmbDepartman.SelectedIndex = -1;

            }
        }
    }
}
