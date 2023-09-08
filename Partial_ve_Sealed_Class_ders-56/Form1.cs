using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partial_ve_Sealed_Class_ders_56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public partial class employee
        {
            public int employeeıd { get; set; }
            public string name { get; set; }
            public int salary { get; set; }

        }

        partial class employee
        {
            public void setvalues()
            {
                name = "yiğit";
                employeeıd = 1;
                salary = 10000;
                 
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.setvalues();
            textBox1.Text = emp.employeeıd.ToString() + Environment.NewLine + emp.name + Environment.NewLine + emp.salary.ToString();      
        }
    }
}
