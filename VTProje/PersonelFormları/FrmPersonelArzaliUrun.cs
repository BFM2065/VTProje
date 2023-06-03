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
namespace VTProje.PersonelFormları
{
    public partial class FrmPersonelArzaliUrun : Form
    {
        public FrmPersonelArzaliUrun()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        void listele()
        {

            SqlDataAdapter cmd = new SqlDataAdapter("Select Urun,TblMusteri.Ad AS [Müşteri Adı],TblPersonel.Ad AS [Personel Adı],GelisTarihi,CikisTarihi From TblTSUrunKabul JOIN TblPersonel on TblTSUrunKabul.Personel=TblPersonel.ID JOIN TblMusteri on TblTSUrunKabul.Musteri=TblMusteri.ID ", baglan);
            DataTable dt1 = new DataTable();
            cmd.Fill(dt1);
            gridControl1.DataSource = dt1;
            baglan.Close();
        }
        private void FrmPersonelArzaliUrun_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,TblPersonel.ID From TblPersonel where DepartmanID in (2)", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Txtpersonel.Properties.ValueMember = "ID";  //alınacak veri 
            Txtpersonel.Properties.DisplayMember = "Ad";  //yerine getirilicek veri ID nin karşılığını veriyo ona göre
            Txtpersonel.Properties.DataSource = dt;
            listele();
           
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
   
            SqlCommand komut = new SqlCommand("Insert into TblMusteri (Ad,Soyad,Mail,Telefon,Adres,MDurum) values (@a,@b,@c,@d,@e,@f) ; SET @prmYeniId = SCOPE_IDENTITY()", baglan);




            komut.Parameters.AddWithValue("@a", TxtMAdi.Text);
            komut.Parameters.AddWithValue("@b", TxtMsoyadi.Text);
            komut.Parameters.AddWithValue("@c", TxtMail.Text);
            komut.Parameters.AddWithValue("@d", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@e", TxtAdres.Text);
            komut.Parameters.AddWithValue("@f", false);
            komut.Parameters.Add("@prmYeniId", SqlDbType.Int).Direction = ParameterDirection.Output;
            baglan.Open();
            komut.ExecuteScalar();
            int YeniId = (int)komut.Parameters["@prmYeniId"].Value;
            baglan.Close();





            SqlCommand komut1 = new SqlCommand("Insert into TblTSUrunKabul (Urun,Musteri,Personel,GelisTarihi,CikisTarihi) values (@a,@b,@c,@d,@e)", baglan);

            baglan.Open();


            komut1.Parameters.AddWithValue("@a",TxtUrunK.Text);
            komut1.Parameters.AddWithValue("@b", YeniId);
            komut1.Parameters.AddWithValue("@c",Txtpersonel.EditValue);
            komut1.Parameters.AddWithValue("@d", TxtKT.DateTime);
            komut1.Parameters.AddWithValue("@e", TxtTT.DateTime);

            komut1.ExecuteNonQuery();
            baglan.Close();
            listele();

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * From TblTSUrunKabul", baglan);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();

        }
    }
}
