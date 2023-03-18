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
    public partial class FrmPersonelSil : Form
    {
        public FrmPersonelSil()
        {
            InitializeComponent();
        }

        #region silme
        
       

        private void btnSil_Click(object sender, EventArgs e)
        {
            kayitSilBilgilendirme();
        }

        private void kayitSil()
        {
           

            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Delete from personel where id=" + txtId.Text;
                OleDbCommand com = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                if (com.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                ClsVeriTabaniIslemleri.baglanti.Close();
                this.Close();


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Personel Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void kayitSilBilgilendirme()
        {
            if (MessageBox.Show(
               
               "Seçilen Veriyi silmek istiyor musunuz?",
              "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                kayitSil();
        }

        #endregion

        private void FrmPersonelSil_Load(object sender, EventArgs e)
        {

            ptbPersonel.Image = ClsResimIslemleri.resimGoruntule("personel", txtTc.Text);
        }
       

    }
}
