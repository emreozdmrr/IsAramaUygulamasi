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
    public partial class frmKullaniciBasvurular : Form
    {
        public frmKullaniciBasvurular(int KullaniciId)
        {
            InitializeComponent();
            KullaniciId_ = KullaniciId;
        }
        Metotlar nesne = new Metotlar();
        int KullaniciId_;
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmKullaniciBasvurular_Load(object sender, EventArgs e)
        {
            try
            {
                nesne.BasvurulariListele(KullaniciId_);
                if (nesne.basvurular.Count != 0)
                {
                    dataGridView1.DataSource = nesne.basvurular;
                }
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
        private void btnBasvuruSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0 && dataGridView1.SelectedRows[0].Cells["IlanId"].Value.ToString() != "0")
                {
                    nesne.BasvuruSil(KullaniciId_, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IlanId"].Value));
                    this.Close();
                }
                else
                    MessageBox.Show("Lütfen silmek istediğiniz başvuruyu seçiniz.", "Uyarı Mesajı", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                nesne.Log(MethodBase.GetCurrentMethod().Name + " 'de hata oluştu. Hata : " + ex.Message, "Hata", 0);
                throw;
            }
        }
    }
}