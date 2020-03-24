using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazGel_II_Proje__1
{
    class TarihDugum
    {
        public TarihDugum sonraki = null;

        string tarih_;
        SeferListesi sefer_;

        public string  tarih { get { return tarih_; } set { tarih_ = value; } }
        public SeferListesi sefer{ get { return sefer_; } set { sefer_ = value; } }
    }
}
