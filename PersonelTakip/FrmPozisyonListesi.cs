using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL1;
using BLL1;
using DAL1.DTO;

namespace PersonelTakip
{
    public partial class FrmPozisyonListesi : Form
    {
        public FrmPozisyonListesi()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmPozisyonBilgileri frm = new FrmPozisyonBilgileri();
            this.Hide();
            frm.isupdate = false;
            frm.ShowDialog();
            this.Visible = true;
            liste = PozisyonBLL.PozisyonGetir();
            dataGridView1.DataSource = liste;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            FrmPozisyonBilgileri frm = new FrmPozisyonBilgileri();
            this.Hide();
            frm.isupdate = true;
            frm.detay = detay;
            frm.ShowDialog();
            this.Visible = true;
            liste = PozisyonBLL.PozisyonGetir();
            dataGridView1.DataSource = liste;
        }
        List<PozisyonDTO> liste = new List<PozisyonDTO>();
        PozisyonDetayDTO detay = new PozisyonDetayDTO();
        private void FrmPozisyonListesi_Load(object sender, EventArgs e)
        {
            liste = PozisyonBLL.PozisyonGetir();
            dataGridView1.DataSource = liste;
            dataGridView1.Columns[0].HeaderText = "Departman Adı";
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Pozisyon Adı";

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.ID= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detay.DepartmanID= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detay.EskiDepartmanID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            detay.PozisyonAD = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
