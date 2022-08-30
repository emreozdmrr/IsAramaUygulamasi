using isBulmaUygulamasi.Çalışan_Arayüzü_Formları;
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

namespace isBulmaUygulamasi
{
    public partial class frmArama : Form
    {
        public frmArama(int KullaniciId_)
        {
            InitializeComponent();
            kullaniciId = KullaniciId_;
        }
        int kullaniciId;
        Metotlar nesne = new Metotlar();
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxIsTanimi.Text != "" && comboBoxSehirler.Text != "" && comboBoxIsTecrubesi.Text != "")
                {
                    nesne.IlanlariListele(comboBoxIsTanimi.Text, comboBoxSehirler.Text, comboBoxIsTecrubesi.Text);
                    if (nesne.tumIlanlar.Count != 0)
                    {
                        dataGridView1.DataSource = nesne.tumIlanlar;
                    }
                    else
                    {
                        nesne.GridTemizleTest(dataGridView1);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı Mesajı", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnIlanGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0)
                {
                    if (dataGridView1.SelectedRows[0].Cells["IlanId"].Value.ToString() != "0" && dataGridView1.SelectedRows.Count != 0)
                    {
                        var firmaAdi = dataGridView1.SelectedRows[0].Cells["FirmaAdi"].Value.ToString();
                        var sehir = dataGridView1.SelectedRows[0].Cells["Sehir"].Value.ToString();
                        var isTanimi = dataGridView1.SelectedRows[0].Cells["IsTanimi"].Value.ToString();
                        var tecrube = dataGridView1.SelectedRows[0].Cells["Tecrube"].Value.ToString();
                        var aciklama = dataGridView1.SelectedRows[0].Cells["Aciklama"].Value.ToString();
                        var firmaKullaniciId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FirmaKullaniciId"].Value);
                        var ilanId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IlanId"].Value);
                        if (dataGridView1.SelectedRows.Count != 0)
                        {
                            frmIlanGoruntule frm = new frmIlanGoruntule(kullaniciId, ilanId);
                            frm.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Uygun iş ilanı bulunamadı.", "Bilgi Mesajı", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}