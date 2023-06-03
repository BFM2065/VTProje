using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTProje
{
    public partial class TeknikServis : Form
    {
        public TeknikServis()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TeknikSFormları.FrmTeknikSListe frm2 = new TeknikSFormları.FrmTeknikSListe();

            frm2.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TeknikSFormları.FrmTeknikSArzaliDurum frm3 = new TeknikSFormları.FrmTeknikSArzaliDurum();
            frm3.MdiParent = this;
            frm3.Show();
        }
    }
}
