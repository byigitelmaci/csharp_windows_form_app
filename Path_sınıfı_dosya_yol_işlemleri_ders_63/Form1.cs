using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Path_sınıfı_dosya_yol_işlemleri_ders_63
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text += Path.GetDirectoryName(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
            //textBox1.Text += Path.GetFileName(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
            //textBox1.Text += Path.GetFileNameWithoutExtension(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
            //textBox1.Text += Path.GetExtension(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
            //textBox1.Text += Path.GetPathRoot(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
            //textBox1.Text += Path.GetFullPath(@"c:\Data(D:)\Program Files\forestt2.jpg")+ Environment.NewLine;

            try
            {
                textBox1.Text += Path.GetDirectoryName(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
                textBox1.Text += Path.GetFileName(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
                textBox1.Text += Path.GetFileNameWithoutExtension(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
                textBox1.Text += Path.GetExtension(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
                textBox1.Text += Path.GetPathRoot(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
                textBox1.Text += Path.GetFullPath(@"c:\Data(D:)\Program Files\forestt2.jpg") + Environment.NewLine;
            }
            catch (Exception ex)
            {
                // Hata mesajını textBox1 içine ekleyin
                textBox1.Text += "Hata: " + ex.Message + Environment.NewLine;
            }

            
        }

       
    }
}
