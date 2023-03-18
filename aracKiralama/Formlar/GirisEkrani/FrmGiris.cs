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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCikis_MouseHover(object sender, EventArgs e)
        {
            lblCikis.ForeColor = Color.Red;
            this.Cursor = Cursors.Hand;
        }

        private void lblCikis_MouseLeave(object sender, EventArgs e)
        {
            lblCikis.ForeColor = Color.Black;
            this.Cursor = Cursors.Default;
        }

        private void btnGirisYap_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(boslukDoldurma()==true)
                MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else KullaniciKontrol();

        }

        private bool  boslukDoldurma()
        {
            bool bosluk = false;

            txtKullaniciAd.BackColor = Color.Goldenrod;
            txtSifre.BackColor = Color.Goldenrod;

            
           if (txtSifre.Text == "")
            {
                txtSifre.BackColor = Color.Red;
                txtSifre.Focus();
                bosluk = true;
            }
           if (txtKullaniciAd.Text == "")
            {
                txtKullaniciAd.BackColor = Color.Red;
                txtKullaniciAd.Focus();
                bosluk = true;
            }
           
            return bosluk;

            
        }

        public static string kullaniciAd, kullaniciTuru;

        private void KullaniciKontrol()
        {

            string sorgu = "Select id, kullaniciAd,sifre, kullaniciTuru from personel where kullaniciAd= '" + txtKullaniciAd.Text +
                "' and sifre= '" + txtSifre.Text + "'";

            ClsVeriTabaniIslemleri.listele(sorgu, "personel");
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "personel");
            dataGridView1.DataSource = dataset.Tables[0];

            if (dataGridView1.SelectedRows.Count == 1) // kullanici bulundu mu ?
            {
                MessageBox.Show("Kullanıcı adı ve şifre doğru\nGiriş yapılıyor...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmAnasayfa frm = new FrmAnasayfa();
                kullaniciAd = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                kullaniciTuru = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               
                frm.Show();
                this.Hide();
            }
            else
            {
                txtKullaniciAd.Text = "";
                txtSifre.Text = "";
                txtKullaniciAd.Focus();
                MessageBox.Show("Kullanıcı adı ve şifre hatalı\nLütfen tekrardan deneyiniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ptbSifreAcKapat.Image = Properties.Resources.göz;
                acKapat = false;
                txtSifre.PasswordChar = '*';
              
            }

        }

        bool acKapat = false;
        private void ptbSifreAcKapat_Click(object sender, EventArgs e)
        {
            
            // acKapat = false ise şifreyi göster demek
            // acKapat = true ise şifreyi gizle demek

            if (acKapat == false)
            {
                ptbSifreAcKapat.Image = Properties.Resources.gözKapali;
                txtSifre.PasswordChar = '\0';
                acKapat = true;
            }
            else if (acKapat == true)
            {
                ptbSifreAcKapat.Image = Properties.Resources.göz;
                txtSifre.PasswordChar = '*';
                acKapat = false;
            }

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
                ptbSifreAcKapat.Visible = false;
            else ptbSifreAcKapat.Visible = true;
        }

        private void ptbSifreAcKapat_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void ptbSifreAcKapat_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

       
        
        
    

        
    }
}
