using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    public partial class FrmAramaYapma : Form
    {
        public FrmAramaYapma()
        {
            InitializeComponent();
        }

        private void FrmAramaYapma_Load(object sender, EventArgs e)
        {
            SeciliOlmaDurumu();
        }

        private void SeciliOlmaDurumu()
        {
            cmbAlan.SelectedIndex = 0;
            cmbAramaTuru.SelectedIndex = 0;
            cmbBaslik.SelectedIndex = 0;
            cmbCokluBaslik.SelectedIndex = 0;
    
        }

        private void cmbBaslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtYaziniz.Text = "";

            if (cmbBaslik.Text == "Seçiniz")
            {
                cmbAlan.Enabled = false;
                btnGuncelle.Visible = false;
                btnSil.Visible = false;
                cmbAlan.SelectedIndex = 0;
                cmbAramaTuru.SelectedIndex = 0;
                dataGridView1.DataSource = "";
            }
            else
            {
                cmbAlan.Enabled = true;
                btnGuncelle.Visible = true;
                btnSil.Visible = true;

                if (cmbBaslik.Text == "Kullanıcı")
                {
                    cmbAlan.Items.Clear();
                    cmbAlan.Items.Add("Seçiniz");
                    cmbAlan.Items.Add("Kullanıcı Adı");
                    cmbAlan.Items.Add("T.C No");
                    listele("Select id,tc,kullaniciAd,sifre from personel", "personel");
                    btnGuncelle.Text = "Kullanıcı Güncelle";
                    btnSil.Text = "Kullanıcı Sil";

                }

                else if (cmbBaslik.Text == "Personel")
                {
                    cmbAlan.Items.Clear();
                    cmbAlan.Items.Add("Seçiniz");
                    cmbAlan.Items.Add("Ad");
                    cmbAlan.Items.Add("Soyad");
                    cmbAlan.Items.Add("T.C No");
                    cmbAlan.Items.Add("Görevi");
                    listele("Select * from personel", "personel");
                    btnGuncelle.Text = "Personel Güncelle";
                    btnSil.Text = "Personel Sil";
                }

                else if (cmbBaslik.Text == "Tüm Araç")
                {
                    cmbAlan.Items.Clear();
                    cmbAlan.Items.Add("Seçiniz");
                    cmbAlan.Items.Add("Plaka");
                    cmbAlan.Items.Add("Marka");
                    cmbAlan.Items.Add("Model");
                    cmbAlan.Items.Add("Araç Türü");
                    listele("Select * from arac", "arac");
                    btnGuncelle.Visible = true;
                    btnSil.Visible = false;
                    btnGuncelle.Text = "Araç Güncelle";
                    btnSil.Text = "Araç Sil";
                }
                else if (cmbBaslik.Text == "Kiralık Araç")
                {
                    cmbAlan.Items.Clear();
                    cmbAlan.Items.Add("Seçiniz");
                    cmbAlan.Items.Add("Plaka");
                    cmbAlan.Items.Add("Marka");
                    cmbAlan.Items.Add("Model");
                    cmbAlan.Items.Add("Araç Türü");
                    listele("Select * from arac where durum = 'Kiralık'", "arac");
                    btnGuncelle.Visible = false;
                    btnSil.Visible = true;
                    btnGuncelle.Text = "Araç Güncelle";
                    btnSil.Text = "Araç Sil";
                }
                else if (cmbBaslik.Text == "Kiralanan Araç")
                {
                    cmbAlan.Items.Clear();
                    cmbAlan.Items.Add("Seçiniz");
                    cmbAlan.Items.Add("Plaka");
                    cmbAlan.Items.Add("Marka");
                    cmbAlan.Items.Add("Model");
                    cmbAlan.Items.Add("Araç Türü");
                    listele("Select * from arac where durum ='Kirada'", "arac");
                    btnGuncelle.Visible = false;
                    btnSil.Visible = false;
                    btnGuncelle.Text = "Araç Güncelle";
                    btnSil.Text = "Araç Sil";
                }

                else if (cmbBaslik.Text == "Müşteri")
                {
                    cmbAlan.Items.Clear();
                    cmbAlan.Items.Add("Seçiniz");
                    cmbAlan.Items.Add("Ad");
                    cmbAlan.Items.Add("Soyad");
                    cmbAlan.Items.Add("T.C No");
                    cmbAlan.Items.Add("Meslek");
                    listele("Select * from musteri", "musteri");
                    btnGuncelle.Text = "Müşteri Güncelle";
                    btnSil.Text = "Müşteri Sil";
                }
                else if (cmbBaslik.Text == "Sözleşme")
                {
                    cmbAlan.Items.Clear();
                    cmbAlan.Items.Add("Seçiniz");
                    cmbAlan.Items.Add("Plaka");
                    cmbAlan.Items.Add("Tc");
                    listele("Select * from kiralama", "kiralama");
                    btnGuncelle.Text = "Sözleşme Güncelle";
                    btnSil.Text = "Sözleşme İptal";
 
                }
                else if (cmbBaslik.Text == "Kiralama")
                {
                    cmbAlan.Items.Clear();
                    cmbAlan.Items.Add("Seçiniz");
                    cmbAlan.Items.Add("Plaka");
                    cmbAlan.Items.Add("Tc");
                    listele("Select * from kiralama", "kiralama");
                    btnGuncelle.Text = "Araç Güncelle";
                    btnSil.Text = "Araç Teslim";

                }


                cmbAlan.SelectedIndex = 0;
                cmbKontrol();
            }
        }

        private void aramaYapma()
        {
           string sorgu = "";
            #region Kullanıcı
            
           
            if (cmbBaslik.Text == "Kullanıcı")
            {
               
                if (cmbAlan.Text == "Kullanıcı Adı")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select id,tc,kullaniciAd,sifre from personel where kullaniciAd like'"+ txtYaziniz.Text+"%'";
                        listele(sorgu, "personel");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select id,tc,kullaniciAd,sifre from personel where kullaniciAd like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "personel");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select id,tc,kullaniciAd,sifre from personel where kullaniciAd like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }
                    
                }
                else if (cmbAlan.Text == "T.C No")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select id,tc,kullaniciAd,sifre from personel where tc like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select id,tc,kullaniciAd,sifre from personel where tc like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "personel");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select id,tc,kullaniciAd,sifre from personel where tc like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                }

            }

            #endregion

            #region Müşteri
            
           
            else if (cmbBaslik.Text == "Müşteri")
            {
                if (cmbAlan.Text == "Ad")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from musteri where ad like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "musteri");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from musteri where ad like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "musteri");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from musteri where ad like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "musteri");
                    }

                }

                else if (cmbAlan.Text == "Soyad")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from musteri where soyad like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "musteri");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from musteri where soyad like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "musteri");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from musteri where soyad like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "musteri");
                    }

                }

                else if (cmbAlan.Text == "T.C No")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from musteri where tc like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "musteri");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from musteri where tc like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "musteri");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from musteri where tc like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "musteri");
                    }

                }
            

                else if (cmbAlan.Text == "Meslek")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from musteri where meslek like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "musteri");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from musteri where meslek like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "musteri");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from musteri where meslek like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "musteri");
                    }

                }
            }
            #endregion

            #region Personel
            
           
            else if (cmbBaslik.Text == "Personel")
            {
                if (cmbAlan.Text == "Ad")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from personel where ad like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from personel where ad like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "personel");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from personel where ad like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                }

                else if (cmbAlan.Text == "Soyad")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from personel where soyad like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from personel where soyad like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "personel");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from personel where soyad like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                }

                else if (cmbAlan.Text == "T.C No")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from personel where tc like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from personel where tc like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "personel");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from personel where tc like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                }

                else if (cmbAlan.Text == "Görevi")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from personel where gorev like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from personel where gorev like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "personel");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from personel where gorev like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "personel");
                    }

                }
            }
            #endregion

            #region Tüm Araç
            
           
            else if (cmbBaslik.Text == "Tüm Araç")
            {
                if (cmbAlan.Text == "Plaka")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where plaka like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where plaka like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where plaka like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }

                else if (cmbAlan.Text == "Marka")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where marka like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where marka like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where marka like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }

                else if (cmbAlan.Text == "Model")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where model like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where model like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where model like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }

                else if (cmbAlan.Text == "Araç Türü")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where aracTuru like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where aracTuru like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where aracTuru like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }
            }
            #endregion

            #region Kiralık araç
            
           
            else if (cmbBaslik.Text == "Kiralık Araç")
            {
                if (cmbAlan.Text == "Plaka")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık'and plaka like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and plaka like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and plaka like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }

                else if (cmbAlan.Text == "Marka")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and marka like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and marka like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and marka like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }

                else if (cmbAlan.Text == "Model")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and model like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and model like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and model like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }
           
                
                else if (cmbAlan.Text == "Araç Türü")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and aracTuru like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and aracTuru like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where durum = 'Kiralık' and aracTuru like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }
            }
            #endregion

            #region Kiralanan Araç
            
           
            else if (cmbBaslik.Text == "Kiralanan Araç")
            {
                if (cmbAlan.Text == "Plaka")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and plaka like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and plaka like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and plaka like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }

                else if (cmbAlan.Text == "Marka")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and marka like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and marka like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and marka like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }

                else if (cmbAlan.Text == "Model")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and model like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and model like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and model like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }

                else if (cmbAlan.Text == "Araç Türü")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and aracTuru like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and aracTuru like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "arac");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from arac where durum ='Kirada' and aracTuru like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "arac");
                    }

                }


            }
            #endregion

            #region SözleşmeKiralama

            if (cmbBaslik.Text == "Sözleşme" || cmbBaslik.Text=="Kiralama")
            {

                if (cmbAlan.Text == "Plaka")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from kiralama where plaka like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "kiralama");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from kiralama where plaka like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "kiralama");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from kiralama where plaka like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "kiralama");
                    }

                }
                else if (cmbAlan.Text == "Tc")
                {
                    if (cmbAramaTuru.Text == "İle Başlayan")
                    {
                        sorgu = "Select * from kiralama where tc like'" + txtYaziniz.Text + "%'";
                        listele(sorgu, "kiralama");
                    }

                    else if (cmbAramaTuru.Text == "İle Biten")
                    {
                        sorgu = "Select * from kiralama where tc like '%" + txtYaziniz.Text + "'";
                        listele(sorgu, "kiralama");
                    }
                    else if (cmbAramaTuru.Text == "İçeren")
                    {
                        sorgu = "Select * from kiralama where tc like'%" + txtYaziniz.Text + "%'";
                        listele(sorgu, "kiralama");
                    }

                }

            }

            #endregion
        }

        private void cmbKontrol()
        {
            txtYaziniz.Text = "";

            if (cmbBaslik.Text == "Seçiniz" || cmbAlan.Text == "Seçiniz" || cmbAramaTuru.Text == "Seçiniz")
                txtYaziniz.Visible = false;
            else txtYaziniz.Visible = true;
 
        }

        private void cmbCokluBaslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            chbCoklu1.Checked = false;
            chbCoklu2.Checked = false;
            if (cmbCokluBaslik.Text == "Seçiniz")
            {
                txtCoklu1.Visible = false;
                txtCoklu2.Visible = false;
                chbCoklu1.Visible = false;
                chbCoklu2.Visible = false;
                btnGuncelle.Visible = false;
                btnSil.Visible = false;
                btnBirebirAra.Visible = false;
                dataGridView1.DataSource = "";
            }
            else
            {
                btnBirebirAra.Visible = true;
                btnGuncelle.Visible = true;
                btnSil.Visible = true;
                txtCoklu1.Visible = true;
                txtCoklu2.Visible = true;
                chbCoklu1.Visible = true;
                chbCoklu2.Visible = true;
                btnBirebirAra.Visible = true;
                if (cmbCokluBaslik.Text == "Tüm Araç")
                {
                    chbCoklu1.Text = "Marka";
                    chbCoklu2.Text = "Model";
                    listele("Select * from arac", "arac");
                    btnGuncelle.Visible = true;
                    btnSil.Visible = false;
                    btnGuncelle.Text = "Araç Güncelle";
                    btnSil.Text = "Araç Sil";
                  
                }
                else if (cmbCokluBaslik.Text == "Kiralık Araç")
                {
                    chbCoklu1.Text = "Marka";
                    chbCoklu2.Text = "Model";
                    listele("Select * from arac where durum='Kiralık'", "arac");
                    btnGuncelle.Visible =false;
                    btnSil.Visible = true;
                    btnGuncelle.Text = "Araç Güncelle";
                    btnSil.Text = "Araç Sil";

                }
                else if (cmbCokluBaslik.Text == "Kiralanan Araç")
                {
                    chbCoklu1.Text = "Marka";
                    chbCoklu2.Text = "Model";
                    listele("Select * from arac where durum ='Kirada' ", "arac");
                    btnGuncelle.Visible = false;
                    btnSil.Visible = false;
                    btnGuncelle.Text = "Araç Güncelle";
                    btnSil.Text = "Araç Sil";

                }
                else if(cmbCokluBaslik.Text=="Kullanıcı")
                {
                    listele("Select id,tc,kullaniciAd,sifre from personel", "personel");
                    chbCoklu1.Text = "T.C No";
                    chbCoklu2.Text = "Kullanıcı Ad";
                    btnGuncelle.Text = "Kullanıcı Güncelle";
                    btnSil.Text = "Kullanıcı Sil";
                }
                else if (cmbCokluBaslik.Text == "Personel")
                {
                    listele("Select * from personel", "personel");
                    chbCoklu1.Text = "Ad";
                    chbCoklu2.Text = "Soyad";
                    btnGuncelle.Text = "Personel Güncelle";
                    btnSil.Text = "Personel Sil";
                }
                else if (cmbCokluBaslik.Text == "Müşteri")
                {
                    listele("Select * from musteri", "musteri");
                    chbCoklu1.Text = "Ad";
                    chbCoklu2.Text = "Soyad";
                    btnGuncelle.Text = "Müşteri Güncelle";
                    btnSil.Text = "Müşteri Sil";
                }
                else if (cmbCokluBaslik.Text == "Sözleşme")
                {
                    listele("Select * from kiralama", "kiralama");
                    chbCoklu1.Text = "Plaka";
                    chbCoklu2.Text = "Tc";
                    btnGuncelle.Text = "Sözleşme Güncelle";
                    btnSil.Text = "Sözleşme İptal";
                    
                }
                else if (cmbCokluBaslik.Text == "Kiralama")
                {
                    listele("Select * from kiralama", "kiralama");
                    chbCoklu1.Text = "Plaka";
                    chbCoklu2.Text = "Tc";
                    btnGuncelle.Text = "Araç Güncelle";
                    btnSil.Text = "Araç Teslim";
 
                }
            }
        }

        private void listele(string sorgu, string tabloAdi)
        {
           
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, tabloAdi);
            dataGridView1.DataSource = dataset.Tables[0];
 
        }

        private void btnBirebirAra_Click(object sender, EventArgs e)
        {
            birebirArama();
        }

        private void birebirArama()
        {
            string sorgu;
            if (cmbCokluBaslik.Text == "Kullanıcı")
            {
                if (chbCoklu1.Checked && chbCoklu2.Checked)
                {
                    sorgu = "Select id,tc,kullaniciAd,sifre from personel where tc= '" + txtCoklu1.Text + "' and kullaniciAd= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "personel");
 
                }
                else if (chbCoklu1.Checked)
                {
                    sorgu = "Select id,tc,kullaniciAd,sifre from personel where tc= '" + txtCoklu1.Text + "'";
                     listele(sorgu, "personel");
 
                }
                else if (chbCoklu2.Checked)
                {
                    sorgu = "Select id,tc,kullaniciAd,sifre from personel where kullaniciAd= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "personel");

                }
                else
                {
                    sorgu = "Select id,tc,kullaniciAd,sifre from personel ";
                    listele(sorgu, "personel");
 
                }
                
               

            }
            else if (cmbCokluBaslik.Text == "Personel")
            {
                if (chbCoklu1.Checked && chbCoklu2.Checked)
                {
                    sorgu = "Select * from personel where ad= '" + txtCoklu1.Text + "' and soyad= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "personel");

                }
                else if (chbCoklu1.Checked)
                {
                    sorgu = "Select * from personel where ad= '" + txtCoklu1.Text + "'";
                    listele(sorgu, "personel");

                }
                else if (chbCoklu2.Checked)
                {
                    sorgu = "Select * from personel where soyad= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "personel");

                }
                else
                {
                    sorgu = "Select * from personel ";
                    listele(sorgu, "personel");

                }



            }
            else if (cmbCokluBaslik.Text == "Müşteri")
            {
                if (chbCoklu1.Checked && chbCoklu2.Checked)
                {
                    sorgu = "Select * from musteri where ad= '" + txtCoklu1.Text + "' and soyad= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "musteri");

                }
                else if (chbCoklu1.Checked)
                {
                    sorgu = "Select * from musteri where ad= '" + txtCoklu1.Text + "'";
                    listele(sorgu, "musteri");

                }
                else if (chbCoklu2.Checked)
                {
                    sorgu = "Select * from musteri where soyad= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "musteri");

                }
                else
                {
                    sorgu = "Select * from musteri ";
                    listele(sorgu, "musteri");

                }
 
            }

            else if (cmbCokluBaslik.Text == "Tüm Araç")
            {
                if (chbCoklu1.Checked && chbCoklu2.Checked)
                {
                    sorgu = "Select * from arac where marka= '" + txtCoklu1.Text + "' and model= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "arac");

                }
                else if (chbCoklu1.Checked)
                {
                    sorgu = "Select * from arac where marka= '" + txtCoklu1.Text + "'";
                    listele(sorgu, "arac");

                }
                else if (chbCoklu2.Checked)
                {
                    sorgu = "Select * from arac where model= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "arac");

                }
                else
                {
                    sorgu = "Select * from arac";
                    listele(sorgu, "arac");

                }

            }

            else if (cmbCokluBaslik.Text == "Kiralık Araç")
            {
                if (chbCoklu1.Checked && chbCoklu2.Checked)
                {
                    sorgu = "Select * from arac where durum = 'Kiralık' and marka= '" + txtCoklu1.Text + "' and model= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "arac");

                }
                else if (chbCoklu1.Checked)
                {
                    sorgu = "Select * from arac where durum = 'Kiralık' and marka= '" + txtCoklu1.Text + "'";
                    listele(sorgu, "arac");

                }
                else if (chbCoklu2.Checked)
                {
                    sorgu = "Select * from arac where durum = 'Kiralık' and model= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "arac");

                }
                else
                {
                    sorgu = "Select * from arac where durum = 'Kiralık'";
                    listele(sorgu, "arac");

                }

            }

            else if (cmbCokluBaslik.Text == "Kiralanan Araç")
            {
                if (chbCoklu1.Checked && chbCoklu2.Checked)
                {
                    sorgu = "Select * from arac where durum = 'Kirada' and marka= '" + txtCoklu1.Text + "' and model= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "arac");

                }
                else if (chbCoklu1.Checked)
                {
                    sorgu = "Select * from arac where durum = 'Kirada' and marka= '" + txtCoklu1.Text + "'";
                    listele(sorgu, "arac");

                }
                else if (chbCoklu2.Checked)
                {
                    sorgu = "Select * from arac where durum = 'Kirada' and  model= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "arac");

                }
                else
                {
                    sorgu = "Select * from arac where durum = 'Kirada'";
                    listele(sorgu, "arac");

                }

            }

            else if (cmbCokluBaslik.Text == "Sözleşme" || cmbCokluBaslik.Text == "Kiralama")
            {
                if (chbCoklu1.Checked && chbCoklu2.Checked)
                {
                    sorgu = "Select * from kiralama where plaka= '" + txtCoklu1.Text + "' and tc= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "kiralama");

                }
                else if (chbCoklu1.Checked)
                {
                    sorgu = "Select * from kiralama where plaka= '" + txtCoklu1.Text + "'";
                    listele(sorgu, "kiralama");

                }
                else if (chbCoklu2.Checked)
                {
                    sorgu = "Select * from kiralama where tc= '" + txtCoklu2.Text + "'";
                    listele(sorgu, "kiralama");

                }
                else
                {
                    sorgu = "Select * from kiralama ";
                    listele(sorgu, "kiralama");

                }

            }
 
        }

        private void chbCoklu1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCoklu1.Checked)
            {
                txtCoklu1.Enabled = true;
                txtCoklu1.Focus();
            }
            else
            {
                txtCoklu1.Enabled = false;
                txtCoklu1.Text = "";
               
            }
        }

        private void chbCoklu2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCoklu2.Checked)
            {
                txtCoklu2.Enabled = true;
                txtCoklu2.Focus();
            }
            else
            {
                txtCoklu2.Enabled = false;
                txtCoklu2.Text = "";

            }

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            cmbBaslik.SelectedIndex = 0;
            cmbAramaTuru.SelectedIndex = 0;
            cmbCokluBaslik.SelectedIndex = 0;
        }

        private void cmbAlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKontrol();
        }

        private void cmbAramaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKontrol();
        }

        private void txtYaziniz_TextChanged(object sender, EventArgs e)
        {
            aramaYapma();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }
        private void guncelle()
        {
            if (cmbCokluBaslik.Text == "Kullanıcı" || cmbBaslik.Text=="Kullanıcı")
            {
                FrmKullaniciGuncelle frm = new FrmKullaniciGuncelle();
                frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtKullaniciAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtSifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.ShowDialog();

            }
            else if (cmbCokluBaslik.Text == "Müşteri" || cmbBaslik.Text == "Müşteri")
            {
                FrmMusteriGuncelle frm = new FrmMusteriGuncelle();
                frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Erkek")
                    frm.radE.Checked = true;
                else frm.radK.Checked = true;

                if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Bekar")
                    frm.radBekar.Checked = true;
                else frm.radEvli.Checked = true;

                frm.cmbMeslek.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.txtTel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.dtpDogumTarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frm.cmbDogumYeri.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frm.cmbEhliyetTuru.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                frm.cmbYasadigiIl.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                frm.txtAdres.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();


                frm.ShowDialog();
            }

            else if (cmbCokluBaslik.Text == "Personel" || cmbBaslik.Text == "Personel")
            {
                FrmPersonelGuncelle frm = new FrmPersonelGuncelle();
                frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtTcNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Erkek")
                    frm.radE.Checked = true;
                else frm.radK.Checked = true;

                frm.txtMaas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.cmbGorev.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Evli")
                    frm.radEvli.Checked = true;
                else frm.radBekar.Checked = true;
                frm.txtTel.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frm.dtpDogumTarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frm.cmbDogumYeri.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                frm.txtAdres.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                frm.txtKullaniciAd.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                frm.txtSifre.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                frm.ShowDialog();
            }

            else if (cmbCokluBaslik.Text == "Tüm Araç" || cmbBaslik.Text == "Tüm Araç" || 
                cmbCokluBaslik.Text == "Kiralık Araç" || cmbBaslik.Text == "Kiralık Araç" ||
                cmbCokluBaslik.Text == "Kiralanan Araç" || cmbBaslik.Text == "Kiralanan Araç")
            {
                FrmAracGuncelle frm = new FrmAracGuncelle();
                frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string[] plaka = (dataGridView1.CurrentRow.Cells[1].Value.ToString()).Split(' ');
                frm.txtPlaka1.Text = plaka[0];
                frm.txtPlaka2.Text = plaka[1];
                frm.txtPlaka3.Text = plaka[2];
                frm.cmbMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.cmbModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.cmbKasaTipi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.lblAracTuru.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.cmbRenk.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.txtModelYili.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.cmbVites.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                frm.cmbYakit.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                frm.txtKm.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                frm.lblDurumu.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                frm.ShowDialog();
            }

           

 
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void sil()
        {
            if (cmbCokluBaslik.Text == "Kullanıcı" || cmbBaslik.Text == "Kullanıcı")
            {
                FrmKullaniciSil frm = new FrmKullaniciSil();
                frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtKullaniciAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.ShowDialog();
               

            }
            else if (cmbCokluBaslik.Text == "Müşteri" || cmbBaslik.Text == "Müşteri")
            {
                FrmMusteriSil frm = new FrmMusteriSil();
                frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                frm.ShowDialog();
            }

            else if (cmbCokluBaslik.Text == "Personel" || cmbBaslik.Text == "Personel")
            {
                FrmPersonelSil frm = new FrmPersonelSil();
                frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.ShowDialog();

               
            }

            else if (cmbCokluBaslik.Text == "Tüm Araç" || cmbBaslik.Text == "Tüm Araç" ||
                cmbCokluBaslik.Text == "Kiralık Araç" || cmbBaslik.Text == "Kiralık Araç" ||
                cmbCokluBaslik.Text == "Kiralanan Araç" || cmbBaslik.Text == "Kiralanan Araç")
            {
                FrmAracSil frm = new FrmAracSil();
                frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.ShowDialog();
            }

        }

      

       

       

       

    }
}
