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
    public partial class frmKullaniciOzgecmis : Form
    {
        string islemTipi;
        Metotlar nesne = new Metotlar();
        string cinsiyet = "Kadın";
        int KullaniciId;
        string dogumTarihi = "";
        string liseBaslangicTarihi = "";
        string liseBitisTarihi = "";
        string universiteBaslangicTarihi = "";
        string universiteBitisTarihi = "";
        string iseGirisTarihi1 = "";
        string istenCikisTarihi1 = "";
        string iseGirisTarihi2 = "";
        string istenCikisTarihi2 = "";
        string tecilTarihi = "";
        string AskerlikDurumu = "";
        int OzgecmisHerkeseAcik = 1;
        int IlanId_;
        public frmKullaniciOzgecmis(string islemTipi_, int kullaniciId)
        {
            InitializeComponent();
            islemTipi = islemTipi_;
            KullaniciId = kullaniciId;
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (islemTipi == "Yeni Kayıt")
                {
                    if (txtAd.Text != "" && txtSoyad.Text != "" && maskedTxtTelefon.Text != "" && comboBoxSehir.Text != "" && (checkBox1.Checked || checkBox2.Checked) && dateTimePicker1.Text != "")
                    {
                        if (dateTimePicker1.Format == DateTimePickerFormat.Custom)
                        {
                            MessageBox.Show("Lütfen doğum tarihinizi giriniz!", "Uyarı Mesajı", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (checkBox1.Checked)
                            {
                                cinsiyet = "Erkek";
                            }
                            if (comboBoxBolum.Text == "Listede yok ise yazınız.")
                            {
                                comboBoxBolum.Text = "";
                            }
                            if (radioButton2.Checked)
                            {
                                OzgecmisHerkeseAcik = 0;
                            }
                            if (groupBox11.Visible)
                            {
                                if (comboBoxAskerlikDurumu.Text == "Tecilli")
                                {
                                    AskerlikDurumu = "Tecilli-" + dateTimePickerTecilTarihi.Text;
                                }
                                else
                                    AskerlikDurumu = comboBoxAskerlikDurumu.Text;
                            }
                            nesne.OzgecmisYeniKayit(txtAd.Text, txtSoyad.Text, maskedTxtTelefon.Text, comboBoxSehir.Text, cinsiyet, dogumTarihi, txtLiseOkulAdi.Text,
                                liseBaslangicTarihi, liseBitisTarihi, txtUniversiteOkulAdi.Text, universiteBaslangicTarihi,
                                universiteBitisTarihi, comboBoxBolum.Text, txtFirmaAdi.Text, iseGirisTarihi1, istenCikisTarihi1,
                                comboBoxIsTipi1.Text, txtFirmaAdi2.Text, iseGirisTarihi2, istenCikisTarihi2, comboBoxIsTipi2.Text, richTextBoxHobiler.Text,
                                richTextBoxOzetBilgi.Text, pictureBoxProfil.ImageLocation, KullaniciId, OzgecmisHerkeseAcik, AskerlikDurumu);
                            nesne.Log("Kullanıcı özgeçmiş oluşturdu.", "", KullaniciId);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Zorunlu alanları doldurmanız gerekmektedir!", "Uyarı Mesajı", MessageBoxButtons.OK);
                    }
                }
                else   // Özgeçmiş Güncelleme
                {
                    if (btnKaydet.Text == "Kaydet")
                    {
                        cinsiyet = "Kadın";
                        if (txtAd.Text != "" && txtSoyad.Text != "" && maskedTxtTelefon.Text != "" && comboBoxSehir.Text != "" && (checkBox1.Checked || checkBox2.Checked) && dateTimePicker1.Text != "")
                        {
                            if (checkBox1.Checked)
                            {
                                cinsiyet = "Erkek";
                            }
                            if (comboBoxBolum.Text == "Listede yok ise yazınız.")
                            {
                                comboBoxBolum.Text = "";
                            }
                            if (radioButton2.Checked)
                            {
                                OzgecmisHerkeseAcik = 0;
                            }
                            if (groupBox11.Visible)
                            {
                                if (comboBoxAskerlikDurumu.Text == "Tecilli")
                                {
                                    AskerlikDurumu = "Tecilli-" + dateTimePickerTecilTarihi.Text;
                                }
                                else
                                    AskerlikDurumu = comboBoxAskerlikDurumu.Text;
                            }
                            nesne.OzgecmisGuncelleme(txtAd.Text, txtSoyad.Text, maskedTxtTelefon.Text, comboBoxSehir.Text, cinsiyet, dogumTarihi, txtLiseOkulAdi.Text,
                                liseBaslangicTarihi, liseBitisTarihi, txtUniversiteOkulAdi.Text, universiteBaslangicTarihi,
                                universiteBitisTarihi, comboBoxBolum.Text, txtFirmaAdi.Text, iseGirisTarihi1, istenCikisTarihi1,
                                comboBoxIsTipi1.Text, txtFirmaAdi2.Text, iseGirisTarihi2, istenCikisTarihi2, comboBoxIsTipi2.Text, richTextBoxHobiler.Text,
                                richTextBoxOzetBilgi.Text, pictureBoxProfil.ImageLocation, KullaniciId, OzgecmisHerkeseAcik, AskerlikDurumu);
                            nesne.Log("Kullanıcı özgeçmişini güncelledi.", "", KullaniciId);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Zorunlu alanları doldurmanız gerekmektedir!", "Uyarı Mesajı", MessageBoxButtons.OK);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dogumTarihi = dateTimePicker1.Text;
        }
        private void dateTimePickerLiseBaslangic_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLiseBaslangic.Format = DateTimePickerFormat.Short;
            liseBaslangicTarihi = dateTimePickerLiseBaslangic.Text;
        }
        private void dateTimePickerLiseBitis_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLiseBitis.Format = DateTimePickerFormat.Short;
            liseBitisTarihi = dateTimePickerLiseBitis.Text;
        }
        private void dateTimePickerUniversiteBaslangic_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerUniversiteBaslangic.Format = DateTimePickerFormat.Short;
            universiteBaslangicTarihi = dateTimePickerUniversiteBaslangic.Text;
        }
        private void dateTimePickerUniversiteBitis_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerUniversiteBitis.Format = DateTimePickerFormat.Short;
            universiteBitisTarihi = dateTimePickerUniversiteBitis.Text;
        }
        private void dateTimePickerIseGiris1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerIseGiris1.Format = DateTimePickerFormat.Short;
            iseGirisTarihi1 = dateTimePickerIseGiris1.Text;
        }
        private void dateTimePickerIsCikis1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerIsCikis1.Format = DateTimePickerFormat.Short;
            istenCikisTarihi1 = dateTimePickerIsCikis1.Text;
        }
        private void dateTimePickerIseGiris2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerIseGiris2.Format = DateTimePickerFormat.Short;
            iseGirisTarihi2 = dateTimePickerIseGiris2.Text;
        }
        private void dateTimePickerIsCikis2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerIsCikis2.Format = DateTimePickerFormat.Short;
            istenCikisTarihi2 = dateTimePickerIsCikis2.Text;
        }
        private void frmKullaniciOzgecmis_Load(object sender, EventArgs e)
        {
            try
            {
                if (islemTipi == "Güncelleme")
                {
                    nesne.OzgecmisBilgileri(KullaniciId);
                    nesne.KullaniciBilgileriNe(KullaniciId);
                    txtAd.Text = nesne.ozGecmis[0].Ad;
                    txtSoyad.Text = nesne.ozGecmis[0].Soyad;
                    txtMail.Text = nesne.kullaniciBilgileri[0].KullaniciMail;
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
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Tüm dosyalar (*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBoxProfil.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox11.Visible = true;
                checkBox2.Checked = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                groupBox11.Visible = false;
                checkBox1.Checked = false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }
        private void comboBoxAskerlikDurumu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxAskerlikDurumu.Text == "Tecilli")
            {
                lblTecilTarihi.Visible = true;
                dateTimePickerTecilTarihi.Visible = true;
            }
            else
            {
                lblTecilTarihi.Visible = false;
                dateTimePickerTecilTarihi.Visible = false;
            }
        }
        private void dateTimePickerTecilTarihi_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTecilTarihi.Format = DateTimePickerFormat.Short;
            tecilTarihi = dateTimePickerTecilTarihi.Text;
        }
    }
}