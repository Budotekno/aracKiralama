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
    public partial class FrmAracKirala : Form
    {
        public FrmAracKirala()
        {
            InitializeComponent();
        }

        private void FrmAracKirala_Load(object sender, EventArgs e)
        {
            cmbTc.SelectedIndex = 0;
            cmbPlaka.SelectedIndex = 0;
            musteriListele();
            aracListele();

        }

        private void aracListele()
        {
            try
            {
                string sorgu = "Select * from arac where durum ='Kiralık' order by plaka";
                OleDbCommand komut = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                OleDbDataReader dr;
                ClsVeriTabaniIslemleri.baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmbPlaka.Items.Add(dr["plaka"]);
                }

                ClsVeriTabaniIslemleri.baglanti.Close();



            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Araç Listeleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

  

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (boslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else kirala();
            
        }

        private void kirala()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Insert into kiralama (tc, plaka, verilisTarihi, teslimTarihi , tutar, ekTutar, toplamTutar, odemeSekli)" + " " +
                    "Values (@tc, @plaka, @verilisTarihi, @teslimTarihi , @tutar, @ekTutar, @toplamTutar, @odemeSekli) ";

                OleDbCommand ekle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                ekle.Parameters.AddWithValue("@tc", cmbTc.Text);
                ekle.Parameters.AddWithValue("@plaka", cmbPlaka.Text);
                ekle.Parameters.AddWithValue("@verilisTarihi", dtpVerilis.Text);
                ekle.Parameters.AddWithValue("@teslimTarihi", dtpTeslim.Text);
                ekle.Parameters.AddWithValue("@tutar", mtxtTutar.Text);
                ekle.Parameters.AddWithValue("@ekTutar", mtxtEkTutar.Text);
                ekle.Parameters.AddWithValue("@toplamTutar", mtxtToplamTutar.Text);
                if(rbtnKredi.Checked)
                ekle.Parameters.AddWithValue("@odemeSekli",rbtnKredi.Text);
                else ekle.Parameters.AddWithValue("@odemeSekli", rbtnNakit.Text);

                if (ekle.ExecuteNonQuery() == 1)
                {
                   // MessageBox.Show("Araç Kiralandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                ClsVeriTabaniIslemleri.baglanti.Close();
                aracDurumunuDegistirme();
                this.Close();

               

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Araç Kiralama Hata Penceresi");
               
            }

        }

        private void aracDurumunuDegistirme()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Update arac set durum=@durum where id=@id";

                OleDbCommand guncelle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);

                guncelle.Parameters.AddWithValue("@durum", "Kirada");
                guncelle.Parameters.AddWithValue("@id", txtAracID.Text);

                if (guncelle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Araç Kiralandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

                }

                ClsVeriTabaniIslemleri.baglanti.Close();


            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Araç Kiralama Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    

        private bool boslukKontrol()
        {
            bool bosluk = false;
           
            mtxtEkTutar.BackColor = Color.White;
            rbtnNakit.ForeColor = Color.Black;
            rbtnKredi.ForeColor = Color.Black;
            mtxtTutar.BackColor = Color.LightGray;
            lblYildizPlaka.Visible = false;
            lblYildizTc.Visible = false;

            if (cmbPlaka.Text == "Seçiniz")
            {
                lblYildizPlaka.Visible = true;
                bosluk = true;
            }

            if (cmbTc.Text=="Seçiniz")
            {
                lblYildizTc.Visible = true;
                bosluk = true;
            }

            if (!rbtnNakit.Checked && !rbtnKredi.Checked)
            {
                rbtnNakit.ForeColor = Color.Red;
                rbtnKredi.ForeColor = Color.Red;
                bosluk = true;
            }

            if (mtxtTutar.Text == "")
            {
                bosluk = true;
                mtxtTutar.BackColor = Color.Red;
            }

            if (mtxtEkTutar.Text=="")
            {
                mtxtEkTutar.BackColor = Color.Red;
                mtxtEkTutar.Focus();
                bosluk = true;
            }

           

            return bosluk;

        }

        private void mtxtEkTutar_TextChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (mtxtEkTutar.Text == "" || mtxtTutar.Text=="")
            {    
                 sonuc = 0;
            }
            else sonuc = Convert.ToInt32(mtxtTutar.Text) + Convert.ToInt32(mtxtEkTutar.Text);

            mtxtToplamTutar.Text = sonuc.ToString();
          
        }

        int ucret;
        private void dtpTeslim_ValueChanged(object sender, EventArgs e)
        {
            if (
                (Convert.ToDateTime(dtpVerilis.Text) <= Convert.ToDateTime(dtpTeslim.Text)) ||
                (Convert.ToDateTime(DateTime.Now.ToShortDateString())<=Convert.ToDateTime(dtpTeslim.Text))
                )
            {
               
                //timespan = iki tarih arasındaki farkı alınması gereken zamanlarda kullanılır
                //totaldays = aradaki gün sayısını vermektedir
                TimeSpan deger = Convert.ToDateTime(dtpTeslim.Text) - Convert.ToDateTime(dtpVerilis.Text);
                
                int sonuc = Convert.ToInt32(deger.TotalDays);
               
                if (sonuc == 0)
                {
                    MessageBox.Show("Aynı tarih seçemezsiniz!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    mtxtTutar.Text = "";
                    mtxtEkTutar.Text = "";
                    mtxtToplamTutar.Text = "";
                }
                else
                {
                    string sorgu="";
                    int fiyat=0;
                   
                    if (txtAracTuru.Text == "Üst Sınıf")
                         sorgu = "Select * from tanimlamalar where aracTuru='Üst Sınıf'";
                    else if (txtAracTuru.Text == "Orta Sınıf")
                         sorgu = "Select * from tanimlamalar where aracTuru='Orta Sınıf'";
                    else if (txtAracTuru.Text == "Düşük Sınıf")
                         sorgu = "Select * from tanimlamalar where aracTuru='Düşük Sınıf'";


                    try
                    {

                        OleDbCommand komut = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                        OleDbDataReader dr;
                        ClsVeriTabaniIslemleri.baglanti.Open();
                        dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            //MessageBox.Show(dr["ucret"].ToString());
                           fiyat = Convert.ToInt32(dr["ucret"]);
                        }
                        ClsVeriTabaniIslemleri.baglanti.Close();
                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message, "Fiyat Belirleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    if (txtAracTuru.Text == "Üst Sınıf")
                        ucret = sonuc * fiyat;
                    else if (txtAracTuru.Text == "Orta Sınıf")
                        ucret = sonuc * fiyat;
                    else if (txtAracTuru.Text == "Düşük Sınıf")
                        ucret = sonuc * fiyat;

                    mtxtTutar.Text = ucret.ToString();
                }
            }
            else 
            {
                
                MessageBox.Show("Lütfen geçerli bir tarih giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

       

        private void musteriListele()
        {
            try
            {
                string sorgu = "Select * from musteri order by tc";
                OleDbCommand komut = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                OleDbDataReader dr;
                ClsVeriTabaniIslemleri.baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmbTc.Items.Add(dr["tc"]);
                }

                ClsVeriTabaniIslemleri.baglanti.Close();



            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Müşteri Listeleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void MusteriBilgiler()
        {

            if (cmbTc.Text != "Seçiniz")
            {
                try
                {
                    ClsVeriTabaniIslemleri.baglanti.Open();
                    string sorgu = "select * from musteri where tc= '" + cmbTc.Text + "'";

                    // string sorgu = "select * from personel where tc='63214545148' ";
                    OleDbCommand selectsorgu = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                    OleDbDataReader kayitokuma = selectsorgu.ExecuteReader(); //sonucu kayıtokuma tanımlama

                    while (kayitokuma.Read())
                    {
                        txtMusteriID.Text = kayitokuma[0].ToString();
                        txtAd.Text = kayitokuma[2].ToString();
                        txtSoyad.Text = kayitokuma[3].ToString();
                        txtMeslek.Text = kayitokuma[6].ToString();
                        txtTel.Text = kayitokuma[7].ToString();


                    }
                    ClsVeriTabaniIslemleri.baglanti.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                txtMusteriID.Text = "";
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtMeslek.Text = "";
                txtTel.Text = "";
            }
        }

        private void cmbTc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriBilgiler();

        }

        private void AracBilgiler()
        {

            if (cmbPlaka.Text != "Seçiniz")
            {
                try
                {
                   
                    ClsVeriTabaniIslemleri.baglanti.Open();
                    string sorgu = "select * from arac where plaka= '" + cmbPlaka.Text + "'";
                    OleDbCommand selectsorgu = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                    OleDbDataReader kayitokuma = selectsorgu.ExecuteReader(); //sonucu kayıtokuma tanımlama

                    while (kayitokuma.Read())
                    {
                       
                       txtAracID.Text = kayitokuma[0].ToString();
                       txtMarka.Text = kayitokuma[2].ToString();
                       txtModel.Text = kayitokuma[3].ToString();
                       txtKasaTipi.Text = kayitokuma[4].ToString();
                       txtAracTuru.Text = kayitokuma[5].ToString();
                        
                       


                    }
                    ClsVeriTabaniIslemleri.baglanti.Close();
                    dtpTeslim.Enabled = true;
                    dtpVerilis.Enabled = true;
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                txtAracID.Text = "";
                txtMarka.Text = "";
                txtModel.Text = "";
                txtKasaTipi.Text = "";
                txtAracTuru.Text = "";
                dtpTeslim.Enabled = false;
                dtpVerilis.Enabled = false;
                
            }
        }

        private void cmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            AracBilgiler();
        }

        private void dtpVerilis_ValueChanged(object sender, EventArgs e)
        {
            if (
               Convert.ToDateTime(DateTime.Now.ToShortDateString()) > Convert.ToDateTime(dtpVerilis.Text)
               )
            {
               
                MessageBox.Show("Lütfen geçerli bir tarih giriniz!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
                dtpVerilis.Text = DateTime.Now.ToShortDateString();
            }
        }
    }
}
