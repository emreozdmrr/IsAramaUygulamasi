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
using static isBulmaUygulamasi.Models;

namespace isBulmaUygulamasi.İşveren_Arayüzü_Formları
{
    public partial class frmBasvurulariGoruntule : Form
    {
        public frmBasvurulariGoruntule(List<BasvuranIdModel> basvurular, int KullaniciId)
        {
            InitializeComponent();
            this.basvurular = basvurular;
            KullaniciId_ = KullaniciId;
        }
        List<BasvuranIdModel> basvurular = new List<BasvuranIdModel>();
        int IlanId_;
        int KullaniciId_;
        Metotlar nesne = new Metotlar();

        private void frmBasvurulariGoruntule_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = basvurular;
        }
        private void btnBasvurulariGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.SelectedRows[0].Cells["BasvuranOzgecmisId"].Value != null)
                {
                    var ozgecmisId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BasvuranOzgecmisId"].Value);
                    frmOzgecmisGoruntule frm = new frmOzgecmisGoruntule(ozgecmisId, KullaniciId_);
                    frm.ShowDialog();
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
                throw;
            }
        }
    }
}
