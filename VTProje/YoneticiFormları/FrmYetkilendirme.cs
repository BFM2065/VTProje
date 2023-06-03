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
    public partial class FrmYetkilendirme : Form
    {
        public FrmYetkilendirme()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        void listele()
        {
            baglan.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From TblKullanicilar", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAdi.Text = gridView1.GetFocusedRowCellValue("KullaniciAdi").ToString();
            TxtSifre.Text = gridView1.GetFocusedRowCellValue("Sifre").ToString();
            TxtYetki.Text = gridView1.GetFocusedRowCellValue("Yetki").ToString();
            
        }

        private void FrmYetkilendirme_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TblKullanicilar (KullaniciAdi,Sifre,Yetki) values (@a,@b,@c)", baglan);

            baglan.Open();


     
            komut.Parameters.AddWithValue("@a", TxtAdi.Text);
            komut.Parameters.AddWithValue("@b", TxtSifre.Text);
            komut.Parameters.AddWithValue("@c", TxtYetki.Text);
           

            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from TblKullanicilar where ID=(" + TxtID.Text + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
            MessageBox.Show("Kullanici Başarıyla Silinmiştir...");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblKullanicilar set KullaniciAdi=@a,Sifre=@b,Yetki=@c Where ID=@d", baglan);
            komut.Parameters.AddWithValue("@d", TxtID.Text);
            komut.Parameters.AddWithValue("@a", TxtAdi.Text);
            komut.Parameters.AddWithValue("@b", TxtSifre.Text);
            komut.Parameters.AddWithValue("@c", TxtYetki.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
        }
    }
}
