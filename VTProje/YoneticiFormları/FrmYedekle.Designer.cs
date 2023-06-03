
namespace VTProje.YoneticiFormları
{
    partial class FrmYedekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYedekle));
            this.TxtServer = new DevExpress.XtraEditors.TextEdit();
            this.TxtDatab = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnYedekle = new DevExpress.XtraEditors.SimpleButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TxtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDatab.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtServer
            // 
            this.TxtServer.EditValue = ".";
            this.TxtServer.Location = new System.Drawing.Point(184, 54);
            this.TxtServer.Name = "TxtServer";
            this.TxtServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtServer.Properties.Appearance.Options.UseFont = true;
            this.TxtServer.Size = new System.Drawing.Size(460, 34);
            this.TxtServer.TabIndex = 0;
            this.TxtServer.EditValueChanged += new System.EventHandler(this.TxtServer_EditValueChanged);
            // 
            // TxtDatab
            // 
            this.TxtDatab.EditValue = "VTProje";
            this.TxtDatab.Location = new System.Drawing.Point(184, 125);
            this.TxtDatab.Name = "TxtDatab";
            this.TxtDatab.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.TxtDatab.Properties.Appearance.Options.UseFont = true;
            this.TxtDatab.Size = new System.Drawing.Size(460, 34);
            this.TxtDatab.TabIndex = 1;
            this.TxtDatab.EditValueChanged += new System.EventHandler(this.TxtDatab_EditValueChanged);
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(184, 194);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Size = new System.Drawing.Size(406, 34);
            this.textEdit3.TabIndex = 2;
            this.textEdit3.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 27);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "SERVER:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(57, 132);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 27);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "DataBase:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(107, 197);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 27);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Path:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // BtnSec
            // 
            this.BtnSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnSec.Location = new System.Drawing.Point(606, 192);
            this.BtnSec.Name = "BtnSec";
            this.BtnSec.Size = new System.Drawing.Size(77, 36);
            this.BtnSec.TabIndex = 6;
            this.BtnSec.Text = "...";
            this.BtnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // BtnYedekle
            // 
            this.BtnYedekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnYedekle.Location = new System.Drawing.Point(341, 252);
            this.BtnYedekle.Name = "BtnYedekle";
            this.BtnYedekle.Size = new System.Drawing.Size(111, 57);
            this.BtnYedekle.TabIndex = 7;
            this.BtnYedekle.Text = "YEDEKLE";
            this.BtnYedekle.Click += new System.EventHandler(this.BtnYedekle_Click);
            // 
            // FrmYedekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 331);
            this.Controls.Add(this.BtnYedekle);
            this.Controls.Add(this.BtnSec);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.TxtDatab);
            this.Controls.Add(this.TxtServer);
            this.Name = "FrmYedekle";
            this.Text = "FrmYedekle";
            this.Load += new System.EventHandler(this.FrmYedekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDatab.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtServer;
        private DevExpress.XtraEditors.TextEdit TxtDatab;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnSec;
        private DevExpress.XtraEditors.SimpleButton BtnYedekle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}