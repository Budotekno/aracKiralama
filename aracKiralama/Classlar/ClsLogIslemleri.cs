using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace aracKiralama
{
    class ClsLogIslemleri
    {

        public static void logEkleme(string hataYeri, string hataBaslik, string hataAciklama)
        {
            try
            {
                ClsVeriTabaniIslemleri.baglanti.Open();
                string sorgu = "Insert into log (hataYeri, hataBaslik, saat, tarih, hataAciklama)" +
                    " " + "Values(@hataYeri, @hataBaslik, @saat , @tarih, @hataAciklama) ";
                OleDbCommand ekle = new OleDbCommand(sorgu, ClsVeriTabaniIslemleri.baglanti);

                ekle.Parameters.AddWithValue("@hataYeri", hataYeri);
                ekle.Parameters.AddWithValue("@hataBaslik", hataBaslik);
                ekle.Parameters.AddWithValue("@saat", DateTime.Now.ToLongTimeString());
                ekle.Parameters.AddWithValue("@tarih", DateTime.Now.ToShortDateString());
                ekle.Parameters.AddWithValue("@hataAciklama", hataAciklama);
                if (ekle.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Log eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                ClsVeriTabaniIslemleri.baglanti.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Log Ayıklama Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
