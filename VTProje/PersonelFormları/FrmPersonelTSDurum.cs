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
    public partial class FrmPersonelTSDurum : Form
    {
        public FrmPersonelTSDurum()
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

        private void FrmPersonelTSDurum_Load(object sender, EventArgs e)
        {
            listele();
        }




    }
}
