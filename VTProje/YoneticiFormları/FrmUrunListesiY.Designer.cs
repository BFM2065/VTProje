
namespace VTProje.YoneticiFormları
{
    partial class FrmUrunListesiY
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListesiY));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnUrunL = new DevExpress.XtraEditors.SimpleButton();
            this.TxtUrun = new DevExpress.XtraEditors.TextEdit();
            this.BtnUrunD = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMasaustuU = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDizustuU = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrun.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1455, 772);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // BtnUrunL
            // 
            this.BtnUrunL.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnUrunL.Appearance.Options.UseFont = true;
            this.BtnUrunL.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUrunL.ImageOptions.SvgImage")));
            this.BtnUrunL.Location = new System.Drawing.Point(1566, 347);
            this.BtnUrunL.Name = "BtnUrunL";
            this.BtnUrunL.Size = new System.Drawing.Size(308, 49);
            this.BtnUrunL.TabIndex = 1;
            this.BtnUrunL.Text = "Tüm Ürünleri Listele";
            this.BtnUrunL.Click += new System.EventHandler(this.BtnUrunL_Click);
            // 
            // TxtUrun
            // 
            this.TxtUrun.Enabled = false;
            this.TxtUrun.Location = new System.Drawing.Point(1566, 197);
            this.TxtUrun.Name = "TxtUrun";
            this.TxtUrun.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtUrun.Properties.Appearance.Options.UseFont = true;
            this.TxtUrun.Size = new System.Drawing.Size(308, 34);
            this.TxtUrun.TabIndex = 3;
            // 
            // BtnUrunD
            // 
            this.BtnUrunD.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnUrunD.Appearance.Options.UseFont = true;
            this.BtnUrunD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnUrunD.ImageOptions.SvgImage")));
            this.BtnUrunD.Location = new System.Drawing.Point(1566, 264);
            this.BtnUrunD.Name = "BtnUrunD";
            this.BtnUrunD.Size = new System.Drawing.Size(308, 49);
            this.BtnUrunD.TabIndex = 4;
            this.BtnUrunD.Text = "Ürün Detay";
            this.BtnUrunD.Click += new System.EventHandler(this.BtnUrunD_Click);
            // 
            // BtnMasaustuU
            // 
            this.BtnMasaustuU.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnMasaustuU.Appearance.Options.UseFont = true;
            this.BtnMasaustuU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnMasaustuU.ImageOptions.SvgImage")));
            this.BtnMasaustuU.Location = new System.Drawing.Point(1566, 430);
            this.BtnMasaustuU.Name = "BtnMasaustuU";
            this.BtnMasaustuU.Size = new System.Drawing.Size(308, 49);
            this.BtnMasaustuU.TabIndex = 5;
            this.BtnMasaustuU.Text = "Masaüstü Ürünleri Listele";
            this.BtnMasaustuU.Click += new System.EventHandler(this.BtnMasaustuU_Click);
            // 
            // BtnDizustuU
            // 
            this.BtnDizustuU.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BtnDizustuU.Appearance.Options.UseFont = true;
            this.BtnDizustuU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnDizustuU.ImageOptions.SvgImage")));
            this.BtnDizustuU.Location = new System.Drawing.Point(1566, 510);
            this.BtnDizustuU.Name = "BtnDizustuU";
            this.BtnDizustuU.Size = new System.Drawing.Size(308, 49);
            this.BtnDizustuU.TabIndex = 6;
            this.BtnDizustuU.Text = "Dizüstü Ürünleri Listele";
            this.BtnDizustuU.Click += new System.EventHandler(this.BtnDizustuU_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1566, 592);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(308, 51);
            this.simpleButton1.TabIndex = 74;
            this.simpleButton1.Text = "Yazdır";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmUrunListesiY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 775);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnDizustuU);
            this.Controls.Add(this.BtnMasaustuU);
            this.Controls.Add(this.BtnUrunD);
            this.Controls.Add(this.TxtUrun);
            this.Controls.Add(this.BtnUrunL);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunListesiY";
            this.Text = "UrunListesiY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUrunListesiY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUrun.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnUrunL;
        private DevExpress.XtraEditors.TextEdit TxtUrun;
        private DevExpress.XtraEditors.SimpleButton BtnUrunD;
        private DevExpress.XtraEditors.SimpleButton BtnMasaustuU;
        private DevExpress.XtraEditors.SimpleButton BtnDizustuU;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}