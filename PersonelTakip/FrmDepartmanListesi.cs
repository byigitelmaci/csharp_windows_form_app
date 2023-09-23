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
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmDepartmanBilgileri frm = new FrmDepartmanBilgileri();
            this.Hide();
            frm.isupdate = false;
            frm.ShowDialog();
            this.Visible = true;
            liste = DepartmanBLL1.DepartmanGetir();
            dataGridView1.DataSource = liste;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            FrmDepartmanBilgileri frm = new FrmDepartmanBilgileri();
            this.Hide();
            frm.isupdate = true;
            frm.detay = detay;
            frm.ShowDialog();
            this.Visible = true;
            liste = DepartmanBLL1.DepartmanGetir();
            dataGridView1.DataSource = liste; 
        }
        List<DEPARTMAN> liste = new List<DEPARTMAN>();
        public DEPARTMAN detay = new DEPARTMAN();
        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            
            liste = DepartmanBLL1.DepartmanGetir();
            dataGridView1.DataSource = liste;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Departman Adı";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detay.DepartmanAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
    }
}
