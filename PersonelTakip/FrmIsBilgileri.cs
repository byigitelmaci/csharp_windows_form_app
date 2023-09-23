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
using DAL1;

namespace PersonelTakip
{
    public partial class FrmIsBilgileri : Form
    {
        public FrmIsBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        IsDTO dto = new IsDTO();
        bool combofull=false;

        public bool isUpdate = false;
        public IsDetayDTO detay = new IsDetayDTO();
        private void FrmIsBilgileri_Load(object sender, EventArgs e)
        {
            cmbIsDurumu.Visible = false;
            label9.Visible = false;
            dto = IsBLL.GetAll();
            dataGridView1.DataSource = dto.Personeller;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
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

            if (isUpdate)
            {
                cmbIsDurumu.Visible = false;
                label9.Visible = false;
                txtadı.Text = detay.Ad;
                txtsoyad.Text = detay.Soyad;
                txtUserNo.Text = detay.UserNO.ToString();
                txticerik.Text = detay.icerik;
                txtbaslik.Text = detay.baslik;
                cmbIsDurumu.DataSource = dto.Durumlar;
                cmbIsDurumu.DisplayMember = "IsDurumAd";
                cmbIsDurumu.ValueMember = "ID";
                cmbIsDurumu.SelectedValue = detay.IsDurumID;

            }
        }

        private void cmbdepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmanID = Convert.ToInt32(cmbdepartman.SelectedValue);
                cmbpozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            iss = new I();
            iss.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            txtUserNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtadı.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        I iss = new I();
        private void btnKaydet_Click(object sender, EventArgs e)
        {


            if(iss.PersonelID==0)
                MessageBox.Show("Personel Seçin");
            else if(txtbaslik.Text.Trim()=="")
                MessageBox.Show("Başlık boş");
            else if(txticerik.Text.Trim()=="")
                MessageBox.Show("İçerik boş");
            else
            {
                if (isUpdate)
                {
                    DialogResult result = MessageBox.Show("Eminmisin?","Dikkat",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        IsDetayDTO dtoo = new IsDetayDTO();
                        if (Convert.ToInt32(txtUserNo.Text)!=detay.UserNO)
                            dtoo.PersoneID=iss.PersonelID;
                        else
                            dtoo.PersoneID =detay.PersoneID;
                        dtoo.baslik=txtbaslik.Text;
                        dtoo.icerik=txticerik.Text;
                        dtoo.IsDurumID=Convert.ToInt32(cmbIsDurumu.SelectedValue);
                        dtoo.IsID=detay.IsID;
                        IsBLL.IsGuncelle(dtoo);
                        MessageBox.Show("Güncellendi");
                        this.Close(); 


                    }
                }
                else
                {
                    iss.Baslik = txtbaslik.Text;
                    iss.Icerik = txticerik.Text;
                    iss.IsDurumID = 1;
                    iss.IsBaslamaTarih = DateTime.Today;
                    IsBLL.IsEkle(iss);
                    MessageBox.Show("İş eklendi");
                    txtbaslik.Clear();
                    txticerik.Clear();
                }
                

            }
        }
    }
}
