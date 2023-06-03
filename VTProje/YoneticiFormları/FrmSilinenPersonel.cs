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
    public partial class FrmSilinenPersonel : Form
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        public FrmSilinenPersonel()
        {
            InitializeComponent();
        }

        private void FrmSilinenPersonel_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From TblSilinenPersonel",baglan);


            DataTable dt1 = new DataTable();
            komut.Fill(dt1);

            gridControl1.DataSource = dt1;
            baglan.Close();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.ExportToXls(@"C:\Users\User\Desktop\SilinenPersoneller.xls");

        }
    }
}
