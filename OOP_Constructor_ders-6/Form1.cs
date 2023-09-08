using OOP_Constructor_ders_6.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Constructor_ders_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndogum_Click(object sender, EventArgs e)
        {
            bebek Bebek = new bebek();
            Bebek.Name=txtbebek.Text;
            MessageBox.Show($"{Bebek.Name} isimli bebek {Bebek.BirthDate} tarihinde dünyaya gelmiştir");
        }
    }
}
