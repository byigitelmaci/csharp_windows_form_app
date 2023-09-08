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
        private void FrmIsBilgileri_Load(object sender, EventArgs e)
        {
            cmbIsDurumu.Visible = false;
            label9.Visible = false;
            dto = IsBLL.GetAll();
        }
    }
}
