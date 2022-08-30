using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isBulmaUygulamasi.Çalışan_Arayüzü_Formları
{
    public partial class frmMesajlar : Form
    {
        public frmMesajlar(int kullaniciId)
        {
            InitializeComponent();
            KullaniciId = kullaniciId;
        }
        Metotlar nesne = new Metotlar();
        int KullaniciId;
        private void btnYeniMesajlar_Click(object sender, EventArgs e)
        {
            try
            {
                nesne.TumMesajlar(KullaniciId, 0);
                if (nesne.mesajlar.Count > 0)
                {
                    dataGridView1.DataSource = nesne.mesajlar;
                }
                else
                {
                    MessageBox.Show("Yeni mesajınız bulunmamakta.", "Bilgi Mesajı", MessageBoxButtons.OK);
                    nesne.GridTemizleTest(dataGridView1);
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnGecmisMesajlar_Click(object sender, EventArgs e)
        {
            try
            {
                nesne.TumMesajlar(KullaniciId, 1);
                if (nesne.mesajlar.Count > 0)
                {
                    dataGridView1.DataSource = nesne.mesajlar;
                }
                else
                {
                    MessageBox.Show("Geçmiş mesajınız bulunmamakta.", "Bilgi Mesajı", MessageBoxButtons.OK);
                    nesne.GridTemizleTest(dataGridView1);
                }

            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void frmMesajlar_Load(object sender, EventArgs e)
        {
            btnYeniMesajlar_Click(sender, e);
        }
        private void btnMesajGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.SelectedRows[0].Cells["MesajId"].Value.ToString() != "0")
                {
                    var MesajId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MesajId"].Value);
                    var FirmaAdi =dataGridView1.SelectedRows[0].Cells["FirmaAdi"].Value.ToString();
                    var Mesaj = dataGridView1.SelectedRows[0].Cells["Mesaj"].Value.ToString();
                    var MesajTarihi = dataGridView1.SelectedRows[0].Cells["MesajTarihi"].Value.ToString();
                    var MesajOkundu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MesajOkundu"].Value);
                    frmMesajGoruntule frm = new frmMesajGoruntule(MesajId,MesajOkundu,FirmaAdi,Mesaj,MesajTarihi);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lütfen mesaj seçiniz.", "Uyarı Mesajı", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}