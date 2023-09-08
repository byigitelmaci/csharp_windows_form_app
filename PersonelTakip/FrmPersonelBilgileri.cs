using BLL1;
using DAL1;
using DAL1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonelTakip
{
    public partial class FrmPersonelBilgileri : Form
    {
        public FrmPersonelBilgileri()
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

        private void txtmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        PersonelDTO dto = new PersonelDTO();
        private void FrmPersonelBilgileri_Load(object sender, EventArgs e)
        {
            dto = PersonelBLL.GetAll();
            cmbdepartman.DataSource = dto.Departmanlar;
            cmbdepartman.DisplayMember = "DepartmanAd";
            cmbdepartman.ValueMember = "ID";
            cmbdepartman.SelectedIndex = -1;
            cmbpozisyon.DataSource = dto.Pozisyonlar;
            cmbpozisyon.DisplayMember = "PozisyonAd";
            cmbpozisyon.ValueMember = "ID";
            cmbpozisyon.SelectedIndex = -1; 
            if (dto.Departmanlar.Count > 0)
                combofull = true;

        }
        bool combofull = false;
        string resimad = "";

        private void cmbdepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmanID = Convert.ToInt32(cmbdepartman.SelectedValue);
                cmbpozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtresim.Text = openFileDialog1.FileName;
                resimad=Guid.NewGuid().ToString();
                resimad += openFileDialog1.SafeFileName;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtUserNo.Text.Trim()=="")
                MessageBox.Show("User No");
            else if (PersonelBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
            {
                MessageBox.Show("Lütfen userno değiştirin bunu kullanan başka bir personel mevcut");
            }
            else if (txtadı.Text.Trim() == "")
                MessageBox.Show("Ad");
            else if (txtsoyad.Text.Trim() == "")
                MessageBox.Show("Soyad");
            else if (txtmaas.Text.Trim() == "")
                MessageBox.Show("Maaş");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Şifre");
            else if (txtresim.Text.Trim() == "")
                MessageBox.Show("Resim");
            else if (cmbdepartman.Text.Trim() == "")
                MessageBox.Show("Departman");
            else if (cmbpozisyon.Text.Trim() == "")
                MessageBox.Show("Pozisyon");
            else
            {
                PERSONEL pr = new PERSONEL();
                pr.UserNo=Convert.ToInt32(txtUserNo.Text);
                pr.Password=txtPassword.Text;
                pr.Adres=txtadres.Text;
                pr.Ad=txtadı.Text;
                pr.Soyad=txtsoyad.Text;
                pr.Maas = Convert.ToInt32(txtmaas.Text);
                pr.isAdmin=chisadmin.Checked;
                pr.PozisyonID = Convert.ToInt32(cmbpozisyon.SelectedValue);
                pr.DepartmanID=Convert.ToInt32(cmbdepartman.SelectedValue);
                pr.DogumGunu = dateTimePicker1.Value;
                pr.Resim = resimad;
                PersonelBLL.PersonelEkle(pr);
                File.Copy(txtresim.Text, @"resimler\\" + resimad);
                MessageBox.Show("Personel Eklendi");
                txtUserNo.Clear();
                txtPassword.Clear();
                txtsoyad.Clear();
                txtmaas.Clear();
                txtadres.Clear();
                txtadı.Clear();
                txtresim.Clear();
                chisadmin.Checked = false;
                cmbdepartman.SelectedIndex = -1;
                cmbpozisyon.DataSource = dto.Pozisyonlar;
                cmbpozisyon.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Today;
                resimad = "";





            }
        }

        private void btncontrol_Click(object sender, EventArgs e)
        {

            if(txtUserNo.Text.Trim()=="")
                MessageBox.Show("User no boş");
            else if (PersonelBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
            {
                MessageBox.Show("Lütfen userno değiştirin bunu kullanan başka bir personel mevcut");
            }
            else
            {
                MessageBox.Show("Bu userno kullanılabilir");
            }
        }
    }
}
