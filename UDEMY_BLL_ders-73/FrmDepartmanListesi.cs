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
            frm.ShowDialog();
            this.Visible = true;
            liste = DepartmanBLL.DepartmanGetir();
            dataGridView1.DataSource = liste;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            FrmDepartmanBilgileri frm = new FrmDepartmanBilgileri();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
        List<Departman> liste = new List<Departman>();
        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            
            liste = DepartmanBLL.DepartmanGetir();
            dataGridView1.DataSource = liste;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "departman adı";

        }
    }
}
