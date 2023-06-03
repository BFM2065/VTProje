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
    public partial class FrmTeknikSListe : Form
    {
        public FrmTeknikSListe()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        private void FrmTeknikSListe_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("Select Urun,TblMusteri.Ad AS [Müşteri Adı],TblPersonel.Ad AS [Personel Adı],GelisTarihi,CikisTarihi From TblTSUrunKabul JOIN TblPersonel on TblTSUrunKabul.Personel=TblPersonel.ID JOIN TblMusteri on TblTSUrunKabul.Musteri=TblMusteri.ID ", baglan);
            DataTable dt1 = new DataTable();
            cmd.Fill(dt1);
            gridControl1.DataSource = dt1;
            baglan.Close();
        }
    }
}
