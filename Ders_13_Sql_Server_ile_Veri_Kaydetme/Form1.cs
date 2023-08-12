using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ders_13_Sql_Server_ile_Veri_Kaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-K7OR68QK;Initial Catalog=kayıtlar;Integrated Security=True");

        private void verilerimigöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *From gelenler", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) 
            {
                ListViewItem ekle =new ListViewItem();
                ekle.Text = oku["adsoyad"].ToString();
                ekle.SubItems.Add(oku["firma"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["semt"].ToString());
                listView1.Items.Add (ekle);
            }
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerimigöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert INTO gelenler (adsoyad,firma,telefon,semt) Values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + comboBox1.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerimigöster();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Items.Clear();
            

        }

       
    }
}
