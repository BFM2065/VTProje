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
    public partial class UrunIslemleri : Form
    {
        public UrunIslemleri()
        {
            InitializeComponent();
        }
        VTProjeEntities db = new VTProjeEntities();
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        void listele ()
        {
            /*  var degerler = from x in db.TblUrun
                             select new
                             {
                                 ModelAdı = x.TblModel.ModelAdi,
                                 Marka = x.TblModel.TblMarka.Adi,
                                 AlışFiyatı = x.TblModel.AlisFiyati,
                                 SatışFiyatı = x.TblModel.SatisFiyati,
                                 Kategori = x.TblModel.TblKategori.Kategori,
                                 x.Stok,
                                 Özellikler = x.TblModel.Ozellikleri


                             };
              gridControl1.DataSource = degerler.ToList();
              var model = (from x in db.TblModel
                             select new
                             {
                                 x.ID,
                                 x.ModelAdi

                             }).ToList();
              lookUpEdit3.Properties.ValueMember = "ID";//alınacak veri 
              lookUpEdit3.Properties.DisplayMember = "ModelAdi";//yerine getirilicek veri ID nin karşılığını veriyo ona göre
              lookUpEdit3.Properties.DataSource = model;

               var kategor = (from x in db.TblKategori
                              select new
                              {
                                  x.ID,
                                  x.Kategori

                              }).ToList();
               lookUpEdit1.Properties.ValueMember = "ID";//alınacak veri 
               lookUpEdit1.Properties.DisplayMember = "Kategori";//yerine getirilicek veri ID nin karşılığını veriyo ona göre
               lookUpEdit1.Properties.DataSource = kategor;
               var marka = (from x in db.TblMarka
                             select new
                             {
                                 x.ID,
                                 x.Adi


                             }).ToList();
               lookUpEdit2.Properties.ValueMember = "ID";//alınacak veri 
               lookUpEdit2.Properties.DisplayMember = "Adi";//yerine getirilicek veri ID nin karşılığını veriyo ona göre
               lookUpEdit2.Properties.DataSource = marka;
               TblModel y = new TblModel();
               labelControl8.Text = y.ID.ToString();*/
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select ModelAdi,ID From TbLModel where DurumModel in (1)",baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lookUpEdit3.Properties.ValueMember = "ID";//alınacak veri 
            lookUpEdit3.Properties.DisplayMember = "ModelAdi";//yerine getirilicek veri ID nin karşılığını veriyo ona göre
            lookUpEdit3.Properties.DataSource = dt;
            baglan.Close();
            baglan.Open();
            //  SqlDataAdapter komut = new SqlDataAdapter("Select TblModel.ID, ModelAdi AS [Model Adı],TblMarka.Adi AS [Marka Adı],Kategori AS [Kategori],TblUrun.Stok From TblModel JOIN TblMarka on TblModel.MarkaID=TblMarka.ID JOIN TblKategori on TblModel.KategoriID=TblKategori.ID", baglan);


            SqlDataAdapter komut = new SqlDataAdapter("Select TblModel.ID, ModelAdi AS [Model Adı],TblMarka.Adi AS [Marka Adı],Kategori AS [Kategori],TblUrun.Stok From TblUrun JOIN TblModel on TblUrun.ModelID=TblModel.ID JOIN TblMarka on TblModel.MarkaID=TblMarka.ID JOIN TblKategori on TblModel.KategoriID=TblKategori.ID where TblUrun.Durum in (1)", baglan);

            DataTable dt1 = new DataTable();
            komut.Fill(dt1);

            gridControl1.DataSource = dt1;
            baglan.Close();



        }




        private void UrunIslemleri_Load(object sender, EventArgs e)
        {


            listele();


           
        }

      

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lookUpEdit3.Text = gridView1.GetFocusedRowCellValue("Model Adı").ToString();
     

            TxtSatok.Text = gridView1.GetFocusedRowCellValue("Stok").ToString();
       
        }

        private void BtnList_Click(object sender, EventArgs e)
        {

            listele();

        }
        bool durum = true;
        bool sil = true;
        bool kon = true;
        void kontrol()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From TblUrun where ModelID=@a ",baglan);
            komut.Parameters.AddWithValue("@a", lookUpEdit3.EditValue);
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
            SqlCommand cmd = new SqlCommand("Select * From TblUrun where Durum in (0)", baglan);
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
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            /*isPersonel t = new isPersonel();

            t.Ad = TxtAd.Text;
            t.Soyad = TxtSoyad.Text;
            t.Mail = TxyMail.Text;
            t.Telefon = TxtTel.Text;
            t.Gorsel = TxtGorsel.Text;

            t.Depertman = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Durum = true;
            db.isPersonel.Add(t);
            db.SaveChanges();
            personeller();
            TblUrun u = new TblUrun();
            TblModel m = new TblModel();
            
            m.ModelAdi=TxtModelAdi.Text;
            m.AlisFiyati = Convert.ToDecimal(TxtAlısf.Text);
            m.SatisFiyati = Convert.ToDecimal(TxtSatısf.Text);
            m.Kategori = int.Parse(lookUpEdit1.EditValue.ToString());
            m.MarkaID = Convert.ToInt16(lookUpEdit2.EditValue.ToString());            m.Ozellikleri = TxtOzellik.Text;

            db.TblModel.Add(m);
            db.SaveChanges();

            /*var deger = (from x in db.TblModel
                         select new
                         {
                             x.ID
                         }).OrderBy(x => x.ID).LastOrDefault();

            var lastColumn=db.TblModel.OrderBy(x => x.ID).LastOrDefault();
            u.ModelID = Convert.ToInt16(lastColumn);
            u.Stok = Convert.ToInt16(TxtSatok.Text);
            u.Durum = true;
            db.TblUrun.Add(u);
            db.SaveChanges();
          
            
            TblUrun u = new TblUrun();
            u.ModelID = (short)int.Parse(lookUpEdit3.EditValue.ToString());
            u.Stok = Convert.ToInt16(TxtSatok.Text);
            u.Durum = true;
            db.TblUrun.Add(u);
            db.SaveChanges();
            listele();*/
            SqlCommand komut = new SqlCommand("Insert into TblUrun (ModelID,Stok,Durum) values (@a,@b,@c)", baglan);
            kontrol();

            Silim();

            if (kon==true)
            {
                baglan.Open();
            

                komut.Parameters.AddWithValue("@a", lookUpEdit3.EditValue);
                komut.Parameters.AddWithValue("@b", TxtSatok.Text);
                komut.Parameters.AddWithValue("@c", durum);
                komut.ExecuteNonQuery();
                baglan.Close();
            }

     

             else if (kon==false && sil==false) 
             {
                baglan.Open();
                durum = true;
                SqlCommand komut2 = new SqlCommand("Update TblUrun set Durum=@c,Stok=@b Where ModelID=@a", baglan);
                komut2.Parameters.AddWithValue("@a", lookUpEdit3.EditValue);
                komut2.Parameters.AddWithValue("@c", durum);
                komut2.Parameters.AddWithValue("@b", TxtSatok.Text);
                komut2.ExecuteNonQuery();
                baglan.Close();
                listele();
        
                
             }


            else 
            {
                MessageBox.Show("Zaten Olan Bir Ürün Girdiniz");

            }





        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {


            if (TxtSatok.Text.Length<5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Update TblUrun set Stok=@b Where ModelID=@a", baglan);
                komut.Parameters.AddWithValue("@a", lookUpEdit3.EditValue);
                komut.Parameters.AddWithValue("@b", TxtSatok.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                listele();
            }
        
            else
            {

                MessageBox.Show("Belirlenen Stok Limitinden Fazla Bir Lİmit Girdiniz");


            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblUrun set Durum=@b Where ModelID=@a", baglan);
            komut.Parameters.AddWithValue("@a", lookUpEdit3.EditValue);
            komut.Parameters.AddWithValue("@b", false);
            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ExportToXls(@"C:\Users\User\Desktop\StokListesi.xls");

        }
    }


}
