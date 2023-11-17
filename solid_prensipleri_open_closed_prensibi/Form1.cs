using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace solid_prensipleri_open_closed_prensibi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //kod eklemeye açık değişime kapalı olmalıdır

        //aşağıdada var olan kodu değiştirmedik aşağısına kod eklemeye devam ettik

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    dto = MaasBLL.GetAll();
        //    dataGridView1.DataSource = dto.Personeller;
        //    dataGridView1.Columns[0].Visible = false;
        //    dataGridView1.Columns[1].HeaderText = "User No";
        //    dataGridView1.Columns[2].HeaderText = "Ad";
        //    dataGridView1.Columns[3].HeaderText = "Soyad";
        //    dataGridView1.Columns[4].Visible = false;
        //    dataGridView1.Columns[5].Visible = false;
        //    dataGridView1.Columns[6].Visible = false;
        //    dataGridView1.Columns[7].Visible = false;
        //    dataGridView1.Columns[8].Visible = false;
        //    dataGridView1.Columns[9].Visible = false;
        //    dataGridView1.Columns[10].Visible = false;
        //    dataGridView1.Columns[11].Visible = false;
        //    dataGridView1.Columns[12].Visible = false;
        //    dataGridView1.Columns[13].Visible = false;
        //    cmbdepartman.DataSource = dto.Departmanlar;
        //    cmbdepartman.DisplayMember = "DepartmanAd";
        //    cmbdepartman.ValueMember = "ID";
        //    cmbdepartman.SelectedIndex = -1;
        //    if (dto.Departmanlar.Count > 0)
        //        combofull = true;
        //    cmbpozisyon.DataSource = dto.Pozisyonlar;
        //    cmbpozisyon.DisplayMember = "PozisyonAd";
        //    cmbpozisyon.ValueMember = "ID";
        //    cmbpozisyon.SelectedIndex = -1;
        //    cmbAylar.DataSource = dto.Aylar;
        //    cmbAylar.DisplayMember = "Ay";
        //    cmbAylar.ValueMember = "ID";
        //    cmbAylar.SelectedIndex = -1;
        //    txtyıl.Text = DateTime.Today.Year.ToString();
        //    if (isUpdate)
        //    {
        //        txtadı.Text = detay.Ad;
        //        txtsoyad.Text = detay.Soyad;
        //        txtmaas.Text = detay.MaasMiktar.ToString();
        //        txtyıl.Text = detay.MaasYil.ToString();
        //        txtUserNo.Text = detay.UserNO.ToString();
        //        cmbAylar.SelectedValue = detay.MaasAyID;
        //    }
        //}
    }
}
