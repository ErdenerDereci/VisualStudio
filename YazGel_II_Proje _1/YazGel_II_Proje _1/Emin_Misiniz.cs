using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace YazGel_II_Proje__1
{
    public partial class Emin_Misiniz : Form
    {
        public Emin_Misiniz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeferSil a = new SeferSil();
            seferSil(seferno.Text, tarih.Text);
            silineniYolla(seferno.Text);
            
            this.Close();
            
        }
        private void silineniYolla(string x)
        {
            string dosya_yolu = System.Windows.Forms.Application.StartupPath + "\\YazGelTxt\\"+"SilinenSeferNo.txt";
            StreamWriter a = new StreamWriter(dosya_yolu, true);
            a.WriteLine(x);
            a.Close();
        }
        private void seferSil(string seferNo,string tarih)
        {
            SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();
            SeferListesi temp = listeyeAt.seferListeyeAt("", tarih);
            string dosya_yolu = System.Windows.Forms.Application.StartupPath + "\\YazGelTxt\\"+tarih+".txt";

            File.Delete(dosya_yolu);
            
            temp.Sil(seferNo);
            StreamWriter sw = new StreamWriter(dosya_yolu, true);
            for (int i=0; i<temp.Count(); i++)
            {
                

               
                //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
                sw.WriteLine("********** Sefer Bilgileri **********");
                sw.WriteLine("");
                sw.WriteLine("Sefer No: '" + temp.dugumCek(i).seferNo + "'");
                sw.WriteLine("Güzergah: '" + temp.dugumCek(i).guzergah + "'");
                sw.WriteLine("Tarih: '" + temp.dugumCek(i).tarih + "'");
                sw.WriteLine("Saat: '" + temp.dugumCek(i).saat + "'");
                sw.WriteLine("Kapasite: '" + temp.dugumCek(i).kapasite + "'");
                sw.WriteLine("Bilet Fiyatı: '" + temp.dugumCek(i).fiyat + "'");
                sw.WriteLine("Plaka: '" + temp.dugumCek(i).plaka + "'");
                sw.WriteLine("Kaptan: '" + temp.dugumCek(i).kaptan + "'");
                sw.WriteLine("");
                sw.WriteLine("********** Koltuk Bilgileri **********");
                sw.WriteLine("");

                for (int j = 1; j < Convert.ToInt32( temp.dugumCek(i).kapasite) + 1; j++)
                {
                    sw.WriteLine("Koltuk No: '" + j + "'");
                    sw.WriteLine("Yolcu Adı: ''");
                    sw.WriteLine("Cinsiyeti: ''");
                    sw.WriteLine("Durum: ''");
                    sw.WriteLine("");
                }
                sw.WriteLine("----------------------------------------------------------------------------------------------------");
                
            }
            sw.Close();
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            if (sr.ReadLine() == null)
            {
                sr.Close();
                
                File.Delete(dosya_yolu);
                tarihSil(tarih);
            }
            sr.Close();
            MessageBox.Show("Silme işlemi başarılı..");
            
        }
        private void tarihSil(string tarih)
        {
            List<string> liste = new List<string>();
            string dosya_yolu = System.Windows.Forms.Application.StartupPath + "\\YazGelTxt\\"+"Tarihler.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

            StreamReader sw = new StreamReader(fs);
            string yazi=sw.ReadLine();
            while (yazi != null)
            {
                if (yazi != tarih) 
                {
                    liste.Add(yazi);
                }
               
                yazi = sw.ReadLine();
            }
            fs.Close();
            sw.Close();
            if (liste.Count == 0)
            {
                File.Delete(dosya_yolu);
                
            }
            else
            {
                File.Delete(dosya_yolu);
                StreamWriter x = new StreamWriter(dosya_yolu, true);
                for (int i = 0; i < liste.Count; i++)
                {
                    x.WriteLine(liste[i]);
                }
                x.Close();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
