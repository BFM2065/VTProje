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

namespace VTProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");

        bool durum = true;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From TblKullanicilar where  KullaniciAdi='" + textBox1.Text+"' AND Sifre='"+maskedTextBox1.Text+"' AND Yetki in (3)", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                Yonetici yonetici = new Yonetici();
                yonetici.Show();
                this.Hide();
                durum = false;
            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut1 = new SqlCommand("Select * From TblKullanicilar where  KullaniciAdi='" + textBox1.Text + "' AND Sifre='" + maskedTextBox1.Text + "' AND Yetki in (1)", baglan);
            SqlDataReader oku1 = komut1.ExecuteReader();

            if (oku1.Read())
            {
                Personel personel = new Personel();
                personel.Show();
                this.Hide();
                durum = false;
            }
            baglan.Close();
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Select * From TblKullanicilar where  KullaniciAdi='" + textBox1.Text + "' AND Sifre='" + maskedTextBox1.Text + "' AND Yetki in (2)", baglan);
            SqlDataReader oku2 = komut2.ExecuteReader();

            if (oku2.Read())
            {
                TeknikServis teknik = new TeknikServis();
                teknik.Show();
                this.Hide();
                durum = false;
            }
            else if(durum==true)
            {
                MessageBox.Show("Yanlış Giriş","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           
            
               
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
