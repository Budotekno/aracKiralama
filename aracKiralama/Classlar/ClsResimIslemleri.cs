using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace aracKiralama
{
    public class ClsResimIslemleri
    {

        //resimleri görüntülemek için fonksiyon
        public static Image resimGoruntule(string klasorAdi, string goruntulenecekAd)
        {
            
            try
            {
                //Application.StartupPath = çalışan uygulamanın debug klasörü 
                //statupPath = bin'deki debug klasörünü belirtmek için
                //fromfile() = getir demektir
   
                 return Image.FromFile(Application.StartupPath + "\\img\\" + klasorAdi + "\\" + goruntulenecekAd + ".jpg");
               
            }
            catch (Exception)
            {
                
                MessageBox.Show("Resim bulunamadı","Bilgilendirme");
            }

            return Image.FromFile(Application.StartupPath + "\\img\\resimYok.jpg");


        }

        //resimleri yüklemek için fonksiyon
        public static Image resimYukle(string baslik)
        {
            //Seçme formunu açmak için oluşturulan nesne
            OpenFileDialog resimSec = new OpenFileDialog();
            //gelecek formun nesnesini ayarlanır
            resimSec.Title = baslik+" fotoğrafını seçiniz";
            //uzantıları filtrelemek için 
            resimSec.Filter = "JPG Dosyalar (*jpg) | *.jpg";


            if (resimSec.ShowDialog() == DialogResult.OK)
                return new Bitmap(resimSec.OpenFile());

            return Image.FromFile(Application.StartupPath + "\\img\\resimYok.jpg");
        }

        //resimleri kaydetmek için fonksiyon
        public static String resimKaydet(string klasorAdi , string kaydedilecekAd)
        {
            // fotoğrafı seçmek için yazılan save komutu
           return Application.StartupPath + "\\img\\"+klasorAdi+"\\" + kaydedilecekAd + ".jpg";
        }


    }
}
