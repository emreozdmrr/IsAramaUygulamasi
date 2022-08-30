using isBulmaUygulamasi.AnaMenu_Formları;
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

namespace isBulmaUygulamasi.Açılış_Formları
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        Metotlar nesne = new Metotlar();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (nesne.KullaniciBilgileriDogruMu(txtMail.Text, txtSifre.Text))
                {
                    if (nesne.kullaniciBilgileriDogruMu[0].KullaniciYetki == "Çalışan")    // 1:Çalışan arayüzü
                    {
                        frmCalisanMenu frm = new frmCalisanMenu(nesne.kullaniciBilgileriDogruMu[0].KullaniciId);
                        frm.Show();
                        this.Hide();
                    }
                    else if (nesne.kullaniciBilgileriDogruMu[0].KullaniciYetki == "İşveren")  // 2:İşveren arayüzü
                    {
                        frmIsverenMenu frm = new frmIsverenMenu(nesne.kullaniciBilgileriDogruMu[0].KullaniciId, txtMail.Text, txtSifre.Text);
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("E-mail'iniz ya da Şifreniz Hatalı!", "Uyarı Mesajı", MessageBoxButtons.OK);
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
                frmKayitOl frm = new frmKayitOl();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw;
            }
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
                throw;
            }
        }
    }
}