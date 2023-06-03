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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        void listele()
        {
            baglan.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From TblMusteri where TblMusteri.ID>0", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }
        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtMAdi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            TxtMsoyadi.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            TxtAdres.Text = gridView1.GetFocusedRowCellValue("Adres").ToString();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TblMusteri (Ad,Soyad,Mail,Telefon,Adres) values (@a,@b,@c,@d,@e)", baglan);

            baglan.Open();

            
            komut.Parameters.AddWithValue("@a", TxtMAdi.Text);
            komut.Parameters.AddWithValue("@b", TxtMsoyadi.Text);
            komut.Parameters.AddWithValue("@c", TxtMail.Text);
            komut.Parameters.AddWithValue("@d", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@e",TxtAdres.EditValue);
       
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblMusteri set Ad=@b,Soyad=@c,Mail=@d,Telefon=@e,Adres=@f Where TblMusteri.ID=@a", baglan);
            komut.Parameters.AddWithValue("@a", TxtID.Text);
            komut.Parameters.AddWithValue("@b", TxtMAdi.Text);
            komut.Parameters.AddWithValue("@c", TxtMsoyadi.Text);
            komut.Parameters.AddWithValue("@d", TxtMail.Text);
            komut.Parameters.AddWithValue("@e", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@f", TxtAdres.EditValue);

            komut.ExecuteNonQuery();
            baglan.Close();
            listele();


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from TblMusteri where ID=(" + TxtID.Text + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
            MessageBox.Show("Müşteri Başarıyla Silinmiştir...");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ExportToXls(@"C:\Users\User\Desktop\MusteriListesi.xls");
        }
    }
}
