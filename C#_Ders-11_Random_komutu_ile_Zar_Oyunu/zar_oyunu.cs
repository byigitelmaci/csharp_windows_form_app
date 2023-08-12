using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Ders_11_Random_komutu_ile_Zar_Oyunu_Veri_tabansız_Bilgi_Yarışması
{
    public partial class zar_oyunu : Form
    {
        public zar_oyunu()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int toplamben = 0;
        int toplampc = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;

            int a=rastgele.Next(1,7);
            label2.Text = a.ToString();

            int b = rastgele.Next(1, 7);
            label4.Text = b.ToString();

            toplamben = toplamben + a + b;
            label13.Text = toplamben.ToString();
            if (a==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar2.jpg";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar3.jpg";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar42.png";
            }
            if (a == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar5.jpg";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar6.png";
            }

            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar2.jpg";
            }
            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar3.jpg";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar42.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar5.jpg";
            }
            if (b== 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar6.png";
            }

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            int c = rastgele.Next(1, 7);
            label11.Text = c.ToString();

            int d = rastgele.Next(1, 7);
            label9.Text = d.ToString();

            toplampc = toplampc + c + d;
            label14.Text = toplampc.ToString();
            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar1.png";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar2.jpg";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar3.jpg";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar42.png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar5.jpg";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar6.png";
            }

            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar1.png";
            }
            if (d== 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar2.jpg";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar3.jpg";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar42.png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar5.jpg";
            }
            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\Downloads\\zar6.png";
            }
            button1.Enabled = true;
            button2.Enabled = false;

            if (toplamben >100 && toplamben > toplampc)
            {
                label15.Text = "tebrikler siz kazandınız";
            }
            if (toplampc > 100 && toplampc > toplamben)
            {
                label15.Text = "tebrikler bilgisayar kazandınız";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
