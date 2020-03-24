using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazGel_II_Proje__1
{
    class TarihListesi
    {
        TarihDugum head = new TarihDugum();


        public void Ekle(string tarih, SeferListesi sefer)
        {
            TarihDugum temp;

            temp = head;
        tag:
            if (temp.tarih == null)
            {
                temp.tarih = tarih;
                temp.sefer = sefer;

                temp.sonraki = new TarihDugum();
            }
            else
            {

                temp = temp.sonraki;
                goto tag;
            }

        }
        public TarihDugum dugumCek(int i)

        {
            TarihDugum temp;
            temp = head;
            for (int j =0; j<i; j++)
            {
                temp = temp.sonraki;
            }
            return temp;
        }
        public int Count()
        {
            TarihDugum temp;
            temp = head;
            int i = -1;

            while (temp != null)
            {
                temp = temp.sonraki;
                i++;
            }
            return i;
        }
    }
}
