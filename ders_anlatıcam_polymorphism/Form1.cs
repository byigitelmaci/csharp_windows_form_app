using ders_anlatıcam_polymorphism.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_anlatıcam_polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "M16A4")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\m16a4.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                M16A4 m16A4 = new M16A4();
                m16A4.silahlar();
                
            }
            if (comboBox1.Text =="AWM" )
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\awm.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Red;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                AWM aWM = new AWM();
                aWM.silahlar();
            }
            if (comboBox1.Text =="scar-L" )
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\SCAR-L.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Red;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                scar_L_ scar_L = new scar_L_();
                scar_L.silahlar();
            }
            if (comboBox1.Text == "ak-47")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\ak47.jpg";
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                silah silah = new silah();
                silah.silahlar();
                
            }
            if (comboBox1.Text == "M416")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\m416.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                M416 m416 = new M416();
                m416.silahlar();
            }
            if (comboBox1.Text == "M762")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\m762.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                M762 m762 = new M762();
                m762.silahlar();
            }
            if (comboBox1.Text == "M249")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\m249.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                M249 m249 = new M249();
                m249.silahlar();
            }
            if (comboBox1.Text == "famas")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\famas.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                famas famas = new famas();
                famas.silahlar();
            }
            if (comboBox1.Text == "groza")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\pubgm-GROZA.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                groza groza = new groza();
                groza.silahlar();
            }
            if (comboBox1.Text == "kar98k")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\kar98k.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Red;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Gray;
                kar98k kar98K = new kar98k();
                kar98K.silahlar();
            }
            
            
            if (comboBox1.Text == "m24")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\m24.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Red;
                button12.BackColor = Color.Gray;
                M24 m24 = new M24();
                m24.silahlar();
            }
            if (comboBox1.Text == "win94")
            {
                pictureBox1.ImageLocation = "C:\\Users\\HUAWEI\\OneDrive\\Masaüstü\\csharp vid,foto\\win94.jpg";
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Gray;
                button6.BackColor = Color.Gray;
                button7.BackColor = Color.Gray;
                button8.BackColor = Color.Gray;
                button9.BackColor = Color.Gray;
                button10.BackColor = Color.Gray;
                button11.BackColor = Color.Gray;
                button12.BackColor = Color.Red;
                win94 win94 = new win94();
                win94.silahlar();
            }

        }
    }
}
