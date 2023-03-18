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
    public partial class FrmKullaniciGuncelle : Form
    {
        public FrmKullaniciGuncelle()
        {
            InitializeComponent();
        }


        #region güncelle

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (boslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else guncelle();
            
                
        }
        public string eskiKullaniciAd = "";
        private void guncelle()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "update personel set tc=@tc, kullaniciAd=@kullaniciAd , sifre=@sifre, kullaniciTuru=@kullaniciTuru where id=@id";
                OleDbCommand guncelle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                guncelle.Parameters.AddWithValue("@tc", txtTc.Text);
                guncelle.Parameters.AddWithValue("@kullaniciAd", txtKullaniciAd.Text);
                guncelle.Parameters.AddWithValue("@sifre", txtSifre.Text);
                guncelle.Parameters.AddWithValue("@kullaniciTuru", cmbKullaniciTuru.Text);
                guncelle.Parameters.AddWithValue("@id", txtId.Text);
                
                if (guncelle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                    if (FrmGiris.kullaniciAd == eskiKullaniciAd)
                    {
                        FrmGiris.kullaniciAd = txtKullaniciAd.Text;
                        FrmGiris.kullaniciTuru = cmbKullaniciTuru.Text;
                    }
                    this.Close();
                }
                ClsVeriTabaniIslemleri.baglanti.Close();



            }
            catch (Exception hata)
            {

                ClsVeriTabaniIslemleri.baglanti.Close();
                ClsLogIslemleri.logEkleme("Kullanıcı Tablosu", "Kullanıcı Güncelleme Hatası", hata.Message);
                MessageBox.Show(hata.Message,"Kullanıcı Güncelleme Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }

        }


        private bool boslukKontrol()
        {
            bool bosluk = false;

            lblYildizKullaniciAd.Visible = false;
            lblYildizSifre.Visible = false;
            lblYildizTc.Visible = false;
            lblYildizFoto.Visible = false;
            lblYildizKullaniciTuru.Visible = false;

            if (ptbKullanici.Image == null)
            {
                lblYildizFoto.Visible = true;
                bosluk = true;
            }

            if (cmbKullaniciTuru.Text == "Seçiniz")
            {
                lblYildizKullaniciTuru.Visible = true;
                bosluk = true;
            }

            if (txtSifre.Text == "")
            {
                lblYildizSifre.Visible = true;
                txtSifre.Focus();
                bosluk = true;

            }

            if (txtKullaniciAd.Text == "")
            {
                lblYildizKullaniciAd.Visible = true;
                txtKullaniciAd.Focus();
                bosluk = true;
            }

            if (txtTc.Text == "")
            {
                lblYildizTc.Visible = true;
                txtTc.Focus();
                bosluk = true;
            }

            return bosluk;
 
        }



        #endregion

        private void FrmKullaniciGuncelle_Load(object sender, EventArgs e)
        {
            ptbKullanici.Image = ClsResimIslemleri.resimGoruntule("personel", txtTc.Text);
            if (FrmGiris.kullaniciTuru == "Yönetici")
                cmbKullaniciTuru.Enabled = true;
            else cmbKullaniciTuru.Enabled = false;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ptbKullanici.Image = ClsResimIslemleri.resimYukle("Kullanıcının");
        }

      
    }
}
