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



namespace Yolcu_Bilet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = EREN\SQLEXPRESS; Initial Catalog = Yolcu_bilet; Integrated Security = True");
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand bilgiyolcu = new SqlCommand("insert into Yolcu_bilgiler (yolcu_ad,yolcu_soyad,yolcu_tel,yolcu_tc,yolcu_cins,yolcu_mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            bilgiyolcu.Parameters.AddWithValue("@p1",txtad.Text);
            bilgiyolcu.Parameters.AddWithValue("@p2",txtsoyad.Text);
            bilgiyolcu.Parameters.AddWithValue("@p3",msktel.Text);
            bilgiyolcu.Parameters.AddWithValue("@p4",msktc.Text);
            bilgiyolcu.Parameters.AddWithValue("@p5", combocins.Text);
            bilgiyolcu.Parameters.AddWithValue("@p6", txtmail.Text);
            bilgiyolcu.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Bilgisi Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
