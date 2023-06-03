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
    public partial class FrmYedekDon : Form
    {
        public FrmYedekDon()
        {
            InitializeComponent();
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Yedek Yolunu Belirtiniz";
            saveFileDialog1.Filter = "Yedekleme Dosyaları(*.bak)|*.bak|Tüm Dosyalar(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textEdit3.Text = saveFileDialog1.FileName;
            }
        }

        private void BtnYedekle_Click(object sender, EventArgs e)
        {
            try
            {
                Server dbServer = new Server(new ServerConnection(TxtServer.Text));
                Restore dbRestore = new Restore() { Database = TxtDatab.Text, Action = RestoreActionType.Database, ReplaceDatabase = true, NoRecovery = false };
                dbRestore.Devices.AddDevice(textEdit3.Text, DeviceType.File);
                dbRestore.PercentComplete += DbRestore_PercentComplete;
                dbRestore.Complete += DbRestore_Complete;
                dbRestore.SqlRestoreAsync(dbServer);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            try
            {
                MessageBox.Show("Yedeğe Dönme İşlemi Başarılı Bir Şekilde Gerçekleşti...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
          
        }
    }
}
