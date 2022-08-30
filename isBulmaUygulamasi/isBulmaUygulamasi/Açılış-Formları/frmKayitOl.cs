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
    public partial class frmKayitOl : Form
    {
        public frmKayitOl()
        {
            InitializeComponent();
        }
        Metotlar nesne = new Metotlar();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMail.Text != "" & txtSifre.Text != "" && (checkBox1.Checked || checkBox2.Checked))
                {
                    if (nesne.KayitVarMi(txtMail.Text))
                    {
                        MessageBox.Show("E-mail'e ait kayıt bulunmaktadır!", "Uyarı Mesajı", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (txtSifre.Text.Length == 8)
                        {
                            if (nesne.SifreUygunMu(txtSifre.Text))
                            {
                                nesne.Kayit(txtMail.Text, txtSifre.Text, nesne.KullaniciYetkisiNe(checkBox1));
                                this.Close();
                                frmGiris frm = new frmGiris();
                                frm.Show();
                            }
                            else
                                MessageBox.Show("Şifreniz en az bir büyük harf, en az bir küçük harf ve en az bir sayı içermelidir!", "Uyarı Mesajı", MessageBoxButtons.OK);
                        }
                        else
                            MessageBox.Show("Şifreniz 8 karakter uzunluğunda olmalıdır!", "Uyarı Mesajı", MessageBoxButtons.OK);
                    }
                }
                else
                    MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz.", "Bilgi Mesajı", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            frmGiris frm = new frmGiris();
            frm.Show();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked && checkBox1.Checked)
            {
                checkBox1.Checked = false;
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