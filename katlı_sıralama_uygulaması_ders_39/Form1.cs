using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katlı_sıralama_uygulaması_ders_39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int firstnumber, lastnumber, divisiblenumber;
        string divisibletxt;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
        }

        private void rbblack_CheckedChanged(object sender, EventArgs e)
        {
            if (rbblack.Checked)
            {
                rbblue.Checked = false;
                rbgreen.Checked = false;
                rbred.Checked = false;
                textBox3.ForeColor = Color.Black;
            }
        }

        private void rbblue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbblue.Checked)
            {
                rbblack.Checked = false;
                rbgreen.Checked = false;
                rbred.Checked = false;
                textBox3.ForeColor = Color.Blue;
            }
        }

        private void rbred_CheckedChanged(object sender, EventArgs e)
        {
            if (rbred.Checked)
            {
                rbblue.Checked = false;
                rbgreen.Checked = false;
                rbblack.Checked = false;
                textBox3.ForeColor = Color.Red;
            }
            
        }

        private void rbgreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbgreen.Checked)
            {
                rbblue.Checked = false;
                rbblack.Checked = false;
                rbred.Checked = false;
                textBox3.ForeColor = Color.Green;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox3.Font = new Font(textBox3.Font.FontFamily, textBox3.Font.Size, FontStyle.Bold);
            else
                textBox3.Font = new Font(textBox3.Font.FontFamily, textBox3.Font.Size, FontStyle.Regular);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                textBox3.Font = new Font(textBox3.Font.FontFamily, textBox3.Font.Size, FontStyle.Italic);
            else
                textBox3.Font = new Font(textBox3.Font.FontFamily, textBox3.Font.Size, FontStyle.Regular);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisiblenumber = Convert.ToInt32(comboBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int controlnumber = 0;
            if (textBox1.Text.Trim() == "" && textBox2.Text.Trim() == "")
            {
                errorProvider1.SetError(textBox1, "Please fill textbox");
                errorProvider1.SetError(textBox2, "please fill textbox");
                MessageBox.Show("Please fill neccessary fields");
            }

            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select divisible term");
            }
            else
            {
                firstnumber = Convert.ToInt32(textBox1.Text);
                lastnumber = Convert.ToInt32(textBox2.Text);
                for (int i = firstnumber; i <= lastnumber; i++)
                {
                    if (i % divisiblenumber == 0)
                    {
                        divisibletxt += " " + i.ToString() + " ";
                        controlnumber++;
                        if (controlnumber % 10 == 0)
                            divisibletxt += Environment.NewLine;

                    }
                }
                textBox3.Text = divisibletxt;
            }
            //MessageBox.Show(firstnumber +" "+lastnumber+" "+divisiblenumber);e3s
        }
    }
}
