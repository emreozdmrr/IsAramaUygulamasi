using isBulmaUygulamasi.İşveren_Arayüzü_Formları;
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
    public partial class frmIlanlar : Form
    {
        public frmIlanlar(int KullaniciId)
        {
            InitializeComponent();
            kullaniciId = KullaniciId;
        }
        int kullaniciId;
        Metotlar nesne = new Metotlar();
        private void frmIlanlar_Load(object sender, EventArgs e)
        {
            try
            {
                nesne.FirmaBilgileriDoldur(kullaniciId);
                nesne.GridDoldurIlanlar(nesne.firmaBilgileri[0].FirmaId);
                if (nesne.ilanlarModel.Count > 0)
                    dataGridView1.DataSource = nesne.ilanlarModel;
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnBasvurulariGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.SelectedRows[0].Cells["IlanId"].Value != null)
                {
                    var ilanId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IlanId"].Value);
                    nesne.BasvuranlariListele(ilanId);
                    if (nesne.basvuranOzgecmisListesi.Count != 0)
                    {
                        frmBasvurulariGoruntule frm = new frmBasvurulariGoruntule(nesne.basvuranOzgecmisListesi,kullaniciId);
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Mevcut başvuru bulunmamaktadır.", "Bilgi Mesajı", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen kayıt seçiniz.", "Uyarı Mesajı", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.SelectedRows[0].Cells["IlanId"].Value != null)
                {
                    var ilanId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IlanId"].Value);
                    nesne.IlanSil(ilanId);
                    MessageBox.Show("İlan başarıyla silindi.", "Bilgi Mesajı", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen kayıt seçiniz.", "Uyarı Mesajı", MessageBoxButtons.OK);
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