﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ternary_ders34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10, b = 20;
            string ternaryresult;
            ternaryresult = a<b ? b.ToString() : a.ToString();
            MessageBox.Show(ternaryresult);


        }
    }
}
