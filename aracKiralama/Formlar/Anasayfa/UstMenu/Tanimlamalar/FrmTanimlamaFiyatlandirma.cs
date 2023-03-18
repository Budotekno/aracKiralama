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
    public partial class FrmTanimlamaFiyatlandirma : Form
    {
        public FrmTanimlamaFiyatlandirma()
        {
            InitializeComponent();
        }
        public static string UstSınıf = "", OrtaSınıf = "", DusukSınıf = "";
        private void FrmTanimlamaFiyatlandirma_Load(object sender, EventArgs e)
        {
            
            listele();
            dataGridView1.Rows[0].Selected = false;
            dataGridView1.Rows[1].Selected = false;
            dataGridView1.Rows[2].Selected = false;
            cmbAracTuru.SelectedIndex = 0;
            
            
        }

        private void listele()
        {
            string sorgu = "select id AS[İD], aracTuru AS[Araç Türü], ucret AS[Ücret] from tanimlamalar";
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "tanimlamalar");
            dataGridView1.DataSource = dataset.Tables[0];
            UstSınıf = dataGridView1.Rows[0].Cells[2].Value.ToString();
            OrtaSınıf = dataGridView1.Rows[1].Cells[2].Value.ToString();
            DusukSınıf = dataGridView1.Rows[2].Cells[2].Value.ToString();
        }
  
        private void cmbAracTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAracTuru.Text == "Seçiniz")
            {
                lblFiyat.Visible = false;
                lblİkiNokta.Visible = false;
                mTxtFiyat.Visible = false;
                btnFiyat.Visible = false;
                dataGridView1.Rows[0].Selected = false;
                dataGridView1.Rows[1].Selected = false;
                dataGridView1.Rows[2].Selected = false;
            }
            else 
            {
                lblFiyat.Visible = true;
                lblİkiNokta.Visible = true;
                mTxtFiyat.Visible = true;
                btnFiyat.Visible = true;
                if (cmbAracTuru.Text == "Üst Sınıf")
                {
                    mTxtFiyat.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    dataGridView1.Rows[0].Selected = true;
                    dataGridView1.Rows[1].Selected = false;
                    dataGridView1.Rows[2].Selected = false;
                }
                else if (cmbAracTuru.Text == "Orta Sınıf")
                {
                    mTxtFiyat.Text = dataGridView1.Rows[1].Cells[2].Value.ToString();
                    dataGridView1.Rows[0].Selected = false;
                    dataGridView1.Rows[1].Selected = true;
                    dataGridView1.Rows[2].Selected = false;
                }
                else if (cmbAracTuru.Text == "Düşük Sınıf")
                {
                    mTxtFiyat.Text = dataGridView1.Rows[2].Cells[2].Value.ToString();
                    dataGridView1.Rows[0].Selected = false;
                    dataGridView1.Rows[1].Selected = false;
                    dataGridView1.Rows[2].Selected = true;
                }
                
 
            }
        }

        private void btnFiyat_Click(object sender, EventArgs e)
        {
            mTxtFiyat.BackColor = Color.White;
            if (mTxtFiyat.Text == "")
            {
                mTxtFiyat.BackColor = Color.Red;
                MessageBox.Show("fiyat alanını boş geçemezsiniz!");
                mTxtFiyat.Focus();
            }
            else
            {
                FiyatGüncelleme();
            }
        }

        private void FiyatGüncelleme()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "update tanimlamalar set  ucret=@ucret where aracTuru=@aracTuru";
                OleDbCommand guncelle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                
                guncelle.Parameters.AddWithValue("@ucret", mTxtFiyat.Text);
                guncelle.Parameters.AddWithValue("@aracTuru", cmbAracTuru.Text);
               
                if (guncelle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Fiyat güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
                ClsVeriTabaniIslemleri.baglanti.Close();
                listele();
                cmbAracTuru.SelectedIndex = 0;

                
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Personel Kayıt Güncelleme Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
