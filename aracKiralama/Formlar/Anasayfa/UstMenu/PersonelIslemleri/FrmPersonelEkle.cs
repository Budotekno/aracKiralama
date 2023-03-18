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
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }

        #region ekle
        
       

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
          
            if (boslukKontrol() == true)
            {
                MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else tcArama(); 
        }

        private void tcArama()
        {
            bool tcKontrol = false;

            string sorgu = "Select * from personel where tc= '" + txtTcNo.Text + "'";
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
                MessageBox.Show(txtTcNo.Text + " nolu tc mevcuttur.\nAynı tc kimlik numarasını ekleyemezsiniz!\nLütfen tekrardan deneyiniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else kullanıcıAdArama();



        }

        private void kullanıcıAdArama()
        {
            bool kullanıcıAdKontrol = false;

            string sorgu = "Select * from personel where kullaniciAd= '" + txtKullaniciAd.Text + "'";
            ClsVeriTabaniIslemleri.baglanti.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kullanıcıAdKontrol = true;
                break;
            }
            ClsVeriTabaniIslemleri.baglanti.Close();
            if (kullanıcıAdKontrol == true)
            {
                MessageBox.Show(txtKullaniciAd.Text + " adlı kullanıcı mevcuttur.\nAynı kullanıcı adını ekleyemezsiniz!\nLütfen tekrardan deneyiniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else KayitEkleme();



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

            

            if (txtTel.Text == "(   )        " )
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

            if (radE.Checked==false && radK.Checked==false)
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

        private void KayitEkleme()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Insert into personel (tc, ad , soyad, cinsiyet, maas, gorev, medeniDurumu, telefon, dogumTarihi, dogumYeri, adres, kullaniciAd, sifre, kullaniciTuru)"+
                    " " + "Values(@tc, @ad , @soyad, @cinsiyet, @maas,@gorev , @medeniDurumu, @telefon, @dogumTarihi, @dogumYeri, @adres, @kullaniciAd, @sifre, @kullaniciTuru) ";
                OleDbCommand ekle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                ekle.Parameters.AddWithValue("@tc", txtTcNo.Text);
                ekle.Parameters.AddWithValue("@ad", txtAd.Text);
                ekle.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                if(radE.Checked)
                    ekle.Parameters.AddWithValue("@cinsiyet", "Erkek");
                else ekle.Parameters.AddWithValue("@cinsiyet", "Kadın");
               
                ekle.Parameters.AddWithValue("@maas", txtMaas.Text);
                ekle.Parameters.AddWithValue("@gorev", cmbGorev.Text);
                if(radEvli.Checked)
                    ekle.Parameters.AddWithValue("@medeniDurumu", "Evli");
                else ekle.Parameters.AddWithValue("@medeniDurumu", "Bekar");
                ekle.Parameters.AddWithValue("@telefon", txtTel.Text);
                ekle.Parameters.AddWithValue("@dogumTarihi", dtpDogumTarihi.Text);
                ekle.Parameters.AddWithValue("@dogumYeri", cmbDogumYeri.Text );
                ekle.Parameters.AddWithValue("@adres", txtAdres.Text);
                ekle.Parameters.AddWithValue("@kullaniciAd", txtKullaniciAd.Text);
                ekle.Parameters.AddWithValue("@sifre", txtSifre.Text);
                ekle.Parameters.AddWithValue("@kullaniciTuru", cmbKullaniciTuru.Text);
                if (ekle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                ClsVeriTabaniIslemleri.baglanti.Close();

               
                ptbPersonel.Image.Save(ClsResimIslemleri.resimKaydet("personel",txtTcNo.Text));

                this.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message,"Personel Kayıt Ekleme Hata Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #endregion

        private void FrmPersonelEkle_Load(object sender, EventArgs e)
        {
            cmbDogumYeri.SelectedIndex = 0;
            cmbGorev.SelectedIndex = 0;
            cmbKullaniciTuru.SelectedIndex = 0;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            
            ptbPersonel.Image = ClsResimIslemleri.resimYukle("Personelin");
        }

      
    }
}
