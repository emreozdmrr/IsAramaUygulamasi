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
    public partial class frmGonderilenMesajlar : Form
    {
        public frmGonderilenMesajlar(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
        }
        int kullaniciId;
        Metotlar nesne = new Metotlar();
        private void frmGonderilenMesajlar_Load(object sender, EventArgs e)
        {
            try
            {
                nesne.GonderilenMesajlariListele(0, kullaniciId);
                if (nesne.gonderilenMesajlar.Count > 0)
                {
                    dataGridView1.DataSource = nesne.gonderilenMesajlar;
                }
                else
                    MessageBox.Show("Mesajınız bulunmamakta.", "Bilgi Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnMesajGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0 || dataGridView1.SelectedRows.Count != 0)
                {
                    nesne.GonderilenMesajlariListele(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MesajId"].Value), 0);
                    lblAdSoyad.Text = nesne.gonderilenMesajlar[0].Ad + " " + nesne.gonderilenMesajlar[0].Soyad;
                    lblTarih.Text = nesne.gonderilenMesajlar[0].MesajTarihi;
                    lblMesaj.Text = nesne.gonderilenMesajlar[0].Mesaj;
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