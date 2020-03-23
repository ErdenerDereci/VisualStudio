using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace YazGel_II_Proje__1
{
    class Program
    {
        public static void dosyadanOkuVeListeyeAt(string tarih)
        {
            List<string> templist = new List<string>();
            SeferListesi temp = new SeferListesi();
            Console.WriteLine(tarih);
            const string xx = "\'";
            string dosya_yolu = @"C:\Users\fed\Desktop\YazGel_Txt_Dosyalari\'"  + tarih +  "'.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            while (yazi != null)
            {
                if (yazi.Contains("'"))
                {
                    Console.WriteLine(yazi);
                    templist.Add(yazi);
                }
                yazi = sw.ReadLine();
            }
            //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
            //Son satır okunduktan sonra okuma işlemini bitirdik
            sw.Close();
            fs.Close();
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }
        static void Main(string[] args)
        {
            string x = "24 Şubat 2020 Pazartesi";
            
            dosyadanOkuVeListeyeAt(x);
            
            Console.ReadKey();
        }
    }
}
