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
    public partial class FrmAracTeslim : Form
    {
        public FrmAracTeslim()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            TeslimAlBilgilendirme();
        }

        private void TeslimAlBilgilendirme()
        {
            if (MessageBox.Show(
               "Seçilen aracı teslim almak istiyor musunuz?",
              "Teslim Alma İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                teslimAl();
        }

        private void teslimAl()
        {

            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Delete from kiralama where id=" + txtID.Text;
                OleDbCommand com = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);
                if (com.ExecuteNonQuery() == 1)
                {
                   // MessageBox.Show(txtPlaka.Text + " plakalı araç teslim alınmıştır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                ClsVeriTabaniIslemleri.baglanti.Close();
                aracDurumunuDegistirme();
                this.Close();
               


            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Araç Teslim Alma Hatası" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void aracDurumunuDegistirme()
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Update arac set durum=@durum where plaka=@plaka";

                OleDbCommand guncelle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);

                guncelle.Parameters.AddWithValue("@durum", "Kiralık");
                guncelle.Parameters.AddWithValue("@plaka", txtPlaka.Text);

                if (guncelle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(txtPlaka.Text + " plakalı araç teslim alınmıştır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                ClsVeriTabaniIslemleri.baglanti.Close();


            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message, "Araç Kiralama Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
