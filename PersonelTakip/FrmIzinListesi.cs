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


namespace PersonelTakip
{
    public partial class FrmIzinListesi : Form
    {
        public FrmIzinListesi()
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

        private void txtsure_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnekle_Click(object sender, EventArgs e)
        {
            FrmIzinBilgileri frm = new FrmIzinBilgileri();
            this.Hide();
            frm.isUpdate = false;
            frm.ShowDialog();
            this.Visible = true;
            combofull = false;
            doldur();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if(detay.IzinID== 0)
                MessageBox.Show("lütfen izin seçin");
            else
            {
                FrmIzinBilgileri frm = new FrmIzinBilgileri();
                this.Hide();
                frm.isUpdate = true;
                frm.detay = detay;
                frm.ShowDialog();
                this.Visible = true;
                combofull = false;
                doldur();
                temizle();
            }

            
            
            
        }
        IzinDTO dto = new IzinDTO();
        private bool combofull;

        void doldur()
        {
            dto = IzinBLL.GetAll();
            dataGridView1.DataSource = dto.Izinler;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Ad";
            dataGridView1.Columns[3].HeaderText = "Soyad";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Başlama Tarihi";
            dataGridView1.Columns[9].HeaderText = "Bitiş Tarihi";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].HeaderText = "İzin Durumu";
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
            cmbizindurum.DataSource = dto.Izindurumlar;
            cmbizindurum.DisplayMember = "IzinDurumAd";
            cmbizindurum.ValueMember = "ID";
            cmbizindurum.SelectedIndex = -1;
        }
        private void FrmIzinListesi_Load(object sender, EventArgs e)
        {

            doldur();
        }

        private void cmbdepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmanID = Convert.ToInt32(cmbdepartman.SelectedValue);
                cmbpozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == departmanID).ToList();
            }
        }
        List<IzinDetayDTO> listt = new List<IzinDetayDTO>();
        private void btnAra_Click(object sender, EventArgs e)
        {
            listt = dto.Izinler;
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
                listt=listt.Where(x => x.BaslamaTarihi>=Convert.ToDateTime(dpbaslama.Value)
                && x.BaslamaTarihi<Convert.ToDateTime(dpbitis.Value)).ToList();
            if (rbbitistarihi.Checked)
                listt = listt.Where(x => x.BitisTarihi >= Convert.ToDateTime(dpbaslama.Value)
                && x.BitisTarihi < Convert.ToDateTime(dpbitis.Value)).ToList();
            if (cmbizindurum.SelectedIndex != -1)
                listt = listt.Where(x => x.IzinDurumID == Convert.ToInt32(cmbizindurum.SelectedValue)).ToList();
            if (txtsure.Text.Trim() != "")
                listt = listt.Where(X => X.Sure==Convert.ToInt32(txtsure.Text)).ToList();

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
            dataGridView1.DataSource = dto.Izinler;
            rbbaslamatarihi.Checked = false;
            rbbitistarihi.Checked = false;
            txtsure.Clear();
            cmbizindurum.SelectedIndex = -1;
            dpbaslama.Value = DateTime.Today;
            dpbitis.Value = DateTime.Today;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
        IzinDetayDTO detay = new IzinDetayDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.IzinID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detay.BaslamaTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detay.BitisTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detay.UserNO = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detay.Sure = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            detay.Aciklama = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            detay.IzinDurumID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (detay.IzinID==0)
                MessageBox.Show("Lütfen İzin Seçin");
            else
            {
                IzinBLL.IzinGuncelle(detay.IzinID, ComboStatic.Onaylandı);
                MessageBox.Show("Onaylandı");
                temizle();
                doldur();
            }
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            if (detay.IzinID == 0)
                MessageBox.Show("Lütfen İzin Seçin");
            else
            {
                IzinBLL.IzinGuncelle(detay.IzinID, ComboStatic.Reddedildi);
                MessageBox.Show("Reddedildi");
                temizle();
                doldur();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silinsinmi?","Dikkat",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (detay.IzinDurumID==ComboStatic.Onaylandı || detay.IzinDurumID== ComboStatic.Reddedildi)
                    MessageBox.Show("Onaylı Yada Reddedilmiş izinleri Silemezsiniz");
                else
                {
                    IzinBLL.IzinSil(detay.IzinID);
                    MessageBox.Show("Silindi");
                    combofull = false;
                    doldur();
                    temizle();
                    
                }
            }
        }
    }
}
