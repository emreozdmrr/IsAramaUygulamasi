using isBulmaUygulamasi.Açılış_Formları;
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

namespace isBulmaUygulamasi.AnaMenu_Formları
{
    public partial class frmCalisanMenu : Form
    {
        public frmCalisanMenu(int KullaniciId)
        {
            InitializeComponent();
            KullaniciId_ = KullaniciId;
        }
        Metotlar nesne = new Metotlar();
        int KullaniciId_;
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
        private void btnKullaniciBilgileri_Click(object sender, EventArgs e)
        {
            try
            {
                nesne.KullaniciBilgileriNe(KullaniciId_);
                nesne.OpenChildForm(new frmKullaniciProfil(nesne.kullaniciBilgileri[0].KullaniciMail, nesne.kullaniciBilgileri[0].KullaniciSifre, KullaniciId_), sender, pnlMain);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnBasvurularim_Click(object sender, EventArgs e)
        {
            try
            {
                nesne.OpenChildForm(new frmKullaniciBasvurular(KullaniciId_), sender, pnlMain);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnIlanAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (nesne.OzgecmisDoluMu(KullaniciId_))
                {
                    nesne.OpenChildForm(new frmArama(KullaniciId_), sender, pnlMain);
                }
                else
                    MessageBox.Show("Arama yapabilmek için özgeçmişinizdeki gerekli alanları doldurmanız gerekmektedir.", "Bilgi Mesajı", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnOzgecmisim_Click(object sender, EventArgs e)
        {
            try
            {
                if (nesne.OzgecmisDoluMu(KullaniciId_))
                {
                    nesne.OpenChildForm(new frmKullaniciOzgecmis("Güncelleme", KullaniciId_), sender, pnlMain);
                }
                else
                {
                    nesne.OpenChildForm(new frmKullaniciOzgecmis("Yeni Kayıt", KullaniciId_), sender, pnlMain);
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnOturumuKapat_Click(object sender, EventArgs e)
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
        private void frmCalisanMenu_Load(object sender, EventArgs e)
        {
            try
            {
                if (nesne.KullaniciFotografiVarsaUrlDondur(KullaniciId_) != "")
                {
                    pictureBox4.ImageLocation = nesne.KullaniciFotografiVarsaUrlDondur(KullaniciId_);
                }
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
        private void btnMesajlar_Click(object sender, EventArgs e)
        {
            try
            {
                nesne.OpenChildForm(new frmMesajlar(KullaniciId_), sender, pnlMain);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
    }
}