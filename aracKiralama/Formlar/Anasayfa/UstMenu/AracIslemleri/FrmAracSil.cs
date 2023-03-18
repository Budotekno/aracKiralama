using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace aracKiralama
{
    public partial class FrmAracSil : Form
    {
        public FrmAracSil()
        {
            InitializeComponent();
        }

        #region Kayıt silme

        #region bilgilendirme mesajı


        private void kayitSilBilgilendirme()
        {
            if (MessageBox.Show(
               "Seçilen Veriyi silmek istiyor musunuz?",
              "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                kayitSil();
        }

        #endregion

        #region silme fonksiyonu

        private void kayitSil()
        {

            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Delete from arac where id=" + txtId.Text;
                OleDbCommand com = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClsVeriTabaniIslemleri.baglanti.Close();
                this.Close();


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Araç Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion

        #region btnsilme tıklama olayı
        private void btnKayitSil_Click(object sender, EventArgs e)
        {
            kayitSilBilgilendirme();
        }

        #endregion

       
        #endregion

        private void FrmAracSil_Load(object sender, EventArgs e)
        {

            ptbArac.Image = ClsResimIslemleri.resimGoruntule("arac", txtPlaka.Text);
        }




       


       

       
    }
}
