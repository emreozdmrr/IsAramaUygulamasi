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

namespace isBulmaUygulamasi.İşveren_Arayüzü_Formları
{
    public partial class frmFirmaBilgileri : Form
    {
        public frmFirmaBilgileri(int kullaniciId_)
        {
            InitializeComponent();
            kullaniciId = kullaniciId_;
        }
        int kullaniciId;
        Metotlar nesne = new Metotlar();
        private void frmFirmaBilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                if (nesne.FirmaBilgileriDoluMu(kullaniciId)) // yeni kayıt değil ise 
                {
                    nesne.FirmaBilgileriDoldur(kullaniciId);
                    txtFirmaAdi.Text = nesne.firmaBilgileri[0].FirmaAdi;
                    txtSektor.Text = nesne.firmaBilgileri[0].Sektor;
                    txtCalisanSayisi.Text = nesne.firmaBilgileri[0].CalisanSayisi.ToString();
                    richTextBoxFirmaBilgisi.Text = nesne.firmaBilgileri[0].FirmaOzetBilgi;
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirmaAdi.Text != "" && txtSektor.Text != "" && txtCalisanSayisi.Text != "" && richTextBoxFirmaBilgisi.Text != "")
                {
                    if (nesne.FirmaBilgileriDoluMu(kullaniciId)) // update
                    {
                        nesne.FirmaBilgileriniGuncelle(kullaniciId,txtFirmaAdi.Text,txtSektor.Text,txtCalisanSayisi.Text,richTextBoxFirmaBilgisi.Text);
                        this.Close();
                    }
                    else // insert
                    {
                        nesne.FirmaBilgileriInsert(kullaniciId,txtFirmaAdi.Text,txtSektor.Text,txtCalisanSayisi.Text,richTextBoxFirmaBilgisi.Text);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Bilgi Mesajı", MessageBoxButtons.OK);
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
