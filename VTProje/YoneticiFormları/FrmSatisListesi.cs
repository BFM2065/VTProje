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
    public partial class FrmSatisListesi : Form
    {
        public FrmSatisListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        private void FrmSatisListesi_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select SatisID,TblPersonel.Ad AS [Personel Adı],TblMusteri.Ad AS [Müşteri Adı],UrunID,Tarih,Adet From TblSatis JOIN TblPersonel on TblSatis.PersonelID=TblPersonel.ID JOIN TblMusteri on TblSatis.MusteriID=TblMusteri.ID", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ExportToXls(@"C:\Users\User\Desktop\SatisListesi.xls");
        }
    }
}
