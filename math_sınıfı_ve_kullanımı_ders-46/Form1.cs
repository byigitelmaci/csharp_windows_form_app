using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sınıfı_ve_kullanımı_ders_46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstnumber, secondnumber;
        bool control=false;

        void set1parameter(string text)
        {
            if (txtfirst.Text.Trim() != "") 
            {
                control = true;
                firstnumber = Convert.ToDouble(text);
            }
            else
                control = false;
            

        }
        void set2parameter(string text,string text2)
        {
            if (txtfirst.Text.Trim() != ""&& txtsecond.Text.Trim() != "")
            {
                control = true;
                firstnumber = Convert.ToDouble(txtfirst.Text);
                secondnumber = Convert.ToDouble(txtsecond.Text);
                    
            }
            else
                control = false;
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            set2parameter(txtfirst.Text,txtsecond.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtresult.Text = Math.Min(Convert.ToDecimal(firstnumber), Convert.ToDecimal(secondnumber)).ToString();
            }

        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            set2parameter(txtfirst.Text, txtsecond.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtresult.Text = Math.Max(Convert.ToDecimal(firstnumber), Convert.ToDecimal(secondnumber)).ToString();
            }
        }

        private void btnabs_Click(object sender, EventArgs e)
        {
            set1parameter(txtfirst.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtresult.Text = Math.Abs(Convert.ToDecimal(firstnumber)).ToString();
            }
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            set1parameter(txtfirst.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                txtresult.Text = Math.Sign(Convert.ToDecimal(firstnumber)).ToString();
            }
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            set1parameter(txtfirst.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                double temp = (firstnumber * (Math.PI)) / 180;
                txtresult.Text = Math.Sin(temp).ToString();
            }
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            set1parameter(txtfirst.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                double temp = (firstnumber * (Math.PI)) / 180;
                txtresult.Text = Math.Cos(temp).ToString();
            }
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            set1parameter(txtfirst.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                double temp = (firstnumber * (Math.PI)) / 180;
                txtresult.Text = Math.Tan(temp).ToString();
            }
        }

        private void btnpow_Click(object sender, EventArgs e)
        {
            set2parameter(txtfirst.Text,txtsecond.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                
                txtresult.Text = Math.Pow(firstnumber,secondnumber).ToString();
            }
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            set1parameter(txtfirst.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {
                
                txtresult.Text = Math.Sqrt(firstnumber).ToString();
            }
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            set2parameter(txtfirst.Text, txtsecond.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {

                txtresult.Text = Math.Log(firstnumber, secondnumber).ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            set1parameter(txtfirst.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {

                txtresult.Text = Math.Log10(firstnumber).ToString();
            }
        }

        private void btnexp_Click(object sender, EventArgs e)
        {
            set1parameter(txtfirst.Text);
            if (!control)
                MessageBox.Show("please fill the necessary fields");
            else
            {

                txtresult.Text = Math.Exp(firstnumber).ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtresult.Text.Trim() != "")
                txtfirst.Text = txtresult.Text;
            txtsecond.Clear();
            txtresult.Clear(); 

            
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            firstnumber = 0;
            secondnumber=0;
            txtresult.Clear();
            txtfirst.Clear();
            txtsecond.Clear();

        
        }

        
    }
}
