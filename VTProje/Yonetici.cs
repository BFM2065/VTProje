using DevExpress.Utils.CommonDialogs.Internal;
using Microsoft.SqlServer.Management.Smo;
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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmUrunListesiY frm = new YoneticiFormları.FrmUrunListesiY();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.UrunIslemleri frm2 = new YoneticiFormları.UrunIslemleri();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmPersonel frm3 = new YoneticiFormları.FrmPersonel();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmSilinenPersonel frm4 = new YoneticiFormları.FrmSilinenPersonel();
            
            frm4.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmDepartmanListesi frm5 = new YoneticiFormları.FrmDepartmanListesi();
            frm5.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmMarkaListesi frm6 = new YoneticiFormları.FrmMarkaListesi();
            frm6.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmMusteri frm7 = new YoneticiFormları.FrmMusteri();
            frm7.MdiParent = this;
            frm7.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmSilinenMusteri frm8 = new YoneticiFormları.FrmSilinenMusteri();
            frm8.Show();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmModelIslemleri frm9 = new YoneticiFormları.FrmModelIslemleri();
            frm9.MdiParent = this;
            frm9.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmSatisListesi frm10 = new YoneticiFormları.FrmSatisListesi();
      
            frm10.Show();
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmYedekle frm11 = new YoneticiFormları.FrmYedekle();

            frm11.Show();
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmYedekDon frm12 = new YoneticiFormları.FrmYedekDon();

            frm12.Show();
        }

        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YoneticiFormları.FrmYetkilendirme frm13 = new YoneticiFormları.FrmYetkilendirme();
         
            frm13.Show();
        }
    }
}

