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
    public partial class FrmKullaniciIslemleri : Form
    {
        public FrmKullaniciIslemleri()
        {
            InitializeComponent();
        }

        #region form açma
       

        #region kullanıcı işlemleri fomunu açma

        //kullaniciıslemleri formunu açmak için fonksiyon
        public static void kullaniciIslemleri()
        {
            FrmKullaniciIslemleri frm = new FrmKullaniciIslemleri();
            frm.ShowDialog();
        }

        #endregion

        #region ekle
        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            txtAraKullaniciAd.Text = "Kullanıcı ada göre arama";
            txtAraKullaniciAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            if( MessageBox.Show("Kullanıcı eklemek için önce personel eklemeniz gerekmektedir?\nPersonel ekleme işlemi yapılsın mı?"
                ,"Bilgilendirme",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            FrmPersonelIslemleri.personelEkle();

        }

        
        #endregion
    
        #region silme
        public void kullaniciSil()
        {
            FrmKullaniciSil frm = new FrmKullaniciSil();
            frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtKullaniciAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.ShowDialog();
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            kullaniciSil();
            txtAraKullaniciAd.Text = "Kullanıcı ada göre arama";
            txtAraKullaniciAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            kullaniciListele();
           
        }
        #endregion

        #region güncelle

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kullaniciGuncelle();
            txtAraKullaniciAd.Text = "Kullanıcı ada göre arama";
            txtAraKullaniciAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            kullaniciListele();
            
        }

        public void kullaniciGuncelle()
        {
            FrmKullaniciGuncelle frm = new FrmKullaniciGuncelle();
            frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtKullaniciAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtSifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Yönetici")
                frm.cmbKullaniciTuru.SelectedIndex = 1;
            else frm.cmbKullaniciTuru.SelectedIndex = 2;
            frm.eskiKullaniciAd = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            frm.ShowDialog();
        }
        #endregion

        #endregion


        #region listeleme
        private void btnKullanicilariListele_Click(object sender, EventArgs e)
        {
           
            txtAraKullaniciAd.Text = "Kullanıcı ada göre arama";
            txtAraKullaniciAd.ForeColor = Color.Silver;
            dataGridView1.Focus();
            kullaniciListele();
            resimAc();
        }

       //müşterileri listelemek için fonksiyon
        private void kullaniciListele()
        {
            string sorgu = "";
            string sorguYonetici = "Select id AS[İD],tc AS[TC Kimlik No], kullaniciAd AS[Kullanıcı Adı], sifre AS[Şifresi], kullaniciTuru AS[Kullanici Türü] from personel Order by kullaniciAd";
            string sorguKullanici = "Select id AS[İD],tc AS[TC Kimlik No], kullaniciAd AS[Kullanıcı Adı], sifre AS[Şifresi], kullaniciTuru AS[Kullanici Türü] from personel where kullaniciAd='"+FrmGiris.kullaniciAd +"'";
            if (FrmGiris.kullaniciTuru == "Yönetici")
                sorgu = sorguYonetici;
            else sorgu = sorguKullanici;
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "personel");
            dataGridView1.DataSource = dataset.Tables[0];
 
        }

        #endregion

        #region load ve aktiveted olayı

        private void FrmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            kullaniciListele();
            resimAc();
            if (FrmGiris.kullaniciTuru == "Yönetici")
            {
                btnKullaniciEkle.Enabled = true;
                btnKullaniciSil.Enabled = true;
                txtAraKullaniciAd.Enabled = true;
            }
            else
            {
                txtAraKullaniciAd.Enabled = false;
                btnKullaniciEkle.Enabled = false;
                btnKullaniciSil.Enabled = false;
 
            }
        }

        private void FrmKullaniciIslemleri_Activated(object sender, EventArgs e)
        {
            kullaniciListele();
            resimAc();
            if (FrmGiris.kullaniciTuru == "Yönetici")
            {
                btnKullaniciEkle.Enabled = true;
                btnKullaniciSil.Enabled = true;
                txtAraKullaniciAd.Enabled = true;
            }
            else
            {
                txtAraKullaniciAd.Enabled = false;
                btnKullaniciEkle.Enabled = false;
                btnKullaniciSil.Enabled = false;

            }
        }

        #endregion

        private void resimAc()
        {
            ptbKullanici.Image = ClsResimIslemleri.resimGoruntule("personel", dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            resimAc();
        }

        private void txtAraKullaniciAd_Click(object sender, EventArgs e)
        {
            txtAraKullaniciAd.Text = "";
        }

        private void txtAraKullaniciAd_Leave(object sender, EventArgs e)
        {
            if (txtAraKullaniciAd.Text == "")
            {
               
                txtAraKullaniciAd.Text = "Kullanıcı ada göre arama";
                txtAraKullaniciAd.ForeColor = Color.Silver;
            }
        }

        private void txtAraKullaniciAd_TextChanged(object sender, EventArgs e)
        {
            if ( txtAraKullaniciAd.Text != "")
            {
                txtAraKullaniciAd.ForeColor = Color.Black;
                string sorgu = "select id AS[İD],tc AS[TC Kimlik No], kullaniciAd AS[Kullanıcı Adı], sifre AS[Şifresi], kullaniciTuru AS[Kullanici Türü]  from personel where kullaniciAd like '" + txtAraKullaniciAd.Text + "%'";
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
