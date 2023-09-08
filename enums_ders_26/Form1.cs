using enums_ders_26.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enums_ders_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user user = new user();

            user.username = "yiğit";
            user.password = "password";
            user.rol = rol.member;

            
        }

        //enum

        //cinsiyet => erkek,kadın
        //kalem = tükenmez,kurşun,pilot,uçlu

        //Rol admin,super admin, visitor

    }
}
