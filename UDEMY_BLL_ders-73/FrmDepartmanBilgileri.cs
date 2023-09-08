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
    public partial class FrmDepartmanBilgileri : Form
    {
        public FrmDepartmanBilgileri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

           

            if (txtDepartmanAd.Text.Trim()== "")
                MessageBox.Show("Lütfen departman adı giriniz");

            else
            {
                Departman dpt = new Departman();
                dpt.DepartmanAd = txtDepartmanAd.Text;
                DepartmanBLL.DepartmanEkle(dpt);
                MessageBox.Show("Departman eklendi");
                txtDepartmanAd.Clear();

            }

        }

        private void txtDepartmanAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
