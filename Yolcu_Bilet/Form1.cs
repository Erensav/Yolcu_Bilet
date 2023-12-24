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


        void seferlistesi()
        {
            SqlDataAdapter sefergoster = new SqlDataAdapter("Select * From sefer_bilgileri",baglanti);
            DataTable dt = new DataTable(); 
            sefergoster.Fill(dt);
            dataGridView1.DataSource = dt;
        }
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
            MessageBox.Show("Yolcu Bilgisi Sisteme Kaydedildi","Basarili",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtad.Text = "";
            txtsoyad.Text = "";
            msktel.Text = "";
            msktc.Text = "";
            combocins.Text = "";
            txtmail.Text = "";



        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnkaptan_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kaptanbilgi = new SqlCommand("insert into kaptan_bilgi (kaptanad_soyad,kaptan_tel,kaptan_no) values (@1,@2,@3)",baglanti);
            kaptanbilgi.Parameters.AddWithValue("@1",txtkptnad.Text);
            kaptanbilgi.Parameters.AddWithValue("@2",mskkptntel.Text);
            kaptanbilgi.Parameters.AddWithValue("@3",txtkptnno.Text);
            kaptanbilgi.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtkptnad.Text = "";
            mskkptntel.Text = "";
            txtkptnno.Text = "";



        }

        private void btnsefer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand seferbilgi = new SqlCommand("insert into sefer_bilgileri (sefer_kalkis,sefer_varis,sefer_tarih,sefer_saat,sefer_kaptan,sefer_fiyat) values (@1,@2,@3,@4,@5,@6)",baglanti);
            seferbilgi.Parameters.AddWithValue("@1",txtkls.Text);
            seferbilgi.Parameters.AddWithValue("@2",txtvrs.Text);
            seferbilgi.Parameters.AddWithValue("@3",msktarih.Text);
            seferbilgi.Parameters.AddWithValue("@4",msksaat.Text);
            seferbilgi.Parameters.AddWithValue("@5",mskkaptan.Text);
            seferbilgi.Parameters.AddWithValue("@6",txtfyt.Text);
            seferbilgi.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer Bilgisi Sisteme Kaydedildi", "Sefer Kaydi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtkls.Text = "";
            txtvrs.Text = "";
            msktarih.Text = "";
            msksaat.Text = "";
            mskkaptan.Text = "";
            txtfyt.Text = "";
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferlistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtseferno.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "1";
            button1.BackColor = Color.Red;
            button1.Enabled= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "2";
            button2.BackColor = Color.Red;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "10";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "11";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "12";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "13";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "14";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtkoltukno.Text = "15";
        }

        private void btnrezervasyon_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand rezerve = new SqlCommand("insert into sefer_detay (sefer_no,yolcu_tc,koltuk) values (@1,@2,@3)",baglanti);
            rezerve.Parameters.AddWithValue("@1",txtseferno.Text);
            rezerve.Parameters.AddWithValue("@2",mskrezervetc);
            rezerve.Parameters.AddWithValue("@3",txtkoltukno.Text);
            rezerve.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rezervasyonunuz Basari ile Sisteme Kaydedildi", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtseferno.Text = "";
            mskrezervetc.Text = "";
            txtkoltukno.Text = "";

        }
    }
}
