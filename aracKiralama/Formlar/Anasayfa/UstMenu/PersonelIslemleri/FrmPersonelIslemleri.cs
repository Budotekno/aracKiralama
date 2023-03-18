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
    public partial class FrmPersonelIslemleri : Form
    {
        public FrmPersonelIslemleri()
        {
            InitializeComponent();
        }


        #region listeleme
        
    
       

        //personelleri listelemek için fonksiyon
        private void personelListele()
        {
            string sorgu = "Select id AS[İD],tc AS[TC Kimlik],ad AS[Adı],soyad AS[Soyadı],cinsiyet AS[Cinsiyet],maas AS[Maaşı],gorev AS[Görevi],medeniDurumu AS[Medeni Durumu],telefon AS[Telefonu],dogumTarihi AS[Doğum Tarihi],dogumYeri AS[Doğum Yeri],adres AS[Adres],kullaniciAd AS[Kullanıcı Adı],sifre AS[Şifre] , kullaniciTuru AS[Kullanıcı Türü] From personel Order by ad";
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "personel");
            dataGridView1.DataSource = dataset.Tables[0];

        }

        private void btnPersonelleriListele_Click(object sender, EventArgs e)
        {
            txtAraAd.Text = "Ada göre arama";
            txtAraAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            personelListele();
            resimAc();
        }




        #endregion


        private void FrmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            personelListele();
            resimAc();
        }

        private void FrmPersonelIslemleri_Activated(object sender, EventArgs e)
        {
            personelListele();
            resimAc();
        }

        #region form açılacak kısım

        #region personel işlemlerini açmak için

        //personelişlemleri formunu açmak için fonksiyon
        public static void personelIslemleriniAc()
        {
            FrmPersonelIslemleri frm = new FrmPersonelIslemleri();
            frm.ShowDialog();
        }
        #endregion  

        #region ekle
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            txtAraAd.Text = "Ada göre arama";
            txtAraAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            personelEkle();
        }


        //personelEkle formunu açmak için fonksiyon
        public static void personelEkle()
        {
            FrmPersonelEkle frm = new FrmPersonelEkle();
            frm.ShowDialog();
        }


        #endregion

        #region sil


        //personelSil formunu açmak için fonksiyon
        public void personelSil()
        {
            FrmPersonelSil frm = new FrmPersonelSil();
            frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();

        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            personelSil();
            txtAraAd.Text = "Ada göre arama";
            txtAraAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            personelListele();
            
        }
        #endregion

        #region güncelle

        private void personelGuncelle()
        {
            FrmPersonelGuncelle frm = new FrmPersonelGuncelle();
            frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtTcNo.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString()=="Erkek")
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
            if (dataGridView1.CurrentRow.Cells[14].Value.ToString() == "Yönetici")
                frm.cmbKullaniciTuru.SelectedIndex = 1;
            else frm.cmbKullaniciTuru.SelectedIndex = 2;
            
            frm.ShowDialog();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            personelGuncelle();
            txtAraAd.Text = "Ada göre arama";
            txtAraAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            personelListele();
            
        }

        #endregion


        #endregion

        private void resimAc()
        {
            ptbPersonel.Image = ClsResimIslemleri.resimGoruntule("personel", dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resimAc();
        }

        private void txtAraAd_Click(object sender, EventArgs e)
        {
            txtAraAd.Text = "";
        }

        private void txtAraAd_Leave(object sender, EventArgs e)
        {
            if (txtAraAd.Text == "")
            {

                txtAraAd.Text = "Ada göre arama";
                txtAraAd.ForeColor = Color.Silver;
            }
        }

        private void txtAraAd_TextChanged(object sender, EventArgs e)
        {

            if (txtAraAd.Text != "")
            {
                txtAraAd.ForeColor = Color.Black;
                string sorgu = "select id AS[İD],tc AS[TC Kimlik],ad AS[Adı],soyad AS[Soyadı],cinsiyet AS[Cinsiyet],maas AS[Maaşı],gorev AS[Görevi],medeniDurumu AS[Medeni Durumu],telefon AS[Telefonu],dogumTarihi AS[Doğum Tarihi],dogumYeri AS[Doğum Yeri],adres AS[Adres],kullaniciAd AS[Kullanıcı Adı],sifre AS[Şifre] , kullaniciTuru AS[Kullanıcı Türü]  from personel where ad like '" + txtAraAd.Text + "%'";
                DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "personel");
                dataGridView1.DataSource = dataset.Tables[0];
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            resimAc();
        }






    }
}
