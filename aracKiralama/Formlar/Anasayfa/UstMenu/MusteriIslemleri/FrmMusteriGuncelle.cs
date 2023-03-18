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
    public partial class FrmMusteriGuncelle : Form
    {
        public FrmMusteriGuncelle()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (boslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else kayitGuncelle();
        }

        private void kayitGuncelle()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "update musteri set tc=@tc, ad=@ad, soyad=@soyad, cinsiyet=@cinsiyet, medeniDurumu=@medeniDurumu, meslek=@meslek, telefon=@telefon, dogumTarihi=@dogumTarihi, dogumYeri=@dogumYeri, ehliyetTuru=@ehliyetTuru, yasadigiIl=@yasadigiIl, adres=@adres where id=@id";

                OleDbCommand guncelle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
               guncelle.Parameters.AddWithValue("@tc", txtTc.Text);
               guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
               guncelle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                if (radE.Checked)
                    guncelle.Parameters.AddWithValue("@cinsiyet", "Erkek");
                else guncelle.Parameters.AddWithValue("@cinsiyet", "Kadın");

                if (radEvli.Checked)
                   guncelle.Parameters.AddWithValue("@medeniDurumu", "Evli");
                else guncelle.Parameters.AddWithValue("@medeniDurumu", "Bekar");


                guncelle.Parameters.AddWithValue("@meslek", cmbMeslek.Text);
                guncelle.Parameters.AddWithValue("@telefon", txtTel.Text);
                guncelle.Parameters.AddWithValue("@dogumTarihi", dtpDogumTarihi.Text);
                guncelle.Parameters.AddWithValue("@dogumYeri", cmbDogumYeri.Text);
                guncelle.Parameters.AddWithValue("@ehliyetTuru", cmbEhliyetTuru.Text);
                guncelle.Parameters.AddWithValue("@yasadigiIl", cmbYasadigiIl.Text);
                guncelle.Parameters.AddWithValue("@adres", txtAdres.Text);
                guncelle.Parameters.AddWithValue("@id", txtId.Text);

                if (guncelle.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClsVeriTabaniIslemleri.baglanti.Close();

                // fotoğrafı kaydetmek için yazılan save komutu
              //  ptbMusteri.Image.Save(Application.StartupPath + "\\img\\musteri\\" + txtTc.Text + ".jpg");
                this.Close();


            }
            catch (Exception hata)
            {

                ClsVeriTabaniIslemleri.baglanti.Close();
                ClsLogIslemleri.logEkleme("Müşteri Tablosu", "Müşteri Güncelleme Hatası", hata.Message);
                MessageBox.Show(hata.Message, "Müşteri Kayıt Güncelleme Hata Penceresi");
            }

        }

        private bool boslukKontrol()
        {
            bool bosluk = false;

            lblYildizTcNo.Visible = false;
            lblYildizAd.Visible = false;
            lblYildizSoyad.Visible = false;
            lblYildizCinsiyet.Visible = false;
            lblYildizMeslek.Visible = false;
            lblYildizMedeniDurum.Visible = false;
            lblYildizTel.Visible = false;
            lblYildizDogumYeri.Visible = false;
            lblYildizEhliyetTuru.Visible = false;
            lblYildizYasadıgıİl.Visible = false;
            lblYildizAdres.Visible = false;
            lblYildizFoto.Visible = false;

            if (ptbMusteri.Image == null)
            {
                lblYildizFoto.Visible = true;
                bosluk = true;
            }

            if (txtAdres.Text == "")
            {
                lblYildizAdres.Visible = true;
                txtAdres.Focus();
                bosluk = true;
            }

            if (cmbYasadigiIl.Text == "" || cmbYasadigiIl.Text == "Seçiniz")
            {
                lblYildizYasadıgıİl.Visible = true;
                cmbYasadigiIl.Focus();
                bosluk = true;
            }

            if (cmbEhliyetTuru.Text == "" || cmbEhliyetTuru.Text == "Seçiniz")
            {
                lblYildizEhliyetTuru.Visible = true;
                cmbEhliyetTuru.Focus();
                bosluk = true;
            }

            if (cmbDogumYeri.Text == "" || cmbDogumYeri.Text == "Seçiniz")
            {
                lblYildizDogumYeri.Visible = true;
                cmbDogumYeri.Focus();
                bosluk = true;
            }

            if (txtTel.Text == "(   )        ")
            {
                lblYildizTel.Visible = true;
                txtTel.Focus();
                bosluk = true;
            }

            if (cmbMeslek.Text == "" || cmbMeslek.Text == "Seçiniz")
            {
                lblYildizMeslek.Visible = true;
                //   txtMeslek.Focus();
                bosluk = true;

            }

            if (radEvli.Checked == false && radBekar.Checked == false)
            {
                lblYildizMedeniDurum.Visible = true;
                bosluk = true;
            }

            if (radE.Checked == false && radK.Checked == false)
            {
                lblYildizCinsiyet.Visible = true;
                bosluk = true;
            }

            if (txtSoyad.Text == "")
            {
                lblYildizSoyad.Visible = true;
                txtSoyad.Focus();
                bosluk = true;
            }


            if (txtAd.Text == "")
            {
                lblYildizAd.Visible = true;
                txtAd.Focus();
                bosluk = true;
            }

            if (txtTc.Text == "")
            {
                lblYildizTcNo.Visible = true;
                txtTc.Focus();
                bosluk = true;

            }

            return bosluk;
        }

        private void FrmMusteriGuncelle_Load(object sender, EventArgs e)
        {
            ptbMusteri.Image = ClsResimIslemleri.resimGoruntule("musteri", txtTc.Text);
        }
        

        private void btnFotoSec_Click(object sender, EventArgs e)
        {
           
            ptbMusteri.Image = ClsResimIslemleri.resimYukle("Müşterinin");
        }

     
    }

}
