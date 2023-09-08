using Listbox_Object_ders_20.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox_Object_ders_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add("");
            student student = new student();
            student.isim = textBox1.Text;
            student.soyisim = textBox2.Text;
            student.yas = Convert.ToInt32(textBox3.Text);
            listBox1.Items.Add(student);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            student student2 = listBox1.Items[0] as student;
            MessageBox.Show(student2.yas.ToString());
        }
    }
}
