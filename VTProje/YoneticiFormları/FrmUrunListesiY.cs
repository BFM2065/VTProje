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
    public partial class FrmUrunListesiY : Form
    {
        public FrmUrunListesiY()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        void Urunler()
        {
            /* VTProjeEntities db = new VTProjeEntities();

             var degerler = from x in db.TblModel
                            select new
                            {
                                x.ModelAdi,
                                Marka = x.TblMarka.Adi,
                                Kategori = x.TblKategori.Kategori

                            };

         

            gridControl1.DataSource = degerler.ToList();   */
            baglan.Open();
            // object numara = gridView1.GetFocusedRowCellValue("ID");
            SqlDataAdapter komut = new SqlDataAdapter("Select TblModel.ID, ModelAdi AS [Model Adı],TblMarka.Adi AS [Marka Adı],Kategori AS [Kategori] From TblModel JOIN TblMarka on TblModel.MarkaID=TblMarka.ID JOIN TblKategori on TblModel.KategoriID=TblKategori.ID where TblModel.DurumModel in (1)", baglan);


           // SqlDataAdapter komut = new SqlDataAdapter("Select ModelAdi,MarkaID,KategoriID from TblModel",baglan);
            DataTable dt = new DataTable();         //  "Select ogrenci.ogrno, ograd,ogrsoyad,kitapadi,sayfasayisi,atarih,vtarih from ogrenci join islem on ogrenci.ogrno = islem.ogrno join kitap on kitap.kitapno = islem.kitapno";
            komut.Fill(dt);
          
          
        
            //da = new SqlDataAdapter("Select Ogrenci.ogrno AS NUMARA,ograd AS AD,ogrsoyad AS SOYAD,kitapad AS [KİTAP ADI],halis AS [ALIŞ TARİHİ],hteslim AS [TESLİMTARİHİ] FROM Ogrenci JOIN Hareket on Ogrenci.ogrno=Hareket.hogr JOIN Kitap on Kitap.ktpno=Hareket.hkitap WHERE Ogrenci.ogrno=" + numara, con);
        

            gridControl1.DataSource = dt;
            baglan.Close();



        }
        private void FrmUrunListesiY_Load(object sender, EventArgs e)
        {

            Urunler();
        }

       

       private void gridControl1_MouseClick(object sender, MouseEventArgs e)
       {
         
            TxtUrun.Text = gridView1.GetFocusedRowCellValue("Model Adı").ToString();

              
       }

        private void BtnUrunL_Click(object sender, EventArgs e)
        {
            Urunler();
        }

        private void BtnMasaustuU_Click(object sender, EventArgs e)
        {


            baglan.Open();

            SqlDataAdapter komut = new SqlDataAdapter("Select TblModel.ID, ModelAdi AS [Model Adı],TblMarka.Adi AS [Marka Adı],Kategori AS [Kategori] From TblModel JOIN TblMarka on TblModel.MarkaID=TblMarka.ID JOIN TblKategori on TblModel.KategoriID=TblKategori.ID where KategoriID in (1) and TblModel.DurumModel in (1)", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();


            
        }

        private void BtnDizustuU_Click(object sender, EventArgs e)
        {
            /*  VTProjeEntities db = new VTProjeEntities();
              var degerler = from x in db.TblModel
                             select new
                             {
                                 x.ModelAdi,
                                 Marka = x.TblMarka.Adi,
                                 Kategori = x.TblKategori.Kategori

                             };



              gridControl1.DataSource = degerler.Where(x => x.Kategori == "Dizüstü").ToList();*/

            baglan.Open();

            SqlDataAdapter komut = new SqlDataAdapter("Select TblModel.ID, ModelAdi AS [Model Adı],TblMarka.Adi AS [Marka Adı],Kategori AS [Kategori] From TblModel JOIN TblMarka on TblModel.MarkaID=TblMarka.ID JOIN TblKategori on TblModel.KategoriID=TblKategori.ID where KategoriID in (2) and TblModel.DurumModel in (1)", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();

        }

        private void BtnUrunD_Click(object sender, EventArgs e)
        {
           if (TxtUrun!=null)
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);


                //dr[0].ToString();

                YoneticiFormları.UrunDetay frmdetay = new UrunDetay();
                frmdetay.A = TxtUrun.Text;
                
                frmdetay.Show();
            }
           

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ExportToXls(@"C:\Users\User\Desktop\UrunListesi.xls");

        }
    }
}
