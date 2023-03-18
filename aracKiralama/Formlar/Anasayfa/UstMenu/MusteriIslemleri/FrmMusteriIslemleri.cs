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
    public partial class FrmMusteriIslemleri : Form
    {
        public FrmMusteriIslemleri()
        {
            InitializeComponent();
        }


        #region listele


        //müşterileri listelemek için fonksiyon
        private void musteriListele()
        {
            string sorgu = "Select id AS[İD],tc AS[TC Kimlik],ad AS[Adı],soyad AS[Soyadı],cinsiyet AS[Cinsiyeti],medeniDurumu AS[Medeni Durumu],meslek AS[Mesleği],telefon AS[Telefonu],dogumTarihi AS[Doğum Tarihi],dogumYeri AS[Doğum Yeri],ehliyetTuru AS[Ehliyet Türü],yasadigiIl AS[Yaşadığı İl] ,adres AS[Adres] From musteri Order by ad";
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "musteri");
            dataGridView1.DataSource = dataset.Tables[0];
 
        }

        private void btnMusterileriListele_Click(object sender, EventArgs e)
        {

            txtAraAd.Text = "Ada göre arama";
            txtAraAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            musteriListele();
            resimAc();
        }


       

        

       

        
        #endregion
      
        #region form açmak için kısım

        #region müşteri işlemlerini açmak için fonksiyon

        // musteriislemleri formunu açmak için fonksiyon
        public static void musteriIslemleriniAc()
        {
            FrmMusteriIslemleri frm = new FrmMusteriIslemleri();
            frm.ShowDialog();
        }

        #endregion

        #region ekle

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            txtAraAd.Text = "Ada göre arama";
            txtAraAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            yeniMusteriEkleForm();
        }

        //yenimüşteriekleme formunu açmak için fonksiyon
        public static void yeniMusteriEkleForm()
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.ShowDialog();
        }
        #endregion

        #region sil

        //musteriSil formunu açmak için fonksiyon
        public void musteriSil()
        {

            FrmMusteriSil frm = new FrmMusteriSil();
            frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           
            frm.ShowDialog();

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            musteriSil();
            txtAraAd.Text = "Ada göre arama";
            txtAraAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            musteriListele();
           

        }
        #endregion

        #region güncelle

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            musteriGuncelle();
            txtAraAd.Text = "Ada göre arama";
            txtAraAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            musteriListele();
           

        }

        private void musteriGuncelle()
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
        #endregion


      




        #endregion
      
        private void resimAc()
        {
            ptbMusteri.Image = ClsResimIslemleri.resimGoruntule("musteri", dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        //datagirid nesnesinin içeriğine tıklandığında gerçekleşecek kod
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            resimAc();

        }
  
        private void FrmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            musteriListele();
            resimAc();

        }

        private void FrmMusteriIslemleri_Activated(object sender, EventArgs e)
        {
            musteriListele();
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
                string sorgu = "select * from musteri where ad like '" + txtAraAd.Text + "%'";
                DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "musteri");
                dataGridView1.DataSource = dataset.Tables[0];
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            resimAc();
        }

       

       

       


    }
}
