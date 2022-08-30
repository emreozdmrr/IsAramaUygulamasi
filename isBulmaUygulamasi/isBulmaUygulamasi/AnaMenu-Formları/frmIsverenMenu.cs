using isBulmaUygulamasi.Açılış_Formları;
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

namespace isBulmaUygulamasi.AnaMenu_Formları
{
    public partial class frmIsverenMenu : Form
    {
        public frmIsverenMenu(int KullaniciId, string KullaniciMail, string KullaniciSifre)
        {
            InitializeComponent();
            KullaniciId_ = KullaniciId;
            KullaniciMail_ = KullaniciMail;
            KullaniciSifre_ = KullaniciSifre;
        }
        Metotlar nesne = new Metotlar();
        int KullaniciId_;
        string KullaniciMail_, KullaniciSifre_;
        private void btnIsIlanıVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (nesne.FirmaBilgileriDoluMu(KullaniciId_))
                    nesne.OpenChildForm(new frmYeniIlan(KullaniciId_), sender, pnlMain);
                else
                    MessageBox.Show("Lütfen firma bilgilerini tamamlayınız.", "Uyarı Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnIlanlarım_Click(object sender, EventArgs e)
        {
            try
            {
                if (nesne.FirmaBilgileriDoluMu(KullaniciId_))
                    nesne.OpenChildForm(new frmIlanlar(KullaniciId_), sender, pnlMain);
                else
                    MessageBox.Show("Lütfen firma bilgilerini tamamlayınız.", "Uyarı Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnCalisanAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (nesne.FirmaBilgileriDoluMu(KullaniciId_))
                    nesne.OpenChildForm(new frmCalisanArama(KullaniciId_), sender, pnlMain);
                else
                    MessageBox.Show("Lütfen firma bilgilerini tamamlayınız.", "Uyarı Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmIsverenMenu_Load(object sender, EventArgs e)
        {
            try
            {
                nesne.AnaMenuToplamSayilar();
                lblToplamKullaniciSayisi.Text = nesne.ToplamKullaniciSayisi.ToString();
                lblToplamIlanSayisi.Text = nesne.ToplamIlanSayisi.ToString();
                lblToplamBasvuruSayisi.Text = nesne.ToplamBasvuruSayisi.ToString();
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (nesne.FirmaBilgileriDoluMu(KullaniciId_))
                    nesne.OpenChildForm(new frmGonderilenMesajlar(KullaniciId_), sender, pnlMain);
                else
                    MessageBox.Show("Lütfen firma bilgilerini tamamlayınız.", "Uyarı Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Close();
                frmGiris frm = new frmGiris();
                frm.Show();
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }

        private void btnFirmaBilgileri_Click(object sender, EventArgs e)
        {
            try
            {
                nesne.OpenChildForm(new frmFirmaBilgileri(KullaniciId_), sender, pnlMain);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }

        private void btnKullaniciBilgileri_Click(object sender, EventArgs e)
        {
            try
            {
                nesne.KullaniciBilgileriNe(KullaniciId_);
                nesne.OpenChildForm(new frmIsverenProfil(nesne.kullaniciBilgileri[0].KullaniciMail, nesne.kullaniciBilgileri[0].KullaniciSifre, KullaniciId_), sender, pnlMain);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
    }
}