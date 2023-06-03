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
    public partial class FrmSilinenMusteri : Form
    {
        public FrmSilinenMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        private void FrmSilinenMusteri_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From TblSilinenMusteriler", baglan);


            DataTable dt1 = new DataTable();
            komut.Fill(dt1);

            gridControl1.DataSource = dt1;
            baglan.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ExportToXls(@"C:\Users\User\Desktop\SilinenMusteriler.xls");

        }
    }
}
