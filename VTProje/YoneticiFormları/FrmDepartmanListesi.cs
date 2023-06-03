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
    public partial class FrmDepartmanListesi : Form
    {
        public FrmDepartmanListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        private void FrmDepartmanListesi_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select TblDepartman.ID,TblPersonel.Ad From TblDepartman JOIN TblPersonel on TblDepartman.ID= TblPersonel.DepartmanID  where TblDepartman.ID in (1)", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;
            SqlDataAdapter komut1 = new SqlDataAdapter("Select TblDepartman.ID,TblPersonel.Ad From TblDepartman JOIN TblPersonel on TblDepartman.ID= TblPersonel.DepartmanID  where TblDepartman.ID in (2)", baglan);
            DataTable dt1 = new DataTable();
            komut1.Fill(dt1);
            gridControl2.DataSource = dt1;
            baglan.Close();
        }
    }
}
