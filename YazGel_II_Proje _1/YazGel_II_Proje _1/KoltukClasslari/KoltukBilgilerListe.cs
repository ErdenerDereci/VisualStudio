using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazGel_II_Proje__1
{
    class KoltukBilgilerListe
    {
        KoltukBilgileriDugum head = new KoltukBilgileriDugum();



        public void Ekle(string numara, string yolcuAdi, string yolcuCinsiyeti, string durum)
        {
            KoltukBilgileriDugum temp;

            temp = head;
        tag:
            if (temp.numara == null)
            {
                temp.numara = numara;
                temp.durum = durum;
               
                temp.yolcuAdi = yolcuAdi;
                temp.yolcuCinsiyeti = yolcuCinsiyeti;
                temp.sonraki = new KoltukBilgileriDugum();
            }
            else
            {
                
                temp = temp.sonraki;
                goto tag;
            }

        }
       
        public int Sil(string numara)
        {
            KoltukBilgileriDugum temp;



            if (head == null)
            {
                return 0; // liste boş
            }
            else
            {
                if (head.numara == numara)
                {
                    head = head.sonraki;
                    return 1; // Silme işlemi başarılı
                }
                else
                {
                    // Numarası girilen koltuk bilgisini bulan döngü

                    temp = head;
                tag:


                    if (temp.sonraki.numara == numara)
                    {
                        temp.sonraki = temp.sonraki.sonraki; // Numara eşitse sildi
                        return 1; // Silme işlemi başarılı
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
        public int Duzenle(string numara, string yeniNumara, string yolcuAdi, string yolcuCinsiyeti, string durum)
        {
            KoltukBilgileriDugum temp;

            temp = head;

            while (temp.numara != numara)
            {
                temp = temp.sonraki;
            }

            if (temp == null)
            {
                return 0; // Aranan eleman listede yok
            }
            else
            {
                temp.numara = yeniNumara;
                temp.yolcuAdi = yolcuAdi;
                temp.yolcuCinsiyeti = yolcuCinsiyeti;
                temp.durum = durum;
                return 1; // Duzenleme başarılı
            }
        }
        public int Count()
        {
            KoltukBilgileriDugum temp;
            temp = head;

            int i = -1;
            while(temp!=null)
            {
                temp = temp.sonraki;
                i++;
            }
            return i;
        }
        public KoltukBilgileriDugum dugumCek(int i)
        {
            KoltukBilgileriDugum temp = head;
            for(int j =0; j<i; j++)
            {
                temp = temp.sonraki;
            }
            return temp;
        }
        public int kacKoltukDolu()
        {
            KoltukBilgileriDugum x = head;
            int sayac=0;
            while(x!=null)
            {
                if(x.durum != "Boş" && x.durum!=null)
                {
                    sayac++;
                }
                x = x.sonraki;
            }
            return sayac;
        }
    }
}
