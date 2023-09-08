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

namespace directory_ve_directory_sınıfları__klasör_işlemleri__ders_61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"c:temp");
            MessageBox.Show(dir.CreationTime.ToString());//burda oluşturma tarihini görüyoruz.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"c:temp"))//burda diyoruz ki c klasöründe temp adında klasör varmı?
            {
                DirectoryInfo dir = new DirectoryInfo(@"c:temp2");//klasör oluşturmak için kullanılır
                dir.Create();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.Move("temp", @"c:\new folder\temp");//klasörü başka bir klasörün içine taşımak için kullanırız.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directory.Delete("temp2");//klasörü silmek için kullanırız.
        }
    }
}
