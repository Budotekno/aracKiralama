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
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        #region kayıt ekleme
        
       
        private void btnEkle_Click(object sender, EventArgs e)
        {
           if(boslukKontrol() == true)
               MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else tcArama();
        }

        private void tcArama()
        {
            bool tcKontrol = false;
           
            string sorgu = "Select * from musteri where tc= '" + txtTc.Text + "'";
            ClsVeriTabaniIslemleri.baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tcKontrol = true;
                break;
            }
            ClsVeriTabaniIslemleri.baglanti.Close();
            if (tcKontrol == true)
            {
                MessageBox.Show(txtTc.Text + " nolu tc mevcuttur.\nAynı tc kimlik numarasını ekleyemezsiniz!\nLütfen tekrardan deneyiniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else kayitEkle();



        }

        private void kayitEkle()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Insert into musteri (tc, ad, soyad, cinsiyet, medeniDurumu, meslek, telefon, dogumTarihi, dogumYeri, ehliyetTuru, yasadigiIl, adres)" + " " +
                    "Values (@tc, @ad, @soyad, @cinsiyet, @medeniDurumu, @meslek, @telefon, @dogumTarihi, @dogumYeri, @ehliyetTuru, @yasadigiIl, @adres) ";

                OleDbCommand ekle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                ekle.Parameters.AddWithValue("@tc", txtTc.Text);
                ekle.Parameters.AddWithValue("@ad", txtAd.Text);
                ekle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                if(radE.Checked)
                    ekle.Parameters.AddWithValue("@cinsiyet", "Erkek");
                else ekle.Parameters.AddWithValue("@cinsiyet", "Kadın");

                if(radEvli.Checked)
                    ekle.Parameters.AddWithValue("@medeniDurumu", "Evli");
                else ekle.Parameters.AddWithValue("@medeniDurumu", "Bekar");
                
                
                ekle.Parameters.AddWithValue("@meslek", cmbMeslek.Text);
                ekle.Parameters.AddWithValue("@telefon", txtTel.Text);
                ekle.Parameters.AddWithValue("@dogumTarihi", dtpDogumTarihi.Text);
                ekle.Parameters.AddWithValue("@dogumYeri", cmbDogumYeri.Text);
                ekle.Parameters.AddWithValue("@ehliyetTuru", cmbEhliyetTuru.Text);
                ekle.Parameters.AddWithValue("@yasadigiIl", cmbYasadigiIl.Text);
                ekle.Parameters.AddWithValue("@adres", txtAdres.Text);

                if(ekle.ExecuteNonQuery()==1)
                    MessageBox.Show("Kayıt eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClsVeriTabaniIslemleri.baglanti.Close();

                ptbFoto.Image.Save(ClsResimIslemleri.resimKaydet("musteri",txtTc.Text));
  
                this.Close();
                

            }
            catch (Exception hata)
            {
                ClsVeriTabaniIslemleri.baglanti.Close();
                ClsLogIslemleri.logEkleme("Personel Tablosu", "Personel Ekleme Hatası", hata.Message);
                MessageBox.Show(hata.Message,"Müşteri Kayıt Ekleme Hata Penceresi");
                
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

            if (ptbFoto.Image == null)
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

            if (cmbYasadigiIl.Text == "" || cmbYasadigiIl.Text=="Seçiniz")
            {
                lblYildizYasadıgıİl.Visible = true;
                cmbYasadigiIl.Focus();
                bosluk = true;
            }

            if (cmbEhliyetTuru.Text == "" || cmbEhliyetTuru.Text=="Seçiniz")
            {
                lblYildizEhliyetTuru.Visible = true;
                cmbEhliyetTuru.Focus();
                bosluk = true;
            }

            if (cmbDogumYeri.Text == "" || cmbDogumYeri.Text=="Seçiniz")
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

            if (cmbMeslek.Text=="" || cmbMeslek.Text=="Seçiniz")
            {
                lblYildizMeslek.Visible = true;
             //   txtMeslek.Focus();
                bosluk = true;

            }

            if (radEvli.Checked==false && radBekar.Checked==false)
            {
                lblYildizMedeniDurum.Visible = true;
                bosluk = true;
            }

            if(radE.Checked==false && radK.Checked==false)
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

        #endregion

       
        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            ptbFoto.Image = ClsResimIslemleri.resimYukle("Müşterinin");
           
        }

      
        
      
       
    }
}
