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
    public partial class frmYeniIlan : Form
    {
        public frmYeniIlan(int KullaniciId)
        {
            InitializeComponent();
            kullaniciId = KullaniciId;
            nesne.FirmaBilgileriDoldur(KullaniciId);
            txtFirmaAdi.Text = nesne.firmaBilgileri[0].FirmaAdi;
        }
        int kullaniciId;
        int FirmaKullaniciId_;
        int IlanId_;
        Metotlar nesne = new Metotlar();
        private void btnIlanVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxIsTanimi.Text != "" && comboBoxTecrube.Text != "" && richTextBoxAciklama.Text != "" && comboBoxSehirler.Text != "")
                {
                    if (checkBox1.Checked && richTextBoxOtomatikMesaj.Text != "")
                    {
                        nesne.IlanVer(nesne.firmaBilgileri[0].FirmaId, comboBoxTecrube.Text, richTextBoxAciklama.Text, kullaniciId, comboBoxIsTanimi.Text, comboBoxSehirler.Text, richTextBoxOtomatikMesaj.Text);
                        MessageBox.Show("İşlem başarılı!", "Bilgi Mesajı", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else if (checkBox1.Checked && richTextBoxOtomatikMesaj.Text == "")
                        MessageBox.Show("Lütfen otomatik mesaj alanını doldurunuz.", "Bilgi Mesaji", MessageBoxButtons.OK);
                    else
                    {
                        nesne.IlanVer(nesne.firmaBilgileri[0].FirmaId, comboBoxTecrube.Text, richTextBoxAciklama.Text, kullaniciId, comboBoxIsTanimi.Text, comboBoxSehirler.Text, "");
                        MessageBox.Show("İşlem başarılı!", "Bilgi Mesajı", MessageBoxButtons.OK);
                        this.Close();
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBoxOtomatikMesaj.Enabled == true)
                richTextBoxOtomatikMesaj.Enabled = false;
            else
                richTextBoxOtomatikMesaj.Enabled = true;
        }
    }
}