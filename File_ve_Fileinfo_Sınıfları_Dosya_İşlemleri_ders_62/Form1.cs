using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_ve_Fileinfo_Sınıfları_Dosya_İşlemleri_ders_62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //File.Create("firstfile.txt");
            if (!File.Exists("secondfile.txt"))
            {
                FileInfo ourfile = new FileInfo("secondfile.txt");
                ourfile.Create();
            }
            File.Delete("firstfile.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt",FileMode.OpenOrCreate,FileAccess.Write );
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("this is first line");
            sw.WriteLine("this is second line");
            sw.Flush();
            sw.Close();
            fs.Close();
            //burda dosyanın içine "this is first line" ve "this is second line" yazdırdık.

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt",FileMode.Open,FileAccess.Read );
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream) 
            {
                textBox1.Text += sr.ReadLine() + Environment.NewLine;

            }
            sr.Close();
            fs.Close ();
        }
    }
}
