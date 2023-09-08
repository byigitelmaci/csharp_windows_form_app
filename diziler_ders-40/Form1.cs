using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_ders_40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string[] days = new string[] { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
            for (int i = 0; i < days.Length; i++)
            {
                string rowtext = days[i];
                dataGridView1.Rows.Add(rowtext);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] rows = new string[,]
            {
                {"1","Monday" },
                {"2","Tuesday"},
                {"3","wednesday"},
                {"4","Friday" },
                {"5","Saturday"},
                {"6","Sunday"},
                {"7","Thursday"},
                
            };

            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string[] row = new string[rows.GetLength(1)];
                for (int k = 0; k < rows.GetLength(1); k++)
                {
                    row[k] = rows[i, k];
                }
                dataGridView1.Rows.Add (row);
            }

        }
    }
}
