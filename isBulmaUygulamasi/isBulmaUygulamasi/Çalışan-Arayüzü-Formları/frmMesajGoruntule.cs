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

namespace isBulmaUygulamasi.Çalışan_Arayüzü_Formları
{
    public partial class frmMesajGoruntule : Form
    {
        public frmMesajGoruntule(int MesajId, int MesajOkundu, string FirmaAdi, string Mesaj, string MesajTarihi)
        {
            InitializeComponent();
            this.MesajId = MesajId;
            this.MesajOkundu = MesajOkundu;
            this.FirmaAdi = FirmaAdi;
            this.Mesaj = Mesaj;
            this.MesajTarihi = MesajTarihi;
        }
        int MesajId;
        int MesajOkundu;
        string FirmaAdi;
        string Mesaj;
        string MesajTarihi;
        Metotlar nesne = new Metotlar();
        private void frmMesajGoruntule_Load(object sender, EventArgs e)
        {
            try
            {
                if (MesajId != 0)
                {
                    nesne.SeciliMesajıGoster(MesajId, MesajOkundu);
                    lblGonderen.Text = FirmaAdi;
                    lblMesaj.Text = Mesaj;
                    lblMesajTarihi.Text = MesajTarihi;
                }
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
        }
    }
}