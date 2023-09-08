using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_;
using BLL;
using DAL_.DTO;

namespace UDEMY_BLL_ders_73
{
    public partial class FrmPozisyonListesi : Form
    {
        public FrmPozisyonListesi()
        {
            InitializeComponent();
        }
        

        private void btnekle_Click(object sender, EventArgs e)
        {
            frmPozisyonBilgileri frm = new frmPozisyonBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            liste = PozisyonBLL.PozisyonGetir();
            dataGridView1.DataSource = liste;

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            frmPozisyonBilgileri frm = new frmPozisyonBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<PozisyonDTO> liste = new List<PozisyonDTO>();
        private void FrmPozisyonLİstesi_Load(object sender, EventArgs e)
        {
            liste = PozisyonBLL.PozisyonGetir();
            dataGridView1.DataSource = liste;
            dataGridView1.Columns[0].HeaderText = "Departman Adı";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Pozisyon Adı";



        }
    }
}
