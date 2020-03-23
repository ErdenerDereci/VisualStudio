using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazGel_II_Proje__1
{
    class SeferBilgisiDugum
    {
        string seferNo_;
        string guzergah_;
        string tarih_;
        string saat_;
        string kapasite_;
        int fiyat_;
        public KoltukBilgilerListe koltukBilgileri;
        string plaka_;
        string kaptan_;
        

        
        public SeferBilgisiDugum sonraki = null;
        public string seferNo { get { return seferNo_; } set { seferNo_ = value; } }
        public string guzergah { get { return guzergah_; } set { guzergah_ = value; } }
        public string tarih { get { return tarih_; } set { tarih_ = value; } }
        public string saat { get { return saat_; } set { saat_ = value; } }
        public string kapasite { get { return kapasite_; } set { kapasite_ = value; } }
        public string plaka { get { return plaka_; } set { plaka_ = value; } }
        public string kaptan { get { return kaptan_; } set { kaptan_ = value; } }
        public int  fiyat { get { return fiyat_; } set { fiyat_ = value; } }
        
    }
}
