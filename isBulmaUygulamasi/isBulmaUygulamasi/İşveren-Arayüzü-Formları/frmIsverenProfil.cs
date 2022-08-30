using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isBulmaUygulamasi
{
    public partial class frmIsverenProfil : Form
    {
        public frmIsverenProfil(string KullaniciMail, string KullaniciSifre, int KullaniciId)
        {
            InitializeComponent();
            kullaniciMail = KullaniciMail;
            kullaniciSifre = KullaniciSifre;
            kullaniciId = KullaniciId;
        }
        private string kullaniciMail;
        private string kullaniciSifre;
        private int kullaniciId;
        Metotlar nesne = new Metotlar();
        private void frmIsverenProfil_Load(object sender, EventArgs e)
        {
            try
            {
                txtMail.Text = kullaniciMail;
                txtSifre.Text = kullaniciSifre;
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar == true)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
                txtSifre.UseSystemPasswordChar = true;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMail.Text == kullaniciMail && txtSifre.Text == kullaniciSifre)
                {
                    MessageBox.Show("Bilgileriniz güncellenmedi.", "Bilgi Mesajı", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    if (txtMail.Text != "" && txtSifre.Text != "")
                    {
                        if (!nesne.KayitVarMi(txtMail.Text) || txtMail.Text == kullaniciMail)
                        {
                            if (nesne.SifreUygunMu(txtSifre.Text) && txtSifre.Text.Length == 8)
                            {
                                nesne.MailSifreGuncelleme(kullaniciMail, txtSifre.Text, txtMail.Text);
                                nesne.Log("Kullanıcı profil bilgilerini güncelledi.", "", kullaniciId);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Şifreniz en az bir büyük harf, en az bir küçük harf ve en az bir sayı içermelidir!", "Uyarı Mesajı", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("E-mail'e ait kayıt bulunmaktadır!", "Uyarı Mesajı", MessageBoxButtons.OK);
                        }
                    }
                    else
                        MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!", "Uyarı Mesajı", MessageBoxButtons.OK);
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSifre.UseSystemPasswordChar == true)
                    txtSifre.UseSystemPasswordChar = false;
                else
                    txtSifre.UseSystemPasswordChar = true;
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
    }
}