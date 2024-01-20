using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STOK_TAKIP_SQL_DENEMESI.DAL.DTO;
using STOK_TAKIP_SQL_DENEMESI.BLL;

namespace STOK_TAKIP_SQL_DENEMESI
{
    public partial class FrmMusteriListesi : Form
    {
        public FrmMusteriListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmMusteri frm = new FrmMusteri();
            frm.isupdate = false;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.Select();
            dataGridView1.DataSource = dto.Musteriler;
        }

        MusteriDTO dto = new MusteriDTO();
        MusteriBLL bll = new MusteriBLL();
        MusteriDetayDTO detay = new MusteriDetayDTO();
        private void FrmMusteriListesi_Load(object sender, EventArgs e)
        {
            dto = bll.Select();
            dataGridView1.DataSource = dto.Musteriler;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detay.ID= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detay.MusteriAd = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if(detay.ID== 0)
                MessageBox.Show("Müşteri Seçiniz");
            else
            {
                FrmMusteri frm = new FrmMusteri();
                frm.isupdate = true;
                frm.detaydto = detay;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new MusteriBLL();
                dto = bll.Select();
                dataGridView1.DataSource= dto.Musteriler;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(detay.ID==0)
                MessageBox.Show("Müşteri Seçin");
            DialogResult result = MessageBox.Show("Silinsin mi", "dikkat" ,MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (bll.Delete(detay))
                {
                    MessageBox.Show("Silindi");
                    bll= new MusteriBLL();
                    dto= bll.Select();
                    dataGridView1.DataSource = dto.Musteriler;
                }
            }
        }
    }
}
