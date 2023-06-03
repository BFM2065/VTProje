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
    public partial class FrmPersonelSatis : Form
    {
        public FrmPersonelSatis()
        {
            InitializeComponent();
        }

        private void FrmPersonelSatis_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Ad,Soyad,TblPersonel.ID From TblPersonel where DepartmanID in (1)", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";  //alınacak veri 
            lookUpEdit1.Properties.DisplayMember = "Ad";  //yerine getirilicek veri ID nin karşılığını veriyo ona göre
            lookUpEdit1.Properties.DataSource = dt;
            baglan.Close();
            baglan.Open();
           
            SqlDataAdapter da1 = new SqlDataAdapter("Select ModelAdi,ID From TbLModel", baglan);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            lookUpEdit2.Properties.ValueMember = "ID";//alınacak veri 
            lookUpEdit2.Properties.DisplayMember = "ModelAdi";//yerine getirilicek veri ID nin karşılığını veriyo ona göre
            lookUpEdit2.Properties.DataSource = dt1;
            baglan.Close(); 



          



        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        private void BtnList_Click(object sender, EventArgs e)
        {
           


            SqlCommand komut = new SqlCommand("Insert into TblMusteri (Ad,Soyad,Mail,Telefon,Adres,MDurum) values (@a,@b,@c,@d,@e,@f) ; SET @prmYeniId = SCOPE_IDENTITY()", baglan);

            


            komut.Parameters.AddWithValue("@a", TxtMAdi.Text);
            komut.Parameters.AddWithValue("@b", TxtMsoyadi.Text);
            komut.Parameters.AddWithValue("@c", TxtMail.Text);
            komut.Parameters.AddWithValue("@d", TxtTelefon.Text);
            komut.Parameters.AddWithValue("@e", TxtAdres.Text);
            komut.Parameters.AddWithValue("@f", true);
            komut.Parameters.Add("@prmYeniId", SqlDbType.Int).Direction = ParameterDirection.Output;
            baglan.Open();
            komut.ExecuteScalar();
            int YeniId = (int)komut.Parameters["@prmYeniId"].Value;
            baglan.Close();




            //Satış Kayıt

           



            SqlCommand komut1 = new SqlCommand("Insert into TblSatis (PersonelID,MusteriID,UrunID,Tarih,Adet) values (@a,@b,@c,@d,@e)", baglan);

            baglan.Open();


            komut1.Parameters.AddWithValue("@a",lookUpEdit1.EditValue);
            komut1.Parameters.AddWithValue("@b", YeniId) ;
            komut1.Parameters.AddWithValue("@c", lookUpEdit2.EditValue);
            komut1.Parameters.AddWithValue("@d", TxtTarih.DateTime);
            komut1.Parameters.AddWithValue("@e", TxtAdet.Text);

            komut1.ExecuteNonQuery();
            baglan.Close();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();


            SqlCommand cmd2 = new SqlCommand("select SatisFiyati from TblModel where ID=@a", baglan);
            cmd2.Parameters.AddWithValue("@a", lookUpEdit2.EditValue);
            SqlDataReader dr = cmd2.ExecuteReader();
            decimal a = Convert.ToInt32(TxtAdet.Text);
            if (dr.Read())
            {
                TxtFiyat.Text = (Convert.ToDecimal(dr["SatisFiyati"]) * a).ToString();
            }


            baglan.Close();

        }
    }
}
