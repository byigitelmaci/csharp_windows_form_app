using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri7_radiobutton_menustrip_kullanımı
{
    public partial class menustrip_örneği : Form
    {
        public menustrip_örneği()
        {
            InitializeComponent();
        }

        private void komediToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "qweqwewqewqeqweqwqwewe";
            listBox1.Items.Add("esaretin bedeli");
            listBox2.Items.Add(toolStripComboBox1.Text);


        }

        private void felektenBirGeceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "ahjdfbnvanefhjbvnakefnvjjwvıJVJBEAFVJAEJBFVEJRVJQEJVNJQENV";
            listBox1.Items.Add("felekten bir gece");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void amelieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "amelieamelieamelieamelieamelieamelieamelie";
            listBox1.Items.Add("amelie");
            listBox2.Items.Add (toolStripComboBox1.Text);
        }

        private void theNotebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "thenotebookthenotebookthenotebookthenotebookthenotebook";
            listBox1.Items.Add("the notebook");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }
    }
}
