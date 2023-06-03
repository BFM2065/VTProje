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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmUrunListesiY frm = new YoneticiFormları.FrmUrunListesiY();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelFormları.FrmPersonelMarkaL frm2 = new PersonelFormları.FrmPersonelMarkaL();
          
            frm2.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelFormları.FrmPersonelSatis frm3 = new PersonelFormları.FrmPersonelSatis();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelFormları.FrmPersonelMusteriL frm4 = new PersonelFormları.FrmPersonelMusteriL();
            frm4.MdiParent = this;
            frm4.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelFormları.FrmPersonelTeknikSMuster frm5 = new PersonelFormları.FrmPersonelTeknikSMuster();
            frm5.MdiParent = this;
            frm5.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelFormları.FrmPersonelArzaliUrun frm6 = new PersonelFormları.FrmPersonelArzaliUrun();
            frm6.MdiParent = this;
            frm6.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelFormları.FrmPersonelTSDurum frm6 = new PersonelFormları.FrmPersonelTSDurum();
        
            frm6.Show();
        }
    }
}
