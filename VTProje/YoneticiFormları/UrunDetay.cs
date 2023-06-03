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
    public partial class UrunDetay : Form
    {
        public UrunDetay()
        {
            InitializeComponent();
        }
        public string A,b,c,d,e;
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        private void UrunDetay_Load(object sender, EventArgs e)
        {
           // TxtModelAdi.Text = a;
            /*
            VTProjeEntities db = new VTProjeEntities();
            var deger = db.TblModel.Where(x => x.ModelAdi == TxtModelAdi.Text).First();

            TxtMarka.Text = deger.TblMarka.Adi;
            TxtAlısf.Text = deger.AlisFiyati.ToString();
            TxtSatısf.Text = deger.SatisFiyati.ToString();
            TxtKategori.Text = deger.TblKategori.Kategori;
            TxtOzellik.Text = deger.Ozellikleri;*/

            baglan.Open();
            /*
              
             
            SqlDataAdapter komut = new SqlDataAdapter("Select * from TblModel where ModelAdi in a", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);*/

            //,MarkaID,AlisFiyati,SatisFiyati,KategoriID,Ozellikleri
   
            SqlCommand cmd2 = new SqlCommand("Select * From TblModel Where ModelAdi like '"+A+"'", baglan);
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                TxtModelAdi.Text = dr[1].ToString();
               TxtMarka.Text = dr[2].ToString();
                TxtAlısf.Text = dr[4].ToString();
                TxtSatısf.Text=dr[5].ToString();
                TxtKategori.Text= dr[6].ToString();
                TxtOzellik.Text = dr[3].ToString();
            }
            dr.Close();
            SqlCommand cmd3 = new SqlCommand("Select * From TblMarka Where ID like '" +TxtMarka.Text+ "'", baglan);
            SqlDataReader dr1 = cmd3.ExecuteReader();
            while (dr1.Read())
            {
                TxtMarka.Text = dr1[1].ToString();
            }
            dr1.Close();
            SqlCommand cmd4 = new SqlCommand("Select * From TblKategori Where ID like '" + TxtKategori.Text+ "'", baglan);
            SqlDataReader dr3 = cmd4.ExecuteReader();
            while (dr3.Read())
            {
                TxtKategori.Text = dr3[1].ToString();
            }
            dr3.Close();
            baglan.Close();


            /* TxtMarka.Text =d
             TxtAlısf.Text =
             TxtSatısf.Text
             TxtKategori.Text=
             TxtOzellik.Text=*/



        }
    }
}     
    
