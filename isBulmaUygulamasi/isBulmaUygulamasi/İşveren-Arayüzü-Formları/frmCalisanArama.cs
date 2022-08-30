using Dapper;
using isBulmaUygulamasi.İşveren_Arayüzü_Formları;
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
    public partial class frmCalisanArama : Form
    {
        public frmCalisanArama(int KullaniciId)
        {
            InitializeComponent();
            KullaniciId_ = KullaniciId;
        }
        Metotlar nesne = new Metotlar();
        int IlanId;
        int KullaniciId_;
        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked && comboBoxBolum.Text != "")
                {
                    nesne.GridDoldurBolum(comboBoxBolum.Text);
                    if (nesne.ozgecmisModelBolum.Count != 0)
                    {
                        dataGridView1.DataSource = nesne.ozgecmisModelBolum;
                    }
                    else
                    {
                        nesne.GridTemizleTest(dataGridView1);
                    }
                }
                else if (radioButton1.Checked && comboBoxBolum.Text == "")
                {
                    MessageBox.Show("Lütfen bölüm seçiniz.", "Uyarı Mesajı", MessageBoxButtons.OK);
                    nesne.GridTemizleTest(dataGridView1);
                }
                else
                {
                    if (txtIsTanimi.Text == "")
                    {
                        MessageBox.Show("Lütfen iş tanımı giriniz.", "Uyarı Mesajı", MessageBoxButtons.OK);
                        nesne.GridTemizleTest(dataGridView1);
                    }
                    else if (txtIsTanimi.Text.Length <= 1)
                    {
                        MessageBox.Show("Lütfen en az 2 karakter içeren iş tanımı giriniz.", "Uyarı Mesajı", MessageBoxButtons.OK);
                        nesne.GridTemizleTest(dataGridView1);
                    }
                    else
                    {
                        nesne.GridDoldurAnahtarKelime(txtIsTanimi.Text);
                        if (nesne.ozgecmisModelAnahtarKelime.Count != 0)
                        {
                            dataGridView1.DataSource = nesne.ozgecmisModelAnahtarKelime;
                        }
                        else
                            nesne.GridTemizleTest(dataGridView1);
                    }
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBoxBolum.Enabled = true;
                radioButton2.Checked = false;
                txtIsTanimi.Enabled = false;
                txtIsTanimi.Text = "";
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtIsTanimi.Enabled = true;
                comboBoxBolum.Enabled = false;
                radioButton1.Checked = false;
                comboBoxBolum.Text = "";
            }
        }
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0 && Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OzgecmisId"].Value) != 0)
                {
                    var seciliOzgecmisId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OzgecmisId"].Value);
                    frmOzgecmisGoruntule frm = new frmOzgecmisGoruntule(seciliOzgecmisId,KullaniciId_);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lütfen kayıt seçiniz.", "Uyarı Mesajı", MessageBoxButtons.OK);
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
    }
}