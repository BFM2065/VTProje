using Microsoft.SqlServer.Management.Common;
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

namespace VTProje.YoneticiFormları
{
    public partial class FrmYedekle : Form
    {
        public FrmYedekle()
        {
            InitializeComponent();
        }

        private void FrmYedekle_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Yedeklenecek Yolu Belirtiniz";
            saveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak)|*.bak|Tüm Dosyalar(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textEdit3.Text = saveFileDialog1.FileName;
            }
        }

        private void BtnYedekle_Click(object sender, EventArgs e)
        {
            Server dbServer = new Server(new ServerConnection(TxtServer.Text));
            Backup dbkbackup = new Backup();
            dbkbackup.Action = BackupActionType.Database;
            dbkbackup.Database = TxtDatab.Text;
            dbkbackup.Devices.AddDevice(textEdit3.Text, DeviceType.File);
            dbkbackup.Initialize = false;

            dbkbackup.Complete += Dbkbackup_Complete;
            dbkbackup.SqlBackup(dbServer);
        }

        private void Dbkbackup_Complete(object sender, ServerMessageEventArgs e)
        {
            try
            {
                MessageBox.Show("Yedekleme İşlemi Başarılı Bir Şekilde Gerçekleşti...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtDatab_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtServer_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
