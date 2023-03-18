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
    public partial class FrmGirisAyarlari : Form
    {
        public FrmGirisAyarlari()
        {
            InitializeComponent();
        }

        private void FrmGirisAyarlari_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = FrmGiris.kullaniciAd;
            lblKullaniciTuru.Text = FrmGiris.kullaniciTuru;
            listele();
           

        }

        private void listele()
        {
            string sorgu = "";
            string sorguYonetici = "Select id AS[İD], kullaniciAd AS[Kullanıcı Adı], sifre AS[Şifresi], kullaniciTuru AS[Kullanici Türü] from personel Order by kullaniciAd";
            string sorguKullanici = "Select id AS[İD], kullaniciAd AS[Kullanıcı Adı], sifre AS[Şifresi], kullaniciTuru AS[Kullanici Türü] from personel where kullaniciAd ='" + lblKullaniciAdi.Text + "'";
            if (lblKullaniciTuru.Text == "Yönetici")
            {
                sorgu = sorguYonetici;
                btnKullaniciEkle.Enabled = true;
                btnKullaniciSil.Enabled = true;
                txtKullaniciAd.Enabled = true;
                cmbTuru.Enabled = true;
            }
            else
            {
                sorgu = sorguKullanici;
                btnKullaniciEkle.Enabled = false;
                btnKullaniciSil.Enabled = false;
                txtKullaniciAd.Enabled = false;
                cmbTuru.Enabled = false;
            }
            ClsVeriTabaniIslemleri.listele(sorgu, "personel");
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "personel");
            dataGridView1.DataSource = dataset.Tables[0];
 
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKullaniciAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Yönetici")
                cmbTuru.SelectedIndex = 1;
            else cmbTuru.SelectedIndex = 2;

        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kullanıcı eklemek için önce personel eklemeniz gerekmektedir?\nPersonel ekleme işlemi yapılsın mı?"
                , "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                FrmPersonelIslemleri.personelEkle();
                listele();
            }
        }

        private void btnSifreyiDegistir_Click(object sender, EventArgs e)
        {
            txtSifre.BackColor = Color.White;

            if (txtSifre.Text == "")
            {
                txtSifre.BackColor = Color.Red;
                txtSifre.Focus();
                MessageBox.Show("Lütfen şifreyi bos geçmeyiniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            }
            else 
            guncelle();
            listele();
        }

        private void guncelle()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "update personel set sifre=@sifre where id=@id";
                OleDbCommand guncelle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
               
                guncelle.Parameters.AddWithValue("@sifre", txtSifre.Text);
                guncelle.Parameters.AddWithValue("@id", txtID.Text);
                
                if (guncelle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClsVeriTabaniIslemleri.baglanti.Close();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Kullanıcı Sifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
              "Seçilen Veriyi silmek istiyor musunuz?",
             "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                kayitSil();
                listele();
            }
        }

        private void kayitSil()
        {

            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Delete from personel where id=" + txtID.Text;
                OleDbCommand com = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }

                ClsVeriTabaniIslemleri.baglanti.Close();


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Kullanıcı Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

      

      

       
    }
}
