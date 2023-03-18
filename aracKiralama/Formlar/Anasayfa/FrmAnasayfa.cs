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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }


        #region Formları açmak için kullanılacak yer

        //kullanıcı işlemleri formunu açmak için fonksiyon
        private void btnKullaniciIslemleri_Click_1(object sender, EventArgs e)
        {
            FrmKullaniciIslemleri.kullaniciIslemleri();
        }


        //personel işlemleri formunu açmak için fonksiyon
        private void btnPersonelIslemleri_Click_1(object sender, EventArgs e)
        {
            FrmPersonelIslemleri.personelIslemleriniAc();
        }

        //araç işlemleri formunu açmak için fonksiyon
        private void btnAracIslemleri_Click(object sender, EventArgs e)
        {
            FrmAracIslemleri.aracIslemleriniAc();
        }


        // müşteri işlemleri formunu açmak için fonksiyon
        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            FrmMusteriIslemleri.musteriIslemleriniAc();
        }


        #endregion

        #region Çıkış yapılacak kısım

        // Çıkıs fonksiyonu
        private void Cikis()
        {
            if (MessageBox.Show("Uygulamadan çıkılsın mı", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                Application.Exit();
            
               

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
           Cikis();

        }

        

        // formdaki X simgesine basınca gerçekleşen olay
        private void FrmAnasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Uygulamadan çıkılsın mı", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No)
            e.Cancel = true;

        }

        #endregion

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {

            lblTarih.Text ="Tarih : " + DateTime.Now.ToLongDateString();
            lblSaat.Text = "   |    Saat : " + DateTime.Now.ToLongTimeString();
            lblKullaniciAd.Text = FrmGiris.kullaniciAd;
            lblKullaniciTuru.Text = FrmGiris.kullaniciTuru;
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = "   |    Saat : " + DateTime.Now.ToLongTimeString();
        }

        private void btnAramaYapma_Click(object sender, EventArgs e)
        {
            FrmAramaYapma frm = new FrmAramaYapma();
            frm.ShowDialog();
        }

        private void btnHakkimda_Click(object sender, EventArgs e)
        {
            FrmHakkimda frm = new FrmHakkimda();
            frm.ShowDialog();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FrmLogIslemleri frm = new FrmLogIslemleri();
            frm.ShowDialog();
        }

        private void btnKiralamaIslemleri_Click(object sender, EventArgs e)
        {
            FrmKiralamaIslemleri frm = new FrmKiralamaIslemleri();
            frm.ShowDialog();
        }

        private void btnSozlesmeIslemleri_Click(object sender, EventArgs e)
        {
            FrmSozlesmeIslemleri frm = new FrmSozlesmeIslemleri();
            frm.ShowDialog();
        }

        private void FrmAnasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisAyarlari_Click(object sender, EventArgs e)
        {
            FrmGirisAyarlari frm = new FrmGirisAyarlari();
            frm.ShowDialog();
        }

        private void genelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciGenel frm = new FrmKullaniciGenel();
            if (FrmGiris.kullaniciTuru != "Yönetici")
            {
                MessageBox.Show("Bu raporu görme yetkiniz yoktur!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else 
            frm.ShowDialog();
        }

        private void kullanıcıTürüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciKullaniciTuru frm = new FrmKullaniciKullaniciTuru();
            if (FrmGiris.kullaniciTuru != "Yönetici")
            {
                MessageBox.Show("Bu raporu görme yetkiniz yoktur!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else frm.ShowDialog();
        }

        private void genelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMusteriGenel frm = new FrmMusteriGenel();
            frm.ShowDialog();
        }

        private void meslekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriMeslek frm = new FrmMusteriMeslek();
            frm.ShowDialog();
        }

        private void genelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPersonelGenel frm = new FrmPersonelGenel();
            frm.ShowDialog();
        }

        private void görevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelGorev frm = new FrmPersonelGorev();
            frm.ShowDialog();
        }

        private void genelToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmKiralamaGenel frm = new FrmKiralamaGenel();
            frm.ShowDialog();

        }

        private void ödemeŞekliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKiralamaOdemeSekli frm = new FrmKiralamaOdemeSekli();
            frm.ShowDialog();
        }

        private void genelToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmSozlesmeGenel frm = new FrmSozlesmeGenel();
            frm.ShowDialog();
        }

        private void genelToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmAracGenel frm = new FrmAracGenel();
            frm.ShowDialog();
        }

        private void markaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAracMarka frm = new FrmAracMarka();
            frm.ShowDialog();
        }

        private void btnFiyatlandırma_Click(object sender, EventArgs e)
        {
            FrmTanimlamaFiyatlandirma frm = new FrmTanimlamaFiyatlandirma();
            frm.ShowDialog();
        }

        private void genelToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmLogGenel frm = new FrmLogGenel();
            frm.ShowDialog();
        }

        private void hataYeriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogHataYeri frmm = new FrmLogHataYeri();
            frmm.ShowDialog();
        }

        

       

       

        
       




       
       

        

        







    }
}
