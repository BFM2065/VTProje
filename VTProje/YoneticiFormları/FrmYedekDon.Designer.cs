
namespace VTProje.YoneticiFormları
{
    partial class FrmYedekDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYedekDon));
            this.BtnYedekle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSec = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.TxtDatab = new DevExpress.XtraEditors.TextEdit();
            this.TxtServer = new DevExpress.XtraEditors.TextEdit();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDatab.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnYedekle
            // 
            this.BtnYedekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnYedekle.ImageOptions.Image")));
            this.BtnYedekle.Location = new System.Drawing.Point(340, 317);
            this.BtnYedekle.Name = "BtnYedekle";
            this.BtnYedekle.Size = new System.Drawing.Size(132, 57);
            this.BtnYedekle.TabIndex = 15;
            this.BtnYedekle.Text = "YÜKLE";
            this.BtnYedekle.Click += new System.EventHandler(this.BtnYedekle_Click);
            // 
            // BtnSec
            // 
            this.BtnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSec.ImageOptions.Image")));
            this.BtnSec.Location = new System.Drawing.Point(599, 236);
            this.BtnSec.Name = "BtnSec";
            this.BtnSec.Size = new System.Drawing.Size(75, 36);
            this.BtnSec.TabIndex = 14;
            this.BtnSec.Text = "...";
            this.BtnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(137, 241);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 27);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Path:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(87, 176);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 27);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "DataBase:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(87, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 27);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "SERVER:";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(214, 238);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Size = new System.Drawing.Size(369, 34);
            this.textEdit3.TabIndex = 10;
            // 
            // TxtDatab
            // 
            this.TxtDatab.EditValue = "VTProje";
            this.TxtDatab.Location = new System.Drawing.Point(214, 169);
            this.TxtDatab.Name = "TxtDatab";
            this.TxtDatab.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtDatab.Properties.Appearance.Options.UseFont = true;
            this.TxtDatab.Size = new System.Drawing.Size(460, 34);
            this.TxtDatab.TabIndex = 9;
            // 
            // TxtServer
            // 
            this.TxtServer.EditValue = ".";
            this.TxtServer.Location = new System.Drawing.Point(214, 98);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtServer.Properties.Appearance.Options.UseFont = true;
            this.TxtServer.Size = new System.Drawing.Size(460, 34);
            this.TxtServer.TabIndex = 8;
            // 
            // FrmYedekDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.BtnYedekle);
            this.Controls.Add(this.BtnSec);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.TxtDatab);
            this.Controls.Add(this.TxtServer);
            this.Name = "FrmYedekDon";
            this.Text = "FrmYedekDon";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDatab.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnYedekle;
        private DevExpress.XtraEditors.SimpleButton BtnSec;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit TxtDatab;
        private DevExpress.XtraEditors.TextEdit TxtServer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}