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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        void listele()
        {
            //prosedür kullanımı burda 
            baglan.Open();
            SqlCommand komut = new SqlCommand("Liste", baglan);
            komut.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataSet dt = new DataSet();
         
           dr.Fill(dt,"TblPersonel");

          gridControl1.DataSource = dt.Tables[0];
            baglan.Close();
            /*  SqlDataAdapter da = new SqlDataAdapter("Select ModelAdi,ID From TbLModel", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lookUpEdit3.Properties.ValueMember = "ID";//alınacak veri 
            lookUpEdit3.Properties.DisplayMember = "ModelAdi";//yerine getirilicek veri ID nin karşılığını veriyo ona göre
            lookUpEdit3.Properties.DataSource = dt;*/
        }
        //Select DepAdi,TblPersonel.ID From TblPersonel JOIN TblDepartman on TblPersonel.DepartmanID=TblDepartman.ID
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listele();
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select DepAdi,ID From TblDepartman", baglan);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            TxtDepartman.Properties.ValueMember = "ID";//alınacak veri 
            TxtDepartman.Properties.DisplayMember = "DepAdi";//yerine getirilicek veri ID nin karşılığını veriyo ona göre
            TxtDepartman.Properties.DataSource = dt1;
            baglan.Close();

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                TxtPersonelAdi.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
                TxtPsoyadi.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
                TxtTC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
                TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
                TxtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
                TxtDepartman.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Hata");
                listele();
            }
        
           
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TblPersonel (Ad,Soyad,Mail,Telefon,TblPersonel.DepartmanID,TC) values (@a,@b,@c,@d,@e,@f) ", baglan);
            
                baglan.Open();
                komut.Parameters.AddWithValue("@a",TxtPersonelAdi.Text);
                komut.Parameters.AddWithValue("@b",TxtPsoyadi.Text);
                komut.Parameters.AddWithValue("@c",TxtMail.Text);
                komut.Parameters.AddWithValue("@d", TxtTelefon.Text);
                komut.Parameters.AddWithValue("@e", TxtDepartman.EditValue);
                komut.Parameters.AddWithValue("@f", TxtTC.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                listele();
            

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblPersonel set Ad=@b,Soyad=@c,Mail=@d,Telefon=@e,DepartmanID=@f,TC=@g Where ID=@a", baglan);
            komut.Parameters.AddWithValue("@a", TxtID.Text);
            komut.Parameters.AddWithValue("@f", TxtDepartman.EditValue);
            komut.Parameters.AddWithValue("@b", TxtPersonelAdi.Text);
            komut.Parameters.AddWithValue("@c", TxtPsoyadi.Text);
            komut.Parameters.AddWithValue("@d", TxtMail.Text);
            komut.Parameters.AddWithValue("@e", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@g", TxtTC.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from TblPersonel where ID=(" + TxtID.Text + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
            MessageBox.Show("Personel Başarıyla Silinmiştir...");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            gridView1.ExportToXls(@"C:\Users\User\Desktop\Personel.xls");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            
                baglan.Open();
                SqlCommand komut = new SqlCommand("SP_TCarama", baglan);
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@arananDeger", TxtTCArama.Text);
                SqlDataAdapter dr = new SqlDataAdapter(komut);
                DataSet dt = new DataSet();

                dr.Fill(dt, "TblPersonel");

                gridControl1.DataSource = dt.Tables[0];
                baglan.Close();

            
            
            
        }
    }
}
