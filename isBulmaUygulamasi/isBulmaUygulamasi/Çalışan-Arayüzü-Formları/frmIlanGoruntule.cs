using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isBulmaUygulamasi.Çalışan_Arayüzü_Formları
{
    public partial class frmIlanGoruntule : Form
    {
        public frmIlanGoruntule(int KullaniciId,int IlanId)
        {
            InitializeComponent();
            KullaniciId_ = KullaniciId;
            IlanId_ = IlanId;
        }
        int KullaniciId_;
        int IlanId_;
        Metotlar nesne = new Metotlar();
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void frmIlanGoruntule_Load(object sender, EventArgs e)
        {
            try
            {
                nesne.IlanDetaylarıDoldur(IlanId_);
                txtFirmaAdi.Text = nesne.tumIlanlar[0].FirmaAdi;
                comboBoxSehirler.Text = nesne.tumIlanlar[0].Sehir;
                comboBoxIsTanimi.Text = nesne.tumIlanlar[0].IsTanimi;
                comboBoxTecrube.Text = nesne.tumIlanlar[0].Tecrube;
                richTextBoxAciklama.Text = nesne.tumIlanlar[0].Aciklama;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void btnBasvuruYap_Click(object sender, EventArgs e)
        {
            try
            {
                nesne.IlanDetaylarıDoldur(IlanId_);
                nesne.BasvuruEkle(IlanId_, nesne.tumIlanlar[0].FirmaId, nesne.OzgecmisIdDondur(KullaniciId_));
                this.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
