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
    public partial class FrmAracIslemleri : Form
    {
        public FrmAracIslemleri()
        {
            InitializeComponent();
        }

        #region Formları açacak kısım

        #region Araç işlemleri formunu açmak içim
        //aracislemleri formunu açmak için fonksiyon
        public static void aracIslemleriniAc()
        {
            FrmAracIslemleri frm = new FrmAracIslemleri();
            frm.ShowDialog();



        }
        #endregion

        #region Araç ekleme

        private void btnYeniAracEkle_Click(object sender, EventArgs e)
        {
            txtAraMarka.Text = "Markaya göre arama";
            txtAraMarka.ForeColor = Color.Silver;
            dataGridView1.Focus();

            yeniAracEkle();
        }

        //yeniaraçekle formunu açmak için fonksiyon
        public static void yeniAracEkle()
        {
            FrmYeniAracEkle frm = new FrmYeniAracEkle();
            frm.ShowDialog();


        }
        
        #endregion

        #region Araç silme

        //frmaracsil formunu açmak için fonksiyon
        public void aracSil()
        {
            FrmAracSil frm = new FrmAracSil();
            frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.ShowDialog();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            aracSil();
            txtAraMarka.Text = "Markaya göre arama";
            txtAraMarka.ForeColor = Color.Silver;
            dataGridView1.Focus();

            string sorgu = "Select id AS[İD],plaka AS[Plaka],marka AS[Marka],model AS[Model],kasaTipi AS[Kasa Tipi],aracTuru AS[Araç Türü],renk AS[Renk],modelYili AS[Model Yılı],vites AS[Vites],yakit AS[Yakıt],km AS[Kilometre],durum AS[Durumu] from arac Order by marka";
            aracListele(sorgu);
            lblBasllik.Text = "Tüm Araç Listesi";
            

        }

        #endregion

        #region Araç güncelle
        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            aracGuncelle();
            txtAraMarka.Text = "Markaya göre arama";
            txtAraMarka.ForeColor = Color.Silver;
            dataGridView1.Focus();

            string sorgu = "Select id AS[İD],plaka AS[Plaka],marka AS[Marka],model AS[Model],kasaTipi AS[Kasa Tipi],aracTuru AS[Araç Türü],renk AS[Renk],modelYili AS[Model Yılı],vites AS[Vites],yakit AS[Yakıt],km AS[Kilometre],durum AS[Durumu] from arac Order by marka";
            aracListele(sorgu);
            lblBasllik.Text = "Tüm Araç Listesi";
            
        }
        private void aracGuncelle()
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
        #endregion



        


        #endregion

        #region Araç listeleme

      


        //araçları listelemek için fonksiyon
        private void aracListele(string sorgu)
        {
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "arac");
            dataGridView1.DataSource = dataset.Tables[0];
        } 

       //bütün araçları listeler
        private void btnAraclariListele_Click(object sender, EventArgs e)
        {
            txtAraMarka.Text = "Markaya göre arama";
            txtAraMarka.ForeColor = Color.Silver;
            dataGridView1.Focus();
            btnAracGuncelle.Visible = true;
            btnAracSil.Visible = true;
            btnAracSil.Enabled = false;

            string sorgu = "Select id AS[İD],plaka AS[Plaka],marka AS[Marka],model AS[Model],kasaTipi AS[Kasa Tipi],aracTuru AS[Araç Türü],renk AS[Renk],modelYili AS[Model Yılı],vites AS[Vites],yakit AS[Yakıt],km AS[Kilometre],durum AS[Durumu] from arac Order by marka";
            aracListele(sorgu);
            lblBasllik.Text = "Tüm Araç Listesi";
            aracGoruntule();
           
        }

        // sadece kiralık araçları listeler
        private void btnKiralikAraclar_Click(object sender, EventArgs e)
        {
            txtAraMarka.Text = "Markaya göre arama";
            txtAraMarka.ForeColor = Color.Silver;
            dataGridView1.Focus();
            btnAracGuncelle.Visible = false;
            btnAracSil.Visible = true;
            btnAracSil.Enabled = true;

            string sorgu = "Select id AS[İD],plaka AS[Plaka],marka AS[Marka],model AS[Model],kasaTipi AS[Kasa Tipi],aracTuru AS[Araç Türü],renk AS[Renk],modelYili AS[Model Yılı],vites AS[Vites],yakit AS[Yakıt],km AS[Kilometre],durum AS[Durumu] from arac where durum = 'Kiralık' Order by marka";
            aracListele(sorgu);
            aracGoruntule();
            lblBasllik.Text = "Kiralık Araç Listesi";
        }
     
        // sadece kiralanan araçları listeler
        private void btnKiralananAraclar_Click(object sender, EventArgs e)
        {
            txtAraMarka.Text = "Markaya göre arama";
            txtAraMarka.ForeColor = Color.Silver;
            dataGridView1.Focus();
            btnAracGuncelle.Visible = false;
            btnAracSil.Visible = false;

            string sorgu = "Select id AS[İD],plaka AS[Plaka],marka AS[Marka],model AS[Model] from arac where durum = 'Kirada' Order by marka";
            aracListele(sorgu);
            aracGoruntule();
            lblBasllik.Text = "Kiralanan Araç Listesi";
        }
       

     


        #endregion

        #region load ve aktiveted olayları

        private void FrmAracIslemleri_Load(object sender, EventArgs e)
        {
            string sorgu = "Select id AS[İD],plaka AS[Plaka],marka AS[Marka],model AS[Model],kasaTipi AS[Kasa Tipi],aracTuru AS[Araç Türü],renk AS[Renk],modelYili AS[Model Yılı],vites AS[Vites],yakit AS[Yakıt],km AS[Kilometre],durum AS[Durumu] from arac Order by marka";
            aracListele(sorgu);
            aracGoruntule();
            lblBasllik.Text = "Tüm Araç Listesi";
        }

        private void FrmAracIslemleri_Activated(object sender, EventArgs e)
        {
            string sorgu = "Select id AS[İD],plaka AS[Plaka],marka AS[Marka],model AS[Model],kasaTipi AS[Kasa Tipi],aracTuru AS[Araç Türü],renk AS[Renk],modelYili AS[Model Yılı],vites AS[Vites],yakit AS[Yakıt],km AS[Kilometre],durum AS[Durumu] from arac Order by marka";
            aracListele(sorgu);
            aracGoruntule();
            lblBasllik.Text = "Tüm Araç Listesi";
        }
        #endregion


        private void aracGoruntule()
        {
            ptbArac.Image = ClsResimIslemleri.resimGoruntule("arac", dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            aracGoruntule();

        }

        private void txtAraMarka_TextChanged(object sender, EventArgs e)
        {
            if (txtAraMarka.Text != "")
            {
                string sorgu = "";
                txtAraMarka.ForeColor = Color.Black;

                if (lblBasllik.Text == "Tüm Araç Listesi")
                    sorgu = "select id AS[İD],plaka AS[Plaka],marka AS[Marka],model AS[Model],kasaTipi AS[Kasa Tipi],aracTuru AS[Araç Türü],renk AS[Renk],modelYili AS[Model Yılı],vites AS[Vites],yakit AS[Yakıt],km AS[Kilometre],durum AS[Durumu] from arac where marka like '" + txtAraMarka.Text + "%'";
                else if (lblBasllik.Text == "Kiralık Araç Listesi")
                    sorgu = "select id AS[İD],plaka AS[Plaka],marka AS[Marka],model AS[Model],kasaTipi AS[Kasa Tipi],aracTuru AS[Araç Türü],renk AS[Renk],modelYili AS[Model Yılı],vites AS[Vites],yakit AS[Yakıt],km AS[Kilometre],durum AS[Durumu] from arac where durum ='Kiralık' and marka like '" + txtAraMarka.Text + "%'";
                else if (lblBasllik.Text == "Kiralanan Araç Listesi")
                    sorgu = "select id AS[İD], plaka AS[Plaka], marka AS[Marka], model AS[Model] from arac where durum ='Kirada' and marka like '" + txtAraMarka.Text + "%'";

                aracListele(sorgu);
            }
            

           
        }

        private void txtAraMarka_Click(object sender, EventArgs e)
        {
            txtAraMarka.Text = "";
        }

        private void txtAraMarka_Leave(object sender, EventArgs e)
        {
            if (txtAraMarka.Text == "")
            {
                txtAraMarka.Text = "Markaya göre arama";
                txtAraMarka.ForeColor = Color.Silver;
 
            }
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            aracGoruntule();
        }




        
        

        

       

       





       

        
    }
}
