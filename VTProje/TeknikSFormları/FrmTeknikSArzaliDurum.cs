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

namespace VTProje.TeknikSFormları
{
    public partial class FrmTeknikSArzaliDurum : Form
    {
        public FrmTeknikSArzaliDurum()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        void listele()
        {
            baglan.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("Select ArizaID,TblTSUrunKabul.Urun,Sorun,OnFiyat,NetFiyat,Islemler from TblArizaDetay JOIN TblTSUrunKabul on TblArizaDetay.IslemID=TblTSUrunKabul.IslemID", baglan);
            DataTable dt1 = new DataTable();
            cmd.Fill(dt1);
            gridControl1.DataSource = dt1;
            baglan.Close();

           
        }
       

        private void FrmTeknikSArzaliDurum_Load(object sender, EventArgs e)
        {
            listele();
        }

        

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textEdit1.Text = gridView1.GetFocusedRowCellValue("ArizaID").ToString();
            TxtUrunAdi.Text = gridView1.GetFocusedRowCellValue("Urun").ToString();
            TxtSorun.Text = gridView1.GetFocusedRowCellValue("Sorun").ToString();
            TxtOnF.Text = gridView1.GetFocusedRowCellValue("OnFiyat").ToString();
            TxtxNetF.Text = gridView1.GetFocusedRowCellValue("NetFiyat").ToString();
            TxtIslem.Text = gridView1.GetFocusedRowCellValue("Islemler").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update TblArizaDetay set Sorun=@c,OnFiyat=@d,NetFiyat=@e,Islemler=@f where ArizaID='"+textEdit1.Text+"'", baglan);
        
      
            komut.Parameters.AddWithValue("@c", TxtSorun.Text);
            komut.Parameters.AddWithValue("@d",Convert.ToDecimal(TxtOnF.Text));
            komut.Parameters.AddWithValue("@e", Convert.ToDecimal(TxtxNetF.Text));
            komut.Parameters.AddWithValue("@f", TxtIslem.Text);

            komut.ExecuteNonQuery();
            baglan.Close();
            listele();
        }
    }
}
