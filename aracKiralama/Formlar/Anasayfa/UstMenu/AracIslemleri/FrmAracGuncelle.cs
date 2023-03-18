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
    public partial class FrmAracGuncelle : Form
    {
        public FrmAracGuncelle()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (boslukKontrol() == true)
                MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else kayitGuncelle();
        }
        private void kayitGuncelle()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Update arac set plaka=@plaka, marka=@marka, model=@model, kasaTipi=@kasaTipi, aracTuru=@aracTuru, renk=@renk, modelYili=@modelYili,vites=@vites, yakit=@yakit, km=@km, durum=@durum where id=@id";

                OleDbCommand guncelle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);

                string plaka = txtPlaka1.Text + " " + txtPlaka2.Text + " " + txtPlaka3.Text;

                guncelle.Parameters.AddWithValue("@plaka", plaka);
                guncelle.Parameters.AddWithValue("@marka", cmbMarka.Text);
                guncelle.Parameters.AddWithValue("@model", cmbModel.Text);
                guncelle.Parameters.AddWithValue("@kasaTipi", cmbKasaTipi.Text);
                guncelle.Parameters.AddWithValue("@aracTuru", lblAracTuru.Text);
                guncelle.Parameters.AddWithValue("@renk", cmbRenk.Text);
                guncelle.Parameters.AddWithValue("@modelYili", txtModelYili.Text);
                guncelle.Parameters.AddWithValue("@vites", cmbVites.Text);
                guncelle.Parameters.AddWithValue("@yakit", cmbYakit.Text);
                guncelle.Parameters.AddWithValue("@km", txtKm.Text);
                guncelle.Parameters.AddWithValue("@durum", lblDurumu.Text);
                guncelle.Parameters.AddWithValue("@id", txtId.Text);


                if (guncelle.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClsVeriTabaniIslemleri.baglanti.Close();

                // fotoğrafı kaydetmek için yazılan save komutu
                //string plakaEkle = txtPlaka1.Text + " " + txtPlaka2.Text + " " + txtPlaka3.Text;
                //ptbArac.Image.Save(Application.StartupPath + "\\img\\arac\\" + plakaEkle + ".jpg");
                this.Close();


            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Araç Kayıt Güncelleme Hata Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private bool boslukKontrol()
        {
            bool bosluk = false;

            lblYildizPlaka.Visible = false;
            lblYildizAracMarkasi.Visible = false;
            lblYildizAracModeli.Visible = false;
            lblYildizAracKasaTipi.Visible = false;

            lblYildizAracRengi.Visible = false;
            lblYildizModelYili.Visible = false;
            lblYildizYakiti.Visible = false;
            lblYildizVites.Visible = false;
            lblYildizKm.Visible = false;
            lblYildizFoto.Visible = false;

            if (ptbArac.Image == null)
            {
                lblYildizFoto.Visible = true;
                bosluk = true;
            }



            if (txtKm.Text == "   .")
            {
                lblYildizKm.Visible = true;
                txtKm.Focus();
                bosluk = true;

            }

            if (cmbYakit.Text == "" || cmbYakit.Text == "Seçiniz")
            {
                lblYildizVites.Visible = true;
                cmbYakit.Focus();
                bosluk = true;
            }

            if (cmbVites.Text == "" || cmbVites.Text == "Seçiniz")
            {
                lblYildizYakiti.Visible = true;
                cmbVites.Focus();
                bosluk = true;

            }

            if (txtModelYili.Text == "")
            {
                lblYildizModelYili.Visible = true;
                txtModelYili.Focus();
                bosluk = true;


            }

            if (cmbRenk.Text == "" || cmbRenk.Text == "Seçiniz")
            {
                lblYildizAracRengi.Visible = true;
                cmbRenk.Focus();
                bosluk = true;
            }



            if (cmbKasaTipi.Text == "" || cmbKasaTipi.Text == "Seçiniz")
            {
                lblYildizAracKasaTipi.Visible = true;
                cmbKasaTipi.Focus();
                bosluk = true;
            }

            if (cmbModel.Text == "" || cmbModel.Text == "Seçiniz")
            {
                lblYildizAracModeli.Visible = true;
                cmbModel.Focus();
                bosluk = true;
            }

            if (cmbMarka.Text == "Seçiniz" || cmbMarka.Text == "")
            {
                lblYildizAracMarkasi.Visible = true;
                cmbMarka.Focus();
                bosluk = true;
            }


            if (txtPlaka1.Text == "" || txtPlaka2.Text == "" || txtPlaka3.Text == "")
            {
                lblYildizPlaka.Visible = true;
                if (txtPlaka3.Text == "")
                    txtPlaka3.Focus();
                if (txtPlaka2.Text == "")
                    txtPlaka2.Focus();
                if (txtPlaka1.Text == "")
                    txtPlaka1.Focus();
                bosluk = true;
            }

            return bosluk;


        }

        private void markaEkle()
        {


            cmbMarka.Items.Add("Audi");
            cmbMarka.Items.Add("BMW");
            cmbMarka.Items.Add("Chevrolet");
            cmbMarka.Items.Add("Citroen");
            cmbMarka.Items.Add("Dacia");
            cmbMarka.Items.Add("Fiat");
            cmbMarka.Items.Add("Ford");
            cmbMarka.Items.Add("Honda");
            cmbMarka.Items.Add("Hyundai");
            cmbMarka.Items.Add("Jaguar");
            cmbMarka.Items.Add("Kia");
            cmbMarka.Items.Add("Mercedes");
            cmbMarka.Items.Add("Opel");
            cmbMarka.Items.Add("Peugeot");
            cmbMarka.Items.Add("Renault");
            cmbMarka.Items.Add("Seat");
            cmbMarka.Items.Add("Skoda");
            cmbMarka.Items.Add("Toyota");
            cmbMarka.Items.Add("Volkswagen");
            cmbMarka.Items.Add("Volvo");

        }

        private void FrmAracGuncelle_Load(object sender, EventArgs e)
        {
           markaEkle();
           modeller();
            //resmi görüntülemek için
            string plaka = txtPlaka1.Text + " " + txtPlaka2.Text + " " + txtPlaka3.Text;
            ptbArac.Image = ClsResimIslemleri.resimGoruntule("arac", plaka);

           
          
        }

      
       
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbMarka.Text != "Seçiniz")
                cmbModel.Enabled = true;
            else cmbModel.Enabled = false;

            modeller();
           

            cmbModel.SelectedIndex = 0;

        }

        private void modeller()
        {
            if (cmbMarka.Text == "Audi")
            {
                lblAracTuru.Text = "Üst Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("A3");
                cmbModel.Items.Add("A4");
                cmbModel.Items.Add("A5");
                cmbModel.Items.Add("A6");
                cmbModel.Items.Add("A7");
                cmbModel.Items.Add("A8");
                cmbModel.Items.Add("RS");

            }

            else if (cmbMarka.Text == "BMW")
            {
                lblAracTuru.Text = "Üst Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("116d");
                cmbModel.Items.Add("218i");
                cmbModel.Items.Add("316i");
                cmbModel.Items.Add("318i");
                cmbModel.Items.Add("320d");
                cmbModel.Items.Add("320i");
                cmbModel.Items.Add("320i ED");
                cmbModel.Items.Add("420d");
                cmbModel.Items.Add("520d");
                cmbModel.Items.Add("520i");
                cmbModel.Items.Add("525d xDrive");
            }

            else if (cmbMarka.Text == "Chevrolet")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Aveo");
                cmbModel.Items.Add("Camaro");
                cmbModel.Items.Add("Cruze");
                cmbModel.Items.Add("Kalos");
                cmbModel.Items.Add("Lacetti");


            }

            else if (cmbMarka.Text == "Citroen")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("C3");
                cmbModel.Items.Add("C4");
                cmbModel.Items.Add("C5");
                cmbModel.Items.Add("C-Elysee");
                cmbModel.Items.Add("Saxo");
                cmbModel.Items.Add("Xsara");

            }

            else if (cmbMarka.Text == "Dacia")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Lodgy");
                cmbModel.Items.Add("Logan");
                cmbModel.Items.Add("Sandero");
                cmbModel.Items.Add("Solenza");

            }

            else if (cmbMarka.Text == "Fiat")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Albea");
                cmbModel.Items.Add("Egea");
                cmbModel.Items.Add("Linea");
                cmbModel.Items.Add("Marea");
                cmbModel.Items.Add("Palio");
                cmbModel.Items.Add("Punto");
                cmbModel.Items.Add("Tempra");
            }

            else if (cmbMarka.Text == "Ford")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Fiesta");
                cmbModel.Items.Add("Focus");
                cmbModel.Items.Add("Mondeo");
                cmbModel.Items.Add("Mustang");

            }

            else if (cmbMarka.Text == "Honda")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Accord");
                cmbModel.Items.Add("Civic");
                cmbModel.Items.Add("S2000");

            }

            else if (cmbMarka.Text == "Hyundai")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Accent");
                cmbModel.Items.Add("Elantra");
                cmbModel.Items.Add("Getz");
                cmbModel.Items.Add("i10");
                cmbModel.Items.Add("i20");
                cmbModel.Items.Add("i30");
                cmbModel.Items.Add("i40");
            }

            else if (cmbMarka.Text == "Jaguar")
            {
                lblAracTuru.Text = "Üst Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("XE");
                cmbModel.Items.Add("XF");
                cmbModel.Items.Add("XJ");
                cmbModel.Items.Add("X-Type");

            }

            else if (cmbMarka.Text == "Kia")
            {
                lblAracTuru.Text = "Düşük Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Ceed");
                cmbModel.Items.Add("Cerato");
                cmbModel.Items.Add("Picanto");
                cmbModel.Items.Add("Rio");
                cmbModel.Items.Add("Seplihe");
                cmbModel.Items.Add("Venga");

            }

            else if (cmbMarka.Text == "Mercedes")
            {
                lblAracTuru.Text = "Üst Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("A 180");
                cmbModel.Items.Add("A 180 CDI");
                cmbModel.Items.Add("A 180 d");
                cmbModel.Items.Add("A 200");
                cmbModel.Items.Add("CLA 200");
                cmbModel.Items.Add("C 180");
                cmbModel.Items.Add("C 200 d");
                cmbModel.Items.Add("C 220 CDI");
                cmbModel.Items.Add("E 180");
                cmbModel.Items.Add("E 200");
                cmbModel.Items.Add("E 250 CDI");

            }

            else if (cmbMarka.Text == "Opel")
            {
                lblAracTuru.Text = "Düşük Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Astra");
                cmbModel.Items.Add("Corsa");
                cmbModel.Items.Add("Insignia");
                cmbModel.Items.Add("Vectra");

            }

            else if (cmbMarka.Text == "Peugeot")
            {
                lblAracTuru.Text = "Düşük Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("106");
                cmbModel.Items.Add("206");
                cmbModel.Items.Add("207");
                cmbModel.Items.Add("208");
                cmbModel.Items.Add("301");
                cmbModel.Items.Add("308");
                cmbModel.Items.Add("508");
            }

            else if (cmbMarka.Text == "Renault")
            {
                lblAracTuru.Text = "Düşük Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Clio");
                cmbModel.Items.Add("Fluence");
                cmbModel.Items.Add("Megane");
                cmbModel.Items.Add("Symbol");
                cmbModel.Items.Add("Talisman");
                cmbModel.Items.Add("R 9");

            }

            else if (cmbMarka.Text == "Seat")
            {
                lblAracTuru.Text = "Düşük Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Cordoba");
                cmbModel.Items.Add("Ibiza");
                cmbModel.Items.Add("Leon");
                cmbModel.Items.Add("Toledo");

            }

            else if (cmbMarka.Text == "Skoda")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Fabia");
                cmbModel.Items.Add("Octavia");
                cmbModel.Items.Add("Rapid");
                cmbModel.Items.Add("Superb");

            }

            else if (cmbMarka.Text == "Toyota")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Auris");
                cmbModel.Items.Add("Avensis");
                cmbModel.Items.Add("Corolla");
                cmbModel.Items.Add("Verso");
                cmbModel.Items.Add("Yaris");

            }

            else if (cmbMarka.Text == "Volkswagen")
            {
                lblAracTuru.Text = "Orta Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("Arteon");
                cmbModel.Items.Add("Bora");
                cmbModel.Items.Add("Golf");
                cmbModel.Items.Add("Jetta");
                cmbModel.Items.Add("Passat");
                cmbModel.Items.Add("Polo");
                cmbModel.Items.Add("Scirocco");
                cmbModel.Items.Add("VW CC");
            }

            else if (cmbMarka.Text == "Volvo")
            {
                lblAracTuru.Text = "Üst Sınıf";

                cmbModel.Items.Clear();
                cmbModel.Items.Add("Seçiniz");
                cmbModel.Items.Add("S40");
                cmbModel.Items.Add("S60");
                cmbModel.Items.Add("S80");
                cmbModel.Items.Add("S90");
                cmbModel.Items.Add("V40");

            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbModel.Text != "Seçiniz")
                cmbKasaTipi.Enabled = true;
            else cmbKasaTipi.Enabled = false;

            cmbKasaTipi.SelectedIndex = 0;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ptbArac.Image = ClsResimIslemleri.resimYukle("Aracın");
        }
    }
}
