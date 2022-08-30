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
    public partial class frmOzgecmisGoruntule : Form
    {
        public frmOzgecmisGoruntule(int OzgecmisId_, int KullaniciId)
        {
            InitializeComponent();
            OzgecmisId = OzgecmisId_;
            KullaniciId_ = KullaniciId;
        }
        int OzgecmisId;
        public int KullaniciId_;
        Metotlar nesne = new Metotlar();

        private void frmOzgecmisGoruntule_Load(object sender, EventArgs e)
        {
            try
            {
                nesne.OzgecmisBilgileri(nesne.KullaniciIdDondur(OzgecmisId));
                Text = nesne.ozGecmis[0].Ad + " " + nesne.ozGecmis[0].Soyad;
                txtAd.Text = nesne.ozGecmis[0].Ad;
                txtSoyad.Text = nesne.ozGecmis[0].Soyad;
                txtMail.Text = nesne.KullaniciMailDondur(OzgecmisId);
                maskedTxtTelefon.Text = nesne.ozGecmis[0].Telefon;
                comboBoxSehir.Text = nesne.ozGecmis[0].Sehir;
                if (nesne.ozGecmis[0].Cinsiyet == "Erkek")
                {
                    checkBox1.Checked = true;
                }
                if (nesne.ozGecmis[0].Cinsiyet == "Kadın")
                {
                    checkBox2.Checked = true;
                }
                if (nesne.ozGecmis[0].DogumTarihi != "")
                {
                    dateTimePicker1.Text = nesne.ozGecmis[0].DogumTarihi;
                }
                txtLiseOkulAdi.Text = nesne.ozGecmis[0].LiseOkulAdi;
                if (nesne.ozGecmis[0].LiseBaslangicTarihi != "")
                {
                    dateTimePickerLiseBaslangic.Text = nesne.ozGecmis[0].LiseBaslangicTarihi;
                }
                if (nesne.ozGecmis[0].LiseBitisTarihi != "")
                {
                    dateTimePickerLiseBitis.Text = nesne.ozGecmis[0].LiseBitisTarihi;
                }
                txtUniversiteOkulAdi.Text = nesne.ozGecmis[0].UniversiteOkulAdi;
                if (nesne.ozGecmis[0].UniversiteBaslangicTarihi != "")
                {
                    dateTimePickerUniversiteBaslangic.Text = nesne.ozGecmis[0].UniversiteBaslangicTarihi;
                }
                if (nesne.ozGecmis[0].UniversiteBitisTarihi != "")
                {
                    dateTimePickerUniversiteBitis.Text = nesne.ozGecmis[0].UniversiteBitisTarihi;
                }
                comboBoxBolum.Text = nesne.ozGecmis[0].UniversiteBolum;
                txtFirmaAdi.Text = nesne.ozGecmis[0].FirmaAdi1;
                if (nesne.ozGecmis[0].Firma1GirisTarihi != "")
                {
                    dateTimePickerIseGiris1.Text = nesne.ozGecmis[0].Firma1GirisTarihi;
                }
                if (nesne.ozGecmis[0].Firma1CikisTarihi != "")
                {
                    dateTimePickerIsCikis1.Text = nesne.ozGecmis[0].Firma1CikisTarihi;
                }
                comboBoxIsTipi1.Text = nesne.ozGecmis[0].Firma1IsTipi;
                txtFirmaAdi2.Text = nesne.ozGecmis[0].FirmaAdi2;
                if (nesne.ozGecmis[0].Firma2GirisTarihi != "")
                {
                    dateTimePickerIseGiris2.Text = nesne.ozGecmis[0].Firma2GirisTarihi;
                }
                if (nesne.ozGecmis[0].Firma2CikisTarihi != "")
                {
                    dateTimePickerIsCikis2.Text = nesne.ozGecmis[0].Firma2CikisTarihi;
                }
                comboBoxIsTipi2.Text = nesne.ozGecmis[0].Firma2IsTipi;
                richTextBoxHobiler.Text = nesne.ozGecmis[0].Hobiler;
                richTextBoxOzetBilgi.Text = nesne.ozGecmis[0].Ozet;
                pictureBoxProfil.ImageLocation = nesne.ozGecmis[0].ResimUrl;
                if (nesne.ozGecmis[0].OzgecmisHerkeseAcik == 1)
                {
                    radioButton1.Checked = true;
                }
                if (nesne.ozGecmis[0].OzgecmisHerkeseAcik == 0)
                {
                    radioButton2.Checked = true;
                }
                if (nesne.ozGecmis[0].AskerlikDurumu != "")
                {
                    groupBox11.Visible = true;
                    if (nesne.ozGecmis[0].AskerlikDurumu.Contains("Tecilli"))
                    {
                        lblTecilTarihi.Visible = true;
                        dateTimePickerTecilTarihi.Visible = true;
                        var tecilTarihi_ = nesne.ozGecmis[0].AskerlikDurumu.Remove(0, 8);
                        comboBoxAskerlikDurumu.Text = "Tecilli";
                        dateTimePickerTecilTarihi.Text = tecilTarihi_;
                    }
                    else
                    {
                        comboBoxAskerlikDurumu.Text = nesne.ozGecmis[0].AskerlikDurumu;
                    }
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }

        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            try
            {
                frmMesajGonder frm = new frmMesajGonder(txtAd.Text, txtSoyad.Text, OzgecmisId, nesne.FirmaIdDondur(KullaniciId_), KullaniciId_);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
    }
}
