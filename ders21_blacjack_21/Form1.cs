using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders21_blacjack_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac = 0;
        int oyuncupuan = 0;
        int bilgisiyarpuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //kart1.Text = kart2.Text = kart3.Text = kart4.Text = kart5.Text = kart6.Text = kart7.Text = kart8.Text = "0";

            sayac++;
            if (sayac == 1)
            {
                int a1, a2, toplam;
                a1 = rastgele.Next(1, 11);
                a2 = rastgele.Next(1, 11);
                toplam = a1 + a2;

                kart1.Text = a1.ToString();
                kart2.Text = a2.ToString();

                label9.Text = toplam.ToString();

                kart3.Text = kart4.Text = "0";
            }
            if (sayac == 2)
            {
                int a3, toplam;
                a3 = rastgele.Next(1, 11);
                kart3.Text = a3.ToString();

                toplam = Convert.ToInt32(kart1.Text) + Convert.ToInt32(kart2.Text) + a3;
                label9.Text = toplam.ToString();

                kart4.Text = "0";
            }
            if (sayac == 3)
            {
                int a4, toplam;
                a4 = rastgele.Next(1, 11);
                kart4.Text = a4.ToString();
                toplam = Convert.ToInt32(kart1.Text) + Convert.ToInt32(kart2.Text) + Convert.ToInt32(kart3.Text) + a4;
                label9.Text = toplam.ToString();
            }
            //if (label1.Text == "1")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\1.JPG";
            //}
            //if (label1.Text == "2")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\2.JPG";
            //}
            //if (label1.Text == "3")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\3.JPG";
            //}
            //if (label1.Text == "4")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\41.jpg";
            //}
            //if (label1.Text == "5")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\5.jpg";
            //}
            //if (label1.Text == "6")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\6.jpg";
            //}
            //if (label1.Text == "7")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\711.jpg";
            //}
            //if (label1.Text == "8")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\8.jpg";
            //}
            //if (label1.Text == "9")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\9.jpg";
            //}
            //if (label1.Text == "10")
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\10.jpg";
            //}
            //if (label2.Text == "1")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\1.JPG";
            //}
            //if (label2.Text == "2")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\2.JPG";
            //}
            //if (label2.Text == "3")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\3.JPG";
            //}
            //if (label2.Text == "4")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\41.jpg";
            //}
            //if (label2.Text == "5")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\5.jpg";
            //}
            //if (label2.Text == "6")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\6.jpg";
            //}
            //if (label2.Text == "7")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\711.jpg";
            //}
            //if (label2.Text == "8")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\8.jpg";
            //}
            //if (label2.Text == "9")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\9.jpg";
            //}
            //if (label2.Text == "10")
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\10.jpg";
            //}
            //if (label3.Text == "1")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\1.JPG";
            //}
            //if (label3.Text == "2")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\2.JPG";
            //}
            //if (label3.Text == "3")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\3.JPG";
            //}
            //if (label3.Text == "4")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\41.jpg";
            //}
            //if (label3.Text == "5")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\5.jpg";
            //}
            //if (label3.Text == "6")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\6.jpg";
            //}
            //if (label3.Text == "7")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\711.jpg";
            //}
            //if (label3.Text == "8")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\8.jpg";
            //}
            //if (label3.Text == "9")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\9.jpg";
            //}
            //if (label3.Text == "10")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\10.jpg";
            //}
            //if (label4.Text == "1")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\1.JPG";
            //}
            //if (label4.Text == "2")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\2.JPG";
            //}
            //if (label4.Text == "3")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\3.JPG";
            //}
            //if (label4.Text == "4")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\41.jpg";
            //}
            //if (label4.Text == "5")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\5.jpg";
            //}
            //if (label4.Text == "6")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\6.jpg";
            //}
            //if (label4.Text == "7")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\711.jpg";
            //}
            //if (label4.Text == "8")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\8.jpg";
            //}
            //if (label4.Text == "9")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\9.jpg";
            //}
            //if (label4.Text == "10")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\10.jpg";
            //}
            //if (label5.Text == "1")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\1.JPG";
            //}
            //if (label5.Text == "2")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\2.JPG";
            //}
            //if (label5.Text == "3")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\3.JPG";
            //}
            //if (label5.Text == "4")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\41.jpg";
            //}
            //if (label5.Text == "5")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\5.jpg";
            //}
            //if (label5.Text == "6")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\6.jpg";
            //}
            //if (label5.Text == "7")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\711.jpg";
            //}
            //if (label5.Text == "8")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\8.jpg";
            //}
            //if (label5.Text == "9")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\9.jpg";
            //}
            //if (label5.Text == "10")
            //{
            //    pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\10.jpg";
            //}
            //if (label6.Text == "1")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\1.JPG";
            //}
            //if (label6.Text == "2")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\2.JPG";
            //}
            //if (label6.Text == "3")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\3.JPG";
            //}
            //if (label6.Text == "4")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\41.jpg";
            //}
            //if (label6.Text == "5")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\5.jpg";
            //}
            //if (label6.Text == "6")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\6.jpg";
            //}
            //if (label6.Text == "7")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\711.jpg";
            //}
            //if (label6.Text == "8")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\8.jpg";
            //}
            //if (label6.Text == "9")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\9.jpg";
            //}
            //if (label6.Text == "10")
            //{
            //    pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\10.jpg";
            //}
            //if (label7.Text == "1")
            //{
            //    pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\1.JPG";
            //}
            //if (label7.Text == "2")
            //{
            //    pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\2.JPG";
            //}
            //if (label7.Text == "3")
            //{
            //    pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\3.JPG";
            //}
            //if (label7.Text == "4")
            //{
            //    pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\41.jpg";
            //}
            //if (label7.Text == "5")
            //{
            //    pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\5.jpg";
            //}
            //if (label7.Text == "6")
            //{
            //    pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\6.jpg";
            //}
            //if (label7.Text == "7")
            //{
            //    pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\711.jpg";
            //}
            //if (label7.Text == "8")
            //{
            //    pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\8.jpg";
            //}
            //if (label7.Text == "9")
            //{
            //    pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\9.jpg";
            //}
            //if (label7.Text == "10")
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\10.jpg";
            //}
            //if (label8.Text == "1")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\1.JPG";
            //}
            //if (label8.Text == "2")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\2.JPG";
            //}
            //if (label8.Text == "3")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\3.JPG";
            //}
            //if (label8.Text == "4")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\41.jpg";
            //}
            //if (label8.Text == "5")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\5.jpg";
            //}
            //if (label8.Text == "6")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\6.jpg";
            //}
            //if (label8.Text == "7")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\711.jpg";
            //}
            //if (label8.Text == "8")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\8.jpg";
            //}
            //if (label8.Text == "9")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\9.jpg";
            //}
            //if (label8.Text == "10")
            //{
            //    pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\10.jpg";
            //}

            pictureBox1.ImageLocation = $"C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\{kart1.Text}.jpg";
            //pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\" + label1.Text + ".jpg";
            //pictureBox1.ImageLocation = @"C:\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\" + label1.Text + ".jpg";
            pictureBox2.ImageLocation = $"C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\{kart2.Text}.jpg";
            pictureBox3.ImageLocation = $"C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\{kart3.Text}.jpg";
            pictureBox4.ImageLocation = $"C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\{kart4.Text}.jpg";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2, toplam;
            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);
            toplam = b1 + b2;

            kart5.Text = b1.ToString();
            kart6.Text = b2.ToString();
            label11.Text = toplam.ToString();

            kart7.Text = "0";
            kart8.Text = "0";

            if (toplam < 16)
            {
                int b3;
                b3 = rastgele.Next(1, 11);
                kart7.Text = b3.ToString();

                toplam = toplam + b3;
                label11.Text = toplam.ToString();

            }
            if (toplam < 16)
            {
                int b4;
                b4 = rastgele.Next(1, 11);
                kart8.Text = b4.ToString();

                toplam = toplam + b4;
                label11.Text = toplam.ToString();
            }

            pictureBox5.ImageLocation = $"C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\{kart5.Text}.jpg";
            pictureBox6.ImageLocation = $"C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\{kart6.Text}.jpg";
            pictureBox7.ImageLocation = $"C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\{kart7.Text}.jpg";
            pictureBox8.ImageLocation = $"C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\{kart8.Text}.jpg";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;
            int oyuncutoplam, bilgisiyartoplam;

            oyuncutoplam = Convert.ToInt32(label9.Text);
            bilgisiyartoplam = Convert.ToInt32(label11.Text);
            if (oyuncutoplam > bilgisiyartoplam && oyuncutoplam < 21)
            {
                oyuncupuan = oyuncupuan + 10;
                label20.Text = oyuncupuan.ToString();
            }
            if (bilgisiyartoplam > oyuncutoplam && bilgisiyartoplam < 21)
            {
                bilgisiyarpuan = bilgisiyarpuan + 10;
                label21.Text = bilgisiyarpuan.ToString();
            }
            if (bilgisiyartoplam > 21 && oyuncutoplam > 21)
            {
                MessageBox.Show("Değerler Büyük Beraberlik");
            }
            if (bilgisiyartoplam == oyuncutoplam && bilgisiyartoplam <= 21 && oyuncutoplam <= 21)
            {
                bilgisiyarpuan = bilgisiyarpuan + 10;
                oyuncupuan = oyuncupuan + 10;
            }
            if (oyuncupuan == 50)
            {
                MessageBox.Show("tebrikler kazandınızzzzzz!!!!!!!");
            }
            if (bilgisiyarpuan == 50)
            {
                MessageBox.Show("maalesef kaybettinizzzzzz!!!!!!!");
            }
            if (bilgisiyartoplam <= 21 && oyuncutoplam > 21)
            {
                bilgisiyarpuan = bilgisiyarpuan + 10;
                label21.Text = bilgisiyarpuan.ToString();
            }
            if (oyuncupuan <= 21 && bilgisiyartoplam > 21)
            {
                oyuncupuan = oyuncupuan + 10;
                label20.Text = oyuncupuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayac = 0;
            //label1.Text = "0";
            //label2.Text = "0";
            //label3.Text = "0";
            //label4.Text = "0";
            //label5.Text = "0";
            //label6.Text = "0";
            //label7.Text = "0";
            //label8.Text = "0";
            //label9.Text = "0";
            //label11.Text = "0";
            button4.Enabled = false;
            button3.Enabled = true;
            //pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\0.";
            //pictureBox2.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\0.jpg";
            //pictureBox3.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\11.png";
            //pictureBox4.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\11.png";
            //pictureBox5.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\11.png";
            //pictureBox6.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\11.png";
            //pictureBox7.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\11.png";
            //pictureBox8.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\11.png";
            this.Controls.OfType<Label>().Where(x => x.Name.Contains("kart")).All(x =>
            {
                x.Text = "0";
                return true;
            });
            this.Controls.OfType<PictureBox>().All(x =>
            {
                x.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\0.jpg";
                return true;
            });
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
