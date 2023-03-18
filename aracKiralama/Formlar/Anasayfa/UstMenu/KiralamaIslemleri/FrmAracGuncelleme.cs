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
    public partial class FrmAracGuncelleme : Form
    {
        public FrmAracGuncelleme()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           if (boslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else guncelle();
        }

        #region aracGüncelleme
        
       

        private void guncelle()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "update kiralama set verilisTarihi=@verilisTarihi , teslimTarihi=@teslimTarihi, tutar=@tutar, ekTutar=@ekTutar , toplamTutar=@toplamTutar , odemeSekli=@odemeSekli where id=@id";
                OleDbCommand guncelle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                guncelle.Parameters.AddWithValue("@verisTarihi", dtpVerilis.Text);
                guncelle.Parameters.AddWithValue("@teslimTarihi", dtpTeslim.Text);
                guncelle.Parameters.AddWithValue("@tutar", mtxtTutar.Text);
                guncelle.Parameters.AddWithValue("@ekTutar", mtxtEkTutar.Text);
                guncelle.Parameters.AddWithValue("@toplamTutar", mtxtToplamTutar.Text);
                if(rbtnNakit.Checked)
                    guncelle.Parameters.AddWithValue("@odemeSekli", "Nakit");
                else guncelle.Parameters.AddWithValue("@odemeSekli", "Kredi Kartı");
                guncelle.Parameters.AddWithValue("@id", txtID.Text);

                if (guncelle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                ClsVeriTabaniIslemleri.baglanti.Close();



            }
            catch (Exception hata)
            {
                ClsVeriTabaniIslemleri.baglanti.Close();
                ClsLogIslemleri.logEkleme("Araç Kiralama Tablosu", "Araç Kiralama Güncelleme Hatası", hata.Message);
                MessageBox.Show(hata.Message, "Araç Kiralama Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        private bool boslukKontrol()
        {
            bool bosluk = false;
            mtxtEkTutar.BackColor = Color.White;
            mtxtTutar.BackColor = Color.LightGray;
          

            if (mtxtTutar.Text == "")
            {
                bosluk = true;
                mtxtTutar.BackColor = Color.Red;
            }

            if (mtxtEkTutar.Text == "")
            {
                mtxtEkTutar.BackColor = Color.Red;
                mtxtEkTutar.Focus();
                bosluk = true;
            }

            return bosluk;

        }

        #endregion

        private void dtpVerilis_ValueChanged(object sender, EventArgs e)
        {/*
            if (
              Convert.ToDateTime(DateTime.Now.ToShortDateString()) > Convert.ToDateTime(dtpVerilis.Text)
              )
            {

                MessageBox.Show("Lütfen geçerli bir tarih giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpVerilis.Text = DateTime.Now.ToShortDateString();
            }*/
        }

        private void mtxtEkTutar_TextChanged(object sender, EventArgs e)
        {
            int sonuc;
            if (mtxtEkTutar.Text == "" || mtxtTutar.Text == "")
            {
                sonuc = 0;
            }
            else sonuc = Convert.ToInt32(mtxtTutar.Text) + Convert.ToInt32(mtxtEkTutar.Text);

            mtxtToplamTutar.Text = sonuc.ToString();
        }

        int ucret;
        byte hak = 0;
        private void dtpTeslim_ValueChanged(object sender, EventArgs e)
        {
            hak++;

            if (hak == 2)
            {
                if (
                      (Convert.ToDateTime(dtpVerilis.Text) <= Convert.ToDateTime(dtpTeslim.Text)) ||
                      (Convert.ToDateTime(DateTime.Now.ToShortDateString()) <= Convert.ToDateTime(dtpTeslim.Text))
                      )
                {

                    //timespan = iki tarih arasındaki farkı alınması gereken zamanlarda kullanılır
                    //totaldays = aradaki gün sayısını vermektedir
                    TimeSpan deger = Convert.ToDateTime(dtpTeslim.Text) - Convert.ToDateTime(dtpVerilis.Text);

                    int sonuc = Convert.ToInt32(deger.TotalDays);

                    if (sonuc == 0)
                    {
                        MessageBox.Show("Aynı tarih seçemezsiniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mtxtTutar.Text = "";
                        mtxtEkTutar.Text = "";
                        mtxtToplamTutar.Text = "";
                    }
                    else
                    {
                        string sorgu = "";
                        int fiyat = 0;

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
            
        }

        private void FrmAracGuncelleme_Load(object sender, EventArgs e)
        {

            aracTuru();
        }

        private void aracTuru()
        {

          
                try
                {

                    ClsVeriTabaniIslemleri.baglanti.Open();
                    string sorgu = "select * from arac where plaka= '" + txtPlaka.Text+ "'";
                    OleDbCommand selectsorgu = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                    OleDbDataReader kayitokuma = selectsorgu.ExecuteReader(); //sonucu kayıtokuma tanımlama

                    while (kayitokuma.Read())
                    {
                        txtAracTuru.Text = kayitokuma[5].ToString();

                    }
                    ClsVeriTabaniIslemleri.baglanti.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

         
           
        }
            
       
    }
}
