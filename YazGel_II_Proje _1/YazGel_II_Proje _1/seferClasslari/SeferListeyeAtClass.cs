using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazGel_II_Proje__1
{
    class SeferListeyeAtClass
    {
        private string elemanAyir(string x)
        {
            int sayac = 0;
            string donecek = "";
            if (x.Contains("\'"))
            {
                for (int i = 0; i < x.Length; i++)
                {
                    sayac++;
                    if (x[i] == '\'')
                    {


                        while (x[sayac] != '\'')
                        {
                            donecek = donecek + x[sayac];
                            sayac++;
                        }
                        break;
                    }

                }
                return donecek;
            }
            return "x";
        }
        private KoltukBilgilerListe koltukListeyeAt(string seferNo, string tarih)
        {
            KoltukBilgilerListe temp = new KoltukBilgilerListe();
            string numara = "";
            string yolcuAdi = "";
            string yolcuCinsiyeti = "";
            string durum = "";

            string dosya_yolu = System.Windows.Forms.Application.StartupPath +"\\" + tarih + ".txt";

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

            StreamReader sw = new StreamReader(fs);

            string yazi = sw.ReadLine();

            while (!yazi.Contains("Sefer No: '" + seferNo + "'"))
            {
                yazi = sw.ReadLine();
                if (yazi == null)
                {
                    
                    Console.WriteLine("Aradığınız sefer bulunamadı..");
                    sw.Close();
                    fs.Close();
                    return temp;
                }
            }

            for (int i = 0; i < 11; i++)
            {
                yazi = sw.ReadLine();
            }

            while (!yazi.Contains("-"))
            {
                if (yazi.Contains("Koltuk"))
                {
                    numara = elemanAyir(yazi);
                }
                else if (yazi.Contains("Yolcu Adı"))
                {
                    yolcuAdi = elemanAyir(yazi);
                }
                else if (yazi.Contains("Cinsiyet"))
                {
                    yolcuCinsiyeti = elemanAyir(yazi);
                }
                else if (yazi.Contains("Durum"))
                {
                    durum = elemanAyir(yazi);
                    temp.Ekle(numara, yolcuAdi, yolcuCinsiyeti, durum);
                }
                yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();
            return temp;




        }
        public SeferListesi seferListeyeAt(string seferNo, string tarih_)
        {
            SeferListesi temp = new SeferListesi();

            string x = "";
            string saat = "";
            string guzergah = "";
            string kapasite = "";
            int fiyat = 0;
            string tarih = "";
            string plaka = "";
            string kaptan = "";


            string dosya_yolu = System.Windows.Forms.Application.StartupPath + "\\"+tarih_ + ".txt";
            if (File.Exists(dosya_yolu))
            {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                StreamReader sw = new StreamReader(fs);

                string yazi = sw.ReadLine();
                string y = "";
                if (seferNo == "")
                {
                    y = "Sefer No";
                }
                else
                {
                    y = "Sefer No: '" + seferNo + "'";
                }
            tag:
                while (!yazi.Contains(y))
                {
                    yazi = sw.ReadLine();
                    if (yazi == null)
                    {
                        sw.Close();
                        fs.Close();
                        return temp;
                    }

                }

                while (!yazi.Contains("------"))
                {
                    if (yazi.Contains("Sefer"))
                    {
                        x = elemanAyir(yazi);
                    }
                    else if (yazi.Contains("Saat"))
                    {
                        saat = elemanAyir(yazi);
                    }
                    else if (yazi.Contains("Tarih"))
                    {
                        tarih = elemanAyir(yazi);
                    }
                    else if (yazi.Contains("Güzergah"))
                    {
                        guzergah = elemanAyir(yazi);

                    }
                    else if (yazi.Contains("Bilet Fiyatı"))
                    {
                        fiyat = Convert.ToInt32(elemanAyir(yazi));

                    }
                    else if (yazi.Contains("Kapasite"))
                    {
                        kapasite = elemanAyir(yazi);

                    }
                    else if (yazi.Contains("Plaka"))
                    {
                        plaka = elemanAyir(yazi);

                    }
                    else if (yazi.Contains("Kaptan"))
                    {
                        kaptan = elemanAyir(yazi);
                        temp.Ekle(x, saat, guzergah, kapasite, fiyat, tarih, plaka, kaptan, koltukListeyeAt(x, tarih_));

                    }

                    yazi = sw.ReadLine();
                    if (yazi.Contains("Koltuk Bilgileri"))
                    {
                        goto tag;
                    }
                }
                sw.Close();
                fs.Close();
                return temp;
            }
          
            return null;


        }
    }
}
