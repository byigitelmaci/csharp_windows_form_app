using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_dersleri_4
{
    public partial class linkle_müzik_koyma : Form
    {
        public linkle_müzik_koyma()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\1.mp3";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\1.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\fps2-hero.jpg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\oluyoz-amk-vol-4-official-video-d.mp3";
            pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\images (3).jpg";
        }

        private void linkle_müzik_koyma_Load(object sender, EventArgs e)
        {

        }
    }
}
