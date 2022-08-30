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
    public partial class frmMesajGonder : Form
    {
        public frmMesajGonder(string Ad, string Soyad, int AliciOzgecmisId, int GondericiFirmaId, int GondericiKullaniciId)
        {
            InitializeComponent();
            Ad_ = Ad;
            Soyad_ = Soyad;
            FirmaId = GondericiFirmaId;
            OzgecmisId = AliciOzgecmisId;
            FirmaKullaniciId = GondericiKullaniciId;
        }
        string Ad_;
        string Soyad_;
        int AliciId_;
        int IlanId_;
        int FirmaKullaniciId;
        int FirmaId;
        int OzgecmisId;
        Metotlar nesne = new Metotlar();
        private void frmMesajGonder_Load(object sender, EventArgs e)
        {
            lblAlici.Text = Ad_ + " " + Soyad_;
            nesne.FirmaBilgileriDoldur(FirmaKullaniciId);
            txtKimden.Text = nesne.firmaBilgileri[0].FirmaAdi;
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBoxMesaj.Text != "")
                {
                    nesne.MesajGonder(richTextBoxMesaj.Text, OzgecmisId, FirmaId);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mesaj kısmı boş bırakılamaz.", "Uyarı Mesajı", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
    }
}