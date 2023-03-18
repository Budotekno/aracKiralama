using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace aracKiralama
{
    public static class ClsVeriTabaniIslemleri
    {
       

        // bağlantı tanımı
        public static OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=aracKiralama.accdb");



        public static DataSet listele(string sorgu, string tabloAdi)
        {
            try
            {
                baglanti.Open();
                DataSet daset = new DataSet();
                OleDbDataAdapter daadapter = new OleDbDataAdapter(sorgu,baglanti);
                daadapter.Fill(daset, tabloAdi);
                baglanti.Close();
                return daset;

            }
            catch (Exception hata ) 
            {
                MessageBox.Show(hata.Message, tabloAdi+" Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            DataSet daset1 = new DataSet();
            return daset1;

           
        }
    }
}
