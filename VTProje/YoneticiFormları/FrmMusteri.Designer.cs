﻿
namespace VTProje.YoneticiFormları
{
    partial class FrmMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteri));
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnList = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtMsoyadi = new DevExpress.XtraEditors.TextEdit();
            this.TxtMAdi = new DevExpress.XtraEditors.TextEdit();
            this.TxtAdres = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMsoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(1604, 586);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(176, 51);
            this.BtnGuncelle.TabIndex = 46;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(1364, 586);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(176, 51);
            this.BtnSil.TabIndex = 45;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnEkle.Appearance.Options.UseFont = true;
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(1604, 493);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(176, 51);
            this.BtnEkle.TabIndex = 44;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnList
            // 
            this.BtnList.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.BtnList.Appearance.Options.UseFont = true;
            this.BtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnList.ImageOptions.Image")));
            this.BtnList.Location = new System.Drawing.Point(1364, 493);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(176, 51);
            this.BtnList.TabIndex = 43;
            this.BtnList.Text = "Listelle";
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(972, 774);
            this.gridControl1.TabIndex = 39;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(1309, 68);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(113, 27);
            this.labelControl7.TabIndex = 65;
            this.labelControl7.Text = "Müşteri No:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(1443, 65);
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Size = new System.Drawing.Size(308, 34);
            this.TxtID.TabIndex = 64;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(1370, 265);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(52, 27);
            this.labelControl6.TabIndex = 62;
            this.labelControl6.Text = "Maili:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1242, 327);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(180, 27);
            this.labelControl5.TabIndex = 60;
            this.labelControl5.Text = "Telefon Numarası:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1359, 392);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 27);
            this.labelControl4.TabIndex = 61;
            this.labelControl4.Text = "Adres:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1350, 195);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 27);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Soyadı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1377, 125);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 27);
            this.labelControl1.TabIndex = 57;
            this.labelControl1.Text = " Adı:";
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(1443, 324);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtTelefon.Properties.Appearance.Options.UseFont = true;
            this.TxtTelefon.Size = new System.Drawing.Size(308, 34);
            this.TxtTelefon.TabIndex = 55;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(1443, 258);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Size = new System.Drawing.Size(308, 34);
            this.TxtMail.TabIndex = 54;
            // 
            // TxtMsoyadi
            // 
            this.TxtMsoyadi.Location = new System.Drawing.Point(1443, 192);
            this.TxtMsoyadi.Name = "TxtMsoyadi";
            this.TxtMsoyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtMsoyadi.Properties.Appearance.Options.UseFont = true;
            this.TxtMsoyadi.Size = new System.Drawing.Size(308, 34);
            this.TxtMsoyadi.TabIndex = 53;
            // 
            // TxtMAdi
            // 
            this.TxtMAdi.Location = new System.Drawing.Point(1443, 122);
            this.TxtMAdi.Name = "TxtMAdi";
            this.TxtMAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtMAdi.Properties.Appearance.Options.UseFont = true;
            this.TxtMAdi.Size = new System.Drawing.Size(308, 34);
            this.TxtMAdi.TabIndex = 52;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(1443, 389);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtAdres.Properties.Appearance.Options.UseFont = true;
            this.TxtAdres.Size = new System.Drawing.Size(308, 34);
            this.TxtAdres.TabIndex = 66;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1475, 686);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 51);
            this.simpleButton1.TabIndex = 73;
            this.simpleButton1.Text = "Yazdır";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 775);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtMsoyadi);
            this.Controls.Add(this.TxtMAdi);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMusteri";
            this.Text = "FrmMusteri";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMsoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.SimpleButton BtnList;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtTelefon;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.TextEdit TxtMsoyadi;
        private DevExpress.XtraEditors.TextEdit TxtMAdi;
        private DevExpress.XtraEditors.TextEdit TxtAdres;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}