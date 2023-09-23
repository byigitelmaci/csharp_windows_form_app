using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL1.DTO;
using BLL1;
using Microsoft.SqlServer.Server;

namespace PersonelTakip
{
    public partial class FrmIsListesi : Form
    {
        public FrmIsListesi()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        IsDTO dto = new IsDTO();
        private bool combofull;
        IsDetayDTO detay = new IsDetayDTO();

        private void FrmIsListesi_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(UserStatic.PersonelID.ToString() + " " + UserStatic.UserNo.ToString() + " " + UserStatic.isAdmin.ToString());

            doldur();

        }

        private void doldur()
        {
            dto = IsBLL.GetAll();
            dataGridView1.DataSource = dto.Isler;
            dataGridView1.Columns[0].HeaderText = "Başlık";
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].HeaderText = "Departman";
            dataGridView1.Columns[5].HeaderText = "Pozisyon";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            cmbdepartman.DataSource = dto.Departmanlar;
            cmbdepartman.DisplayMember = "DepartmanAd";
            cmbdepartman.ValueMember = "ID";
            cmbdepartman.SelectedIndex = -1;
            if (dto.Departmanlar.Count > 0)
                combofull = true;
            cmbpozisyon.DataSource = dto.Pozisyonlar;
            cmbpozisyon.DisplayMember = "PozisyonAd";
            cmbpozisyon.ValueMember = "ID";
            cmbpozisyon.SelectedIndex = -1;
            cmbIsDurumu.DataSource = dto.Pozisyonlar;
            cmbIsDurumu.DisplayMember = "Durum Ad";
            cmbIsDurumu.ValueMember = "ID";
            cmbIsDurumu.SelectedIndex = -1;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            FrmIsBilgileri frm = new FrmIsBilgileri();
            this.Hide();
            frm.isUpdate = true;
            frm.detay = detay;
            frm.ShowDialog();
            this.Visible = true;
            combofull = false;
            doldur();
            temizle();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmIsBilgileri frm = new FrmIsBilgileri();
            this.Hide();
            frm.isUpdate = false;
            frm.ShowDialog();
            this.Visible = true;
            combofull = false;
            doldur();
            temizle();
        }

        private void cmbdepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmanID = Convert.ToInt32(cmbdepartman.SelectedValue);
                cmbpozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }
        List<IsDetayDTO> listt = new List<IsDetayDTO>();
        private void btnAra_Click(object sender, EventArgs e)
        {
            listt = dto.Isler;
            if (txtUserNo.Text.Trim() != "")
                listt = listt.Where(X => X.UserNO == Convert.ToInt32(txtUserNo.Text)).ToList();
            if (txtadı.Text.Trim() != "")
                listt = listt.Where(X => X.Ad.Contains(txtadı.Text)).ToList();
            if (txtsoyad.Text.Trim() != "")
                listt = listt.Where(X => X.Soyad.Contains(txtsoyad.Text)).ToList();
            if (cmbdepartman.SelectedIndex != -1)
                listt = listt.Where(x => x.DepartmanID == Convert.ToInt32(cmbdepartman.SelectedValue)).ToList();
            if (cmbpozisyon.SelectedIndex != -1)
                listt = listt.Where(x => x.PozisyonID == Convert.ToInt32(cmbpozisyon.SelectedValue)).ToList();
            if (rbbaslamatarihi.Checked)
                listt = listt.Where(x => x.IsBaslamaTarihi >= Convert.ToDateTime(dpbaslama.Value)
                && x.IsBaslamaTarihi < Convert.ToDateTime(dpbaslama.Value)).ToList();
            if (rbteslimtarihi.Checked)
                listt = listt.Where(x => x.IsBitisTarihi >= Convert.ToDateTime(dpbitis.Value)
                && x.IsBitisTarihi < Convert.ToDateTime(dpbitis.Value)).ToList();
            dataGridView1.DataSource = listt;
        }
        void temizle()
        {
            txtadı.Clear();
            txtsoyad.Clear();
            txtUserNo.Clear();
            cmbdepartman.SelectedIndex = -1;
            cmbpozisyon.DataSource = dto.Pozisyonlar;
            cmbpozisyon.SelectedIndex = -1;
            cmbIsDurumu.SelectedIndex = -1;
            dpbaslama.Value = DateTime.Today;
            dpbitis.Value = DateTime.Today;
            dataGridView1.DataSource = dto.Isler;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.IsID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detay.UserNO = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detay.PersoneID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detay.IsDurumID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            detay.baslik = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            detay.icerik = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            detay.Ad = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detay.Soyad = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detay.IsBaslamaTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detay.IsBitisTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[13].Value);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silinsinmi?", "Dikkat", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                IsBLL.IsSil(detay.IsID);
                MessageBox.Show("Silindi");
                combofull = false;
                doldur();
                temizle();
            }
        }
    }
}
