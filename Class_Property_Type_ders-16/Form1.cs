using Class_Property_Type_ders_16.models;
using Class_Property_Type_ders_16.personel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Property_Type_ders_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teacheer teacher = new teacheer();
            teacher.name = "yiğit";
            teacher.surname = "elmacı";
            branch branch = new branch();
            branch.areaname = "edebiyat";
            branch.hours = 8;
            branch.price = 20000;
            teacher.branch = branch;

            string areaname = teacher.branch.areaname;
            MessageBox.Show(teacher.branch.areaname);

        }
    }
}
