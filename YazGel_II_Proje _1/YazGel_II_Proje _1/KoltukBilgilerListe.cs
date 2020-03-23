﻿using System;
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
            }
            else
            {
                temp.sonraki = new KoltukBilgileriDugum();
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

    }
}
