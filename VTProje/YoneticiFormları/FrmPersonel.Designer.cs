
namespace VTProje.YoneticiFormları
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnList = new DevExpress.XtraEditors.SimpleButton();
            this.TxtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtPsoyadi = new DevExpress.XtraEditors.TextEdit();
            this.TxtPersonelAdi = new DevExpress.XtraEditors.TextEdit();
            this.TxtTC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDepartman = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.TxtTCArama = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPsoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTCArama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(889, 776);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(1367, 585);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(176, 51);
            this.BtnGuncelle.TabIndex = 38;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(1127, 585);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(176, 51);
            this.BtnSil.TabIndex = 37;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(1367, 492);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(176, 51);
            this.BtnEkle.TabIndex = 36;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnList
            // 
            this.BtnList.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnList.Appearance.Options.UseFont = true;
            this.BtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnList.ImageOptions.Image")));
            this.BtnList.Location = new System.Drawing.Point(1127, 492);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(176, 51);
            this.BtnList.TabIndex = 35;
            this.BtnList.Text = "Listelle";
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(1225, 287);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtTelefon.Properties.Appearance.Options.UseFont = true;
            this.TxtTelefon.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtTelefon.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TxtTelefon.Properties.MaskSettings.Set("mask", "d");
            this.TxtTelefon.Size = new System.Drawing.Size(308, 34);
            this.TxtTelefon.TabIndex = 42;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(1225, 345);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Size = new System.Drawing.Size(308, 34);
            this.TxtMail.TabIndex = 41;
            // 
            // TxtPsoyadi
            // 
            this.TxtPsoyadi.Location = new System.Drawing.Point(1225, 173);
            this.TxtPsoyadi.Name = "TxtPsoyadi";
            this.TxtPsoyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtPsoyadi.Properties.Appearance.Options.UseFont = true;
            this.TxtPsoyadi.Size = new System.Drawing.Size(308, 34);
            this.TxtPsoyadi.TabIndex = 40;
            // 
            // TxtPersonelAdi
            // 
            this.TxtPersonelAdi.Location = new System.Drawing.Point(1225, 103);
            this.TxtPersonelAdi.Name = "TxtPersonelAdi";
            this.TxtPersonelAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtPersonelAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtPersonelAdi.Size = new System.Drawing.Size(308, 34);
            this.TxtPersonelAdi.TabIndex = 39;
            // 
            // TxtTC
            // 
            this.TxtTC.Location = new System.Drawing.Point(1225, 232);
            this.TxtTC.Name = "TxtTC";
            this.TxtTC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtTC.Properties.Appearance.Options.UseFont = true;
            this.TxtTC.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtTC.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TxtTC.Properties.MaskSettings.Set("mask", "d");
            this.TxtTC.Properties.MaxLength = 11;
            this.TxtTC.Size = new System.Drawing.Size(308, 34);
            this.TxtTC.TabIndex = 44;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1159, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 27);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = " Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1170, 235);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 27);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "TC:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1132, 176);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 27);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "Soyadı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1083, 409);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(121, 27);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "Departmanı:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1024, 290);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(180, 27);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "Telefon Numarası:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(1152, 348);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 27);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "Maili:";
            // 
            // TxtDepartman
            // 
            this.TxtDepartman.EditValue = "";
            this.TxtDepartman.Location = new System.Drawing.Point(1225, 406);
            this.TxtDepartman.Name = "TxtDepartman";
            this.TxtDepartman.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtDepartman.Properties.Appearance.Options.UseFont = true;
            this.TxtDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtDepartman.Size = new System.Drawing.Size(308, 34);
            this.TxtDepartman.TabIndex = 49;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(1079, 53);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(125, 27);
            this.labelControl7.TabIndex = 51;
            this.labelControl7.Text = "Personel No:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(1225, 46);
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Size = new System.Drawing.Size(308, 34);
            this.TxtID.TabIndex = 50;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(1245, 684);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 51);
            this.simpleButton1.TabIndex = 52;
            this.simpleButton1.Text = "Yazdır";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TxtTCArama
            // 
            this.TxtTCArama.Location = new System.Drawing.Point(1585, 103);
            this.TxtTCArama.Name = "TxtTCArama";
            this.TxtTCArama.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtTCArama.Properties.Appearance.Options.UseFont = true;
            this.TxtTCArama.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TxtTCArama.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TxtTCArama.Properties.MaskSettings.Set("mask", "d");
            this.TxtTCArama.Properties.MaxLength = 11;
            this.TxtTCArama.Size = new System.Drawing.Size(308, 34);
            this.TxtTCArama.TabIndex = 53;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(1653, 164);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(176, 51);
            this.simpleButton2.TabIndex = 54;
            this.simpleButton2.Text = "Arama";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(1672, 53);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(162, 27);
            this.labelControl8.TabIndex = 55;
            this.labelControl8.Text = "TC \'ye Göre ara:";
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 775);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.TxtTCArama);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtDepartman);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtTC);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtPsoyadi);
            this.Controls.Add(this.TxtPersonelAdi);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPsoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPersonelAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTCArama.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.SimpleButton BtnList;
        private DevExpress.XtraEditors.TextEdit TxtTelefon;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.TextEdit TxtPsoyadi;
        private DevExpress.XtraEditors.TextEdit TxtPersonelAdi;
        private DevExpress.XtraEditors.TextEdit TxtTC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit TxtDepartman;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit TxtTCArama;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}