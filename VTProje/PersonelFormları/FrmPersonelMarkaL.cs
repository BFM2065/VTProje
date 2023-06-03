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
    public partial class FrmPersonelMarkaL : Form
    {
        public FrmPersonelMarkaL()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-FU1QCVM4;Initial Catalog=VTProje;Integrated Security=True");
        void listele()
        {
            baglan.Open();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From TblMarka where TblMarka.Durum in (1)", baglan);
            DataTable dt = new DataTable();
            komut.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }
        private void FrmPersonelMarkaL_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
