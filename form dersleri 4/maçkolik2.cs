using AxWMPLib;
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
    public partial class maçkolik2 : Form
    {
        public maçkolik2()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int fbpuan = 0;
        int gspuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; //butona sadece bi kere basmaya yarıyo
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label7.Text = c.ToString();
            label6.Text = d.ToString();


            if (Convert.ToInt32(label4.Text) > (Convert.ToInt32(label5.Text)))
            {
                gspuan = gspuan + 3;
                gspuann.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label5.Text) > (Convert.ToInt32(label4.Text)))
            {
                fbpuan = fbpuan + 3;
                fbpuann.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label4.Text) == (Convert.ToInt32(label5.Text)))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                gspuann.Text = gspuan.ToString();
                fbpuann.Text = fbpuan.ToString();

            }

            if (Convert.ToInt32(label7.Text) > (Convert.ToInt32(label6.Text)))
            {
                bjkpuan = bjkpuan + 3;
                bjkpuann.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > (Convert.ToInt32(label7.Text)))
            {
                tspuan = tspuan + 20;
                tspuann.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) == (Convert.ToInt32(label6.Text)))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                bjkpuann.Text = bjkpuan.ToString();
                tspuann.Text = tspuan.ToString();

            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false; //butona sadece bi kere basmaya yarıyo
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label11.Text = a.ToString();
            label12.Text = b.ToString();
            label18.Text = c.ToString();
            label21.Text = d.ToString();


            if (Convert.ToInt32(label11.Text) > (Convert.ToInt32(label12.Text)))
            {
                gspuan = gspuan + 3;
                gspuann.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) > (Convert.ToInt32(label11.Text)))
            {
                bjkpuan = bjkpuan + 3;
                bjkpuann.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == (Convert.ToInt32(label12.Text)))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                gspuann.Text = gspuan.ToString();
                bjkpuann.Text = bjkpuan.ToString();

            }

            if (Convert.ToInt32(label18.Text) > (Convert.ToInt32(label21.Text)))
            {
                fbpuan = fbpuan + 3;
                fbpuann.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) > (Convert.ToInt32(label18.Text)))
            {
                tspuan = tspuan + 20;
                tspuann.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label18.Text) == (Convert.ToInt32(label21.Text)))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                fbpuann.Text = fbpuan.ToString();
                tspuann.Text = tspuan.ToString();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false; //butona sadece bi kere basmaya yarıyo
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label25.Text = a.ToString();
            label26.Text = b.ToString();
            label30.Text = c.ToString();
            label31.Text = d.ToString();


            if (Convert.ToInt32(label25.Text) > (Convert.ToInt32(label26.Text)))
            {
                fbpuan = fbpuan + 3;
                fbpuann.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label26.Text) > (Convert.ToInt32(label25.Text)))
            {
                bjkpuan = bjkpuan + 3;
                bjkpuann.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == (Convert.ToInt32(label26.Text)))
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                fbpuann.Text = fbpuan.ToString();
                bjkpuann.Text = bjkpuan.ToString();

            }

            if (Convert.ToInt32(label30.Text) > (Convert.ToInt32(label31.Text)))
            {
                tspuan = tspuan + 20;
                tspuann.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label31.Text) > (Convert.ToInt32(label30.Text)))
            {
                gspuan = gspuan + 3;
                gspuann.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) == (Convert.ToInt32(label31.Text)))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                tspuann.Text = tspuan.ToString();
                gspuann.Text = gspuan.ToString();

            }
        }
        
    private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(gspuann.Text) > Convert.ToInt32(fbpuann.Text) && Convert.ToInt32(gspuann.Text)> Convert.ToInt32(bjkpuann.Text)&& Convert.ToInt32(gspuann.Text)> Convert.ToInt32(tspuann.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\gs.mp3";
            }
            if (Convert.ToInt32(fbpuann.Text) > Convert.ToInt32(gspuann.Text) && Convert.ToInt32(fbpuann.Text) > Convert.ToInt32(bjkpuann.Text) && Convert.ToInt32(fbpuann.Text) > Convert.ToInt32(tspuann.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\fb.mp4";
            }
            if (Convert.ToInt32(tspuann.Text) > Convert.ToInt32(fbpuann.Text) && Convert.ToInt32(tspuann.Text) > Convert.ToInt32(bjkpuann.Text) && Convert.ToInt32(tspuann.Text) > Convert.ToInt32(gspuann.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\ts,.mp3";
            }
            if (Convert.ToInt32(bjkpuann.Text) > Convert.ToInt32(gspuann.Text) && Convert.ToInt32(bjkpuann.Text) > Convert.ToInt32(fbpuann.Text) && Convert.ToInt32(bjkpuann.Text) > Convert.ToInt32(tspuann.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\bjk.mp3";
            }
            


        }
    }
}
