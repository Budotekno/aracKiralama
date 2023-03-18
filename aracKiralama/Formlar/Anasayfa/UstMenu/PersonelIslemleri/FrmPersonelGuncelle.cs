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
    public partial class FrmPersonelGuncelle : Form
    {
        public FrmPersonelGuncelle()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (boslukKontrol() == true)
            {
                MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else KayitGuncelleme();
        }


        private void KayitGuncelleme()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "update personel set tc=@tc, ad=@ad , soyad=@soyad, cinsiyet=@cinsiyet, maas=@maas,gorev=@gorev , medeniDurumu=@medeniDurumu, telefon=@telefon, dogumTarihi=@dogumTarihi, dogumYeri=@dogumYeri, adres=@adres, kullaniciAd=@kullaniciAd, sifre=@sifre, kullaniciTuru=@kullaniciTuru where id=@id";
                OleDbCommand guncelle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                guncelle.Parameters.AddWithValue("@tc", txtTcNo.Text);
                guncelle.Parameters.AddWithValue("@ad", txtAd.Text);
                guncelle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                if (radE.Checked)
                    guncelle.Parameters.AddWithValue("@cinsiyet", "Erkek");
                else guncelle.Parameters.AddWithValue("@cinsiyet", "Kadın");

                guncelle.Parameters.AddWithValue("@maas", txtMaas.Text);
                guncelle.Parameters.AddWithValue("@gorev", cmbGorev.Text);
                if (radEvli.Checked)
                    guncelle.Parameters.AddWithValue("@medeniDurumu", "Evli");
                else guncelle.Parameters.AddWithValue("@medeniDurumu", "Bekar");
                guncelle.Parameters.AddWithValue("@telefon", txtTel.Text);
                guncelle.Parameters.AddWithValue("@dogumTarihi", dtpDogumTarihi.Text);
                guncelle.Parameters.AddWithValue("@dogumYeri", cmbDogumYeri.Text);
                guncelle.Parameters.AddWithValue("@adres", txtAdres.Text);
                guncelle.Parameters.AddWithValue("@kullaniciAd", txtKullaniciAd.Text);
                guncelle.Parameters.AddWithValue("@sifre", txtSifre.Text);
                guncelle.Parameters.AddWithValue("@kullaniciTuru", cmbKullaniciTuru.Text);
                guncelle.Parameters.AddWithValue("@id", txtId.Text);
                FrmGiris.kullaniciAd = txtKullaniciAd.Text;
                FrmGiris.kullaniciTuru = cmbKullaniciTuru.Text;
                if (guncelle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt güncellendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();

                }
                ClsVeriTabaniIslemleri.baglanti.Close();

                // fotoğrafı seçmek için yazılan save komutu
               // ptbPersonel.Image.Save(Application.StartupPath + "\\img\\personel\\" + txtTcNo.Text + ".jpg");

                this.Close();

            }
            catch (Exception hata)
            {
                ClsVeriTabaniIslemleri.baglanti.Close();
                ClsLogIslemleri.logEkleme("Personel Tablosu", "Personel Güncelleme Hatası", hata.Message);
                MessageBox.Show(hata.Message, "Personel Kayıt Güncelleme Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool boslukKontrol()
        {
            bool bosluk = false;

            lblYildizTcNo.Visible = false;
            lblYildizAd.Visible = false;
            lblYildizSoyad.Visible = false;
            lblYildizCinsiyet.Visible = false;
            lblYildizMaas.Visible = false;
            lblYildizGorev.Visible = false;
            lblYildizMedeniDurumu.Visible = false;
            lblYildizTel.Visible = false;
            lblYildizDogumYeri.Visible = false;
            lblYildizAdres.Visible = false;
            lblYildizKullaniciAd.Visible = false;
            lblYildizSifre.Visible = false;
            lblYildizFoto.Visible = false;
            lblYildizKullaniciTuru.Visible = false;

            if (ptbPersonel.Image == null)
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


            if (txtAdres.Text == "")
            {
                lblYildizAdres.Visible = true;
                txtAdres.Focus();
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

            if (cmbGorev.Text == "" || cmbGorev.Text == "Seçiniz")
            {
                lblYildizGorev.Visible = true;
                cmbGorev.Focus();
                bosluk = true;
            }



            if (txtMaas.Text == "  .")
            {
                lblYildizMaas.Visible = true;
                txtMaas.Focus();
                bosluk = true;
            }



            if (radBekar.Checked == false && radEvli.Checked == false)
            {
                lblYildizMedeniDurumu.Visible = true;

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
            if (txtTcNo.Text == "")
            {
                lblYildizTcNo.Visible = true;
                txtTcNo.Focus();
                bosluk = true;

            }

            return bosluk;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ptbPersonel.Image = ClsResimIslemleri.resimYukle("Personelin");
        }
       
        private void FrmPersonelGuncelle_Load(object sender, EventArgs e)
        {
            ptbPersonel.Image = ClsResimIslemleri.resimGoruntule("personel", txtTcNo.Text);
        }
    }
}
