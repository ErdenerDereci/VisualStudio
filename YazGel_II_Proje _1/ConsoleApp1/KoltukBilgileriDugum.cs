using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazGel_II_Proje__1
{
    class KoltukBilgileriDugum
    {
        string numara_;
        int fiyat_;
        string yolcuAdi_;
        string yolcuCinsiyeti_;
        string durum_;


        public KoltukBilgileriDugum sonraki = null;
        public string numara { get { return numara_; } set { numara_ = value; } }
        public int fiyat { get { return fiyat_; } set { fiyat_ = value; } }
        public string yolcuAdi { get { return yolcuAdi_; } set { yolcuAdi_ = value; } }
        public string yolcuCinsiyeti { get { return yolcuCinsiyeti_; } set { yolcuCinsiyeti_ = value; } }
        public string durum { get { return durum_; } set { durum_ = value; } }

    }
}
