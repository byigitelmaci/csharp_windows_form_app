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
    public partial class FrmDepartmanBilgileri : Form
    {
        public FrmDepartmanBilgileri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtDepartmanAd.Text.Trim()=="")
                MessageBox.Show("Lütfen Departman Adı Giriniz");
            else
            {
                DEPARTMAN dpt = new DEPARTMAN();

                if (isupdate)
                {
                    DialogResult result = MessageBox.Show("Eminmisiniz?","Dikkat",MessageBoxButtons.YesNo);
                    if (result==DialogResult.Yes)
                    {
                        dpt.DepartmanAd = txtDepartmanAd.Text;
                        dpt.ID = detay.ID;
                        DepartmanBLL1.DepartmanGuncelle(dpt);
                        MessageBox.Show("Güncellendi");
                        this.Close();
                    }
                }
                else 
                {
                    dpt.DepartmanAd = txtDepartmanAd.Text;
                    DepartmanBLL1.DepartmanEkle(dpt);
                    MessageBox.Show("Departman Eklendi");
                    txtDepartmanAd.Clear();
                }

                
            }
            
        }
        public bool isupdate = false;
        public DEPARTMAN detay = new DEPARTMAN();
        private void FrmDepartmanBilgileri_Load(object sender, EventArgs e)
        {
            if (isupdate)
                txtDepartmanAd.Text = detay.DepartmanAd;
        }
    }
}
