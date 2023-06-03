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
namespace VTProje.YoneticiFormları
{
    public partial class FrmMarkaListesi : Form
    {
        public FrmMarkaListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        void listele()
        {
            baglan.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From TblMarka where TblMarka.Durum in (1)", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }
        private void FrmMarkaListesi_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblMarka set TblMarka.Durum=@b Where TblMarka.ID=@a", baglan);
            komut.Parameters.AddWithValue("@a",TxtID.Text);
            komut.Parameters.AddWithValue("@b", false);
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
        }
        bool durum = true;
        bool sil = true;
        bool kon = true;
        void kontrol()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From TblMarka where TblMarka.ID=@a ", baglan);
            komut.Parameters.AddWithValue("@a", TxtID.Text);
            SqlDataReader re = komut.ExecuteReader();
            if (re.Read())
            {
                kon = false;

            }
            else
            {
                kon = true;
            }
            baglan.Close();
        }
        void Silim()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("Select * From TblMarka where Durum in (0)", baglan);
            SqlDataReader re1 = cmd.ExecuteReader();
            if (re1.Read())
            {
                sil = false;

            }
            else
            {
                sil = true;
            }
            baglan.Close();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text= gridView1.GetFocusedRowCellValue("Adi").ToString();
            TxtKAP.Text= gridView1.GetFocusedRowCellValue("GarantiKapsami").ToString();
            TxtYıl.Text= gridView1.GetFocusedRowCellValue("GarantiYili").ToString();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TblMarka (ID,Adi,GarantiYili,GarantiKapsami,Durum) values (@a,@b,@c,@d,@e)", baglan);
            kontrol();

            Silim();

            if (kon == true)
            {
                baglan.Open();


                komut.Parameters.AddWithValue("@a", TxtID.Text);
                komut.Parameters.AddWithValue("@b", TxtAd.Text);
                komut.Parameters.AddWithValue("@c", TxtYıl.Text);
                komut.Parameters.AddWithValue("@d", TxtKAP.Text);
                komut.Parameters.AddWithValue("@e", durum);
                komut.ExecuteNonQuery();
                baglan.Close();
            }



            else if (kon == false && sil == false)
            {
                baglan.Open();
                durum = true;
                SqlCommand komut2 = new SqlCommand("Update TblMarka set Durum=@e,Adi=@b,GarantiYili=@c,GarantiKapsami=@d Where Adi=@b", baglan);
          
                 komut2.Parameters.AddWithValue("@b", TxtAd.Text);
                 komut2.Parameters.AddWithValue("@c", TxtYıl.Text);
                komut2.Parameters.AddWithValue("@d", TxtKAP.Text);
                komut2.Parameters.AddWithValue("@e", durum);
               
                komut2.ExecuteNonQuery();
                baglan.Close();
                listele();
               

            }
            else
            {
                MessageBox.Show("Zaten Olan Bir Marka Girdiniz");

            }





        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut2 = new SqlCommand("Update TblMarka set Durum=@e,Adi=@b,GarantiYili=@c,GarantiKapsami=@d where TblMarka.ID=@a", baglan);
            komut2.Parameters.AddWithValue("@a", TxtID.Text);
            komut2.Parameters.AddWithValue("@b", TxtAd.Text);
            komut2.Parameters.AddWithValue("@c", TxtYıl.Text);
            komut2.Parameters.AddWithValue("@d", TxtKAP.Text);
            komut2.Parameters.AddWithValue("@e", durum);
            komut2.ExecuteNonQuery();
            baglan.Close();
            listele();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ExportToXls(@"C:\Users\User\Desktop\MarkaListesi.xls");
        }
    }
}
