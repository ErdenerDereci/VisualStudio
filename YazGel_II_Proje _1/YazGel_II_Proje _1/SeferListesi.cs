using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazGel_II_Proje__1
{
    class SeferListesi
    {
        SeferBilgisiDugum head = new SeferBilgisiDugum();
        public void Ekle(string seferNo, string saat, string guzergah, string kapasite,int fiyat, string tarih,string plaka,string kaptan,KoltukBilgilerListe koltukbilgileri)
        {
            SeferBilgisiDugum temp;

            temp = head;
        tag:
            if (temp.seferNo == null)
            {
                temp.seferNo = seferNo;
                temp.tarih = tarih;
                temp.saat = saat;
                temp.guzergah = guzergah;
                temp.kapasite = kapasite;
                temp.plaka = plaka;
                temp.kaptan = kaptan;
                temp.fiyat = fiyat;
                temp.koltukBilgileri = koltukbilgileri;
                temp.sonraki = new SeferBilgisiDugum();
            }
            else
            {
                
                temp = temp.sonraki;
                goto tag;
            }

        }
        public void Listele()
        {
            SeferBilgisiDugum temp;
            temp = head;

            while (temp.sonraki != null)
            {
                Console.WriteLine(temp.seferNo + " " + temp.saat + " " + temp.guzergah + " " + temp.kapasite + " " + temp.tarih + " " + temp.plaka + " " + temp.kaptan + " ");
                temp = temp.sonraki;
            }
        }

       

        public int Sil(string seferNo)
        {
            SeferBilgisiDugum temp;



            if (head == null)
            {
                return 0; // liste boş
            }
            else
            {
                if (head.seferNo == seferNo)
                {
                    head = head.sonraki;
                    return 1; // Silme işlemi başarılı
                }
                else
                {
                    // Numarası girilen koltuk bilgisini bulan döngü

                    temp = head;
                tag:


                    if (temp.sonraki.seferNo == seferNo)
                    {
                        temp.sonraki = temp.sonraki.sonraki; // Numara eşitse sildi
                        return 1;
                    }
                    else
                    {
                        temp = temp.sonraki; // Numara eşit değilse sonraki düğüme geçiyor
                        if (temp.sonraki == null)
                        {
                            return 2; // Döngüden çıkması için - Bütün listeyi dolaşıp numarayı bulamazsa döngü kırılıyor
                        }
                        goto tag;
                    }


                }
            }




        }
        public int Duzenle(string seferNo,string yeniSeferNo, string saat, string guzergah, string kapasite, string tarih, string plaka, string kaptan)
        {
            SeferBilgisiDugum temp;

            temp = head;

            while (temp.seferNo != seferNo)
            {
                temp = temp.sonraki;
            }

            if (temp == null)
            {
                return 0; // Aranan eleman listede yok
            }
            else
            {
                temp.seferNo = yeniSeferNo;
                temp.saat = saat;
                temp.guzergah = guzergah;
                temp.kapasite = kapasite;
                temp.tarih = tarih;
                temp.plaka = plaka;
                temp.kaptan = kaptan;
                return 1; // Duzenleme başarılı
            }
        }
        public SeferBilgisiDugum dugumCek(int  sayac)
        {
            SeferBilgisiDugum temp;
            temp = head;

            for(int i=0; i<sayac; i++)
            {
                temp = temp.sonraki;
            }
            return temp;
           
        }

        //public string saatCek( string seferNo)
        //{
        //    SeferBilgisiDugum temp;
        //    temp = veriBul(seferNo);

        //    if (temp == null)
        //    {
        //        return "Aranan öğe bulunamadı";

        //    }
        //    else
        //    {
        //        return temp.saat;
        //    }
        //}
        //public string guzergahCek(string seferNo)
        //{
        //    SeferBilgisiDugum temp;
        //    temp = veriBul(seferNo);

        //    if (temp == null)
        //    {
        //        return "Aranan öğe bulunamadı";

        //    }
        //    else
        //    {
        //        return temp.guzergah;
        //    }
        //}
        //public string kapasiteCek(string seferNo)
        //{
        //    SeferBilgisiDugum temp;
        //    temp = veriBul(seferNo);

        //    if (temp == null)
        //    {
        //        return "Aranan öğe bulunamadı";

        //    }
        //    else
        //    {
        //        return temp.kapasite;
        //    }
        //}
        //public string tarihCek(string seferNo)
        //{
        //    SeferBilgisiDugum temp;
        //    temp = veriBul(seferNo);

        //    if (temp == null)
        //    {
        //        return "Aranan öğe bulunamadı";

        //    }
        //    else
        //    {
        //        return temp.tarih;
        //    }
        //}
        //public string plakaCek(string seferNo)
        //{
        //    SeferBilgisiDugum temp;
        //    temp = veriBul(seferNo);

        //    if (temp == null)
        //    {
        //        return "Aranan öğe bulunamadı";

        //    }
        //    else
        //    {
        //        return temp.plaka;
        //    }
        //}
        //public string kaptanCek(string seferNo)
        //{
        //    SeferBilgisiDugum temp;
        //    temp = veriBul(seferNo);

        //    if (temp == null)
        //    {
        //        return "Aranan öğe bulunamadı";

        //    }
        //    else
        //    {
        //        return temp.kaptan;
        //    }
        //}
        //public KoltukBilgilerListe koltukBilgisiListesiCek(string seferNo)
        //{
        //    SeferBilgisiDugum temp;
        //    temp = veriBul(seferNo);

        //    if (temp == null)
        //    {
        //        return null;

        //    }
        //    else
        //    {
        //        return temp.koltukBilgileri;
        //    }
        //}
    }
}
