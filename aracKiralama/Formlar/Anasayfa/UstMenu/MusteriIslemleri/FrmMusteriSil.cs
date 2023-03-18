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
    public partial class FrmMusteriSil : Form
    {
        public FrmMusteriSil()
        {
            InitializeComponent();
        }


        #region kayıt silme

        private void btnSil_Click(object sender, EventArgs e)
        {
            kayitSilBilgilendirme();
        }

        private void kayitSilBilgilendirme()
        {
            if (MessageBox.Show(

              "Seçilen Veriyi silmek istiyor musunuz?",
              "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                kayitSil();
        }

        private void kayitSil()
        {


            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Delete from musteri where id=" + txtId.Text;
                OleDbCommand com = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClsVeriTabaniIslemleri.baglanti.Close();
                this.Close();


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Müşteri Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        #endregion

        private void FrmMusteriSil_Load(object sender, EventArgs e)
        {
            ptbMusteri.Image = ClsResimIslemleri.resimGoruntule("musteri", txtTc.Text);
        }

       
       
       
       
        
    }
}
