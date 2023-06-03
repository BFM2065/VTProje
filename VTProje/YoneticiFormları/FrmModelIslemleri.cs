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
    public partial class FrmModelIslemleri : Form
    {
        public FrmModelIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");

        void listele()
        {
            baglan.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select TblModel.ID,ModelAdi AS [Model Adı],TblMarka.Adi AS [Marka Adı],Ozellikleri,AlisFiyati,SatisFiyati,TblKategori.Kategori From TblModel JOIN TblMarka on TblModel.MarkaID=TblMarka.ID  JOIN TblKategori  on TblModel.KategoriID=TblKategori.ID WHERE DurumModel in (1)", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }


       
        private void FrmModelIslemleri_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Select Adi,ID From TblMarka", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TxtMarka.Properties.ValueMember = "ID";  //alınacak veri 
            TxtMarka.Properties.DisplayMember = "Adi";  //yerine getirilicek veri ID nin karşılığını veriyo ona göre
            TxtMarka.Properties.DataSource = dt;
            baglan.Close();
            baglan.Open();

            SqlDataAdapter da1 = new SqlDataAdapter("Select Kategori,ID From TblKategori", baglan);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            lookUpEdit1.Properties.ValueMember = "ID";//alınacak veri 
            lookUpEdit1.Properties.DisplayMember = "Kategori";//yerine getirilicek veri ID nin karşılığını veriyo ona göre
            lookUpEdit1.Properties.DataSource = dt1;
            baglan.Close();


            listele();


        }
       
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtModelAdi.Text = gridView1.GetFocusedRowCellValue("Model Adı").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("Marka Adı").ToString();
            TxtOzellik.Text = gridView1.GetFocusedRowCellValue("Ozellikleri").ToString();
            TxtSatisF.Text = gridView1.GetFocusedRowCellValue("SatisFiyati").ToString();
            TxtAlisFiyati.Text = gridView1.GetFocusedRowCellValue("AlisFiyati").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Kategori").ToString();
           
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
          
            

            SqlCommand komut = new SqlCommand("Insert into TblModel(ModelAdi,MarkaID,Ozellikleri,AlisFiyati,SatisFiyati,KategoriID) values (@a,@b,@c,@d,@e,@f)", baglan);




            komut.Parameters.AddWithValue("@a", TxtModelAdi.Text);
            komut.Parameters.AddWithValue("@b", TxtMarka.EditValue);
            komut.Parameters.AddWithValue("@c", TxtOzellik.Text);
            komut.Parameters.AddWithValue("@d", Convert.ToDecimal(TxtAlisFiyati.Text));
            komut.Parameters.AddWithValue("@e", Convert.ToDecimal(TxtSatisF.Text));
            komut.Parameters.AddWithValue("@f", lookUpEdit1.EditValue);
            MessageBox.Show("Model Başarıyla Eklendi!!!");
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblModel set ModelAdi=@b,MarkaID=@c,Ozellikleri=@d,AlisFiyati=@e,SatisFiyati=@f,KategoriID=@g Where TblModel.ID=@a", baglan);
            komut.Parameters.AddWithValue("@a", TxtID.Text);
            komut.Parameters.AddWithValue("@b", TxtModelAdi.Text);
            komut.Parameters.AddWithValue("@c", TxtMarka.EditValue);
            komut.Parameters.AddWithValue("@d", TxtOzellik.Text);
            komut.Parameters.AddWithValue("@e", Convert.ToDecimal(TxtAlisFiyati.Text));
            komut.Parameters.AddWithValue("@f", Convert.ToDecimal(TxtSatisF.Text));
            komut.Parameters.AddWithValue("@g", lookUpEdit1.EditValue);
            MessageBox.Show("Model Başarıyla Güncellendi!!!");

            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from TblModel where ID=(" + TxtID.Text + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
 
            MessageBox.Show("Model Başarıyla Silinmiştir...");
            listele();
          
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ExportToXls(@"C:\Users\User\Desktop\ModelListesi.xls");

        }
    }
}
