using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazGel_II_Proje__1
{
    public partial class seferEkle : Form
    {
        
        string seferNo = "";
       
        public seferEkle()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (nereden.Text != "Kocaeli")
            {
                nereye.Text = "Kocaeli";
                nereye.Enabled = false;

            }
            else
            {
                nereye.Enabled = true;
                nereye.Text = "";
            }
        }

        private void seferadd_Click(object sender, EventArgs e)
        {
            SeferListeyeAtClass ListeyeAt = new SeferListeyeAtClass();
            int i = 0;
            int sfno = seferNoDondur() ;
            
           
           
            
            if (nereden.Text=="" || nereye.Text=="" || tarih.Text=="" || saat.Text=="" || kapasite.Text=="" || biletFiyati.Text=="" || plaka.Text=="" || kaptan.Text=="")
            {
                MessageBox.Show("Alanlar boş bırakılamaz!!!");
            }
            else
            {
                SeferListesi temp = ListeyeAt.seferListeyeAt("", tarih.Text);

                if (temp == null)
                {
                    seferNo = "s" + sfno;
                    MessageBox.Show(""+tarih.Text+" dosyası oluşturuldu..");
                    dosyayaYaz(seferNo, nereden.Text + "-" + nereye.Text, tarih.Text, saat.Text, Convert.ToInt32(kapasite.Text), Convert.ToInt32(biletFiyati.Text), plaka.Text, kaptan.Text);
                    dosyayaYazSeferNo(sfno);
                    MessageBox.Show("Ekleme başarılı.. ");
                    dosyayaYazSeferTarih(tarih.Text);
                }
                else { 

                while (temp.dugumCek(i) != null)
                {
                    if(temp.dugumCek(i).plaka==plaka.Text && temp.dugumCek(i).saat == saat.Text)
                    {
                        MessageBox.Show("bu sefer kayıtlı!!!");
                        break;
                    }
                    i++;
                }

                if (temp.dugumCek(i) == null)
                {
                        seferNo = "s" + sfno;
                        dosyayaYaz(seferNo, nereden.Text + "-" + nereye.Text, tarih.Text, saat.Text, Convert.ToInt32(kapasite.Text), Convert.ToInt32(biletFiyati.Text), plaka.Text, kaptan.Text);
                        dosyayaYazSeferNo(sfno);
                        MessageBox.Show("Ekleme başarılı.. ");
                        dosyayaYazSeferTarih(tarih.Text);
                    
                }
                }
            }


            

        }
        
        private void dosyayaYaz(string seferNo,string guzergah,string tarih,string saat,int kapasite,int biletFiyati, string plaka,string kaptan)
        {
            
            
            string dosya_yolu = @"C:\Users\fed\Desktop\YazGel_Txt_Dosyalari\'"+tarih+"'.txt";
            
            StreamWriter sw = new StreamWriter(dosya_yolu,true);
            //Yazma işlemi için bir StreamWriter nesnesi oluşturduk.
            sw.WriteLine("********** Sefer Bilgileri **********");
            sw.WriteLine("");
            sw.WriteLine("Sefer No: '" + seferNo + "'");
            sw.WriteLine("Güzergah: '" + guzergah + "'");
            sw.WriteLine("Tarih: '" + tarih + "'");
            sw.WriteLine("Saat: '" + saat + "'");
            sw.WriteLine("Kapasite: '" + kapasite + "'");
            sw.WriteLine("Bilet Fiyatı: '" + biletFiyati + "'");
            sw.WriteLine("Plaka: '" + plaka + "'");
            sw.WriteLine("Kaptan: '" + kaptan + "'");
            sw.WriteLine("");
            sw.WriteLine("********** Koltuk Bilgileri **********");
            sw.WriteLine("");

            for(int i = 1; i < kapasite+1; i++)
            {
                sw.WriteLine("Koltuk No: '"+i+"'");
                sw.WriteLine("Yolcu Adı: ''");
                sw.WriteLine("Cinsiyeti: ''");
                sw.WriteLine("Durum: ''");
                sw.WriteLine("");
            }
            sw.WriteLine("----------------------------------------------------------------------------------------------------");



            //Dosyaya ekleyeceğimiz iki satırlık yazıyı WriteLine() metodu ile yazacağız.
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
           
            //İşimiz bitince kullandığımız nesneleri iade ettik.
        }
        private bool dosyayaYazSeferTarih(string tarih)
        {
            string yazi = "";
            string dosya_yolu = @"C:\Users\fed\Desktop\YazGel_Txt_Dosyalari\Tarihler.txt";


            if (File.Exists(dosya_yolu))
            {
                FileStream f1 = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(f1);
                yazi = sr.ReadLine();
                while (yazi != null)
                {
                    if (yazi == tarih)
                    {

                        sr.Close();
                        f1.Close();
                        return true;

                    }
                    yazi = sr.ReadLine();
                }
                sr.Close();
                f1.Close();
            }
            
            StreamWriter sw = new StreamWriter(dosya_yolu, true);
            sw.WriteLine(tarih);
            sw.Close();

            
          
            
            return false;
        }
        private void dosyayaYazSeferNo(int i)
        {
            string dosya_yolu = @"C:\Users\fed\Desktop\YazGel_Txt_Dosyalari\SeferNo.txt";
            StreamWriter sw = new StreamWriter(dosya_yolu,true);

            sw.WriteLine(i);
            sw.Close();

        }
        private void seferEkle_Load(object sender, EventArgs e)
        {
            
        }
        private int seferNoDondur()
        {
            int donecek = 0;
            List<string> silinen = new List<string>();
            string dosya_yolu = @"C:\Users\fed\Desktop\YazGel_Txt_Dosyalari\SeferNo.txt";
            string dosya_yolu2 = @"C:\Users\fed\Desktop\YazGel_Txt_Dosyalari\SilinenSeferNo.txt";
           
            if (File.Exists(dosya_yolu2))
            {
                FileStream f1 = new FileStream(dosya_yolu2, FileMode.Open, FileAccess.Read);

                StreamReader sr = new StreamReader(f1);
                string yazi=sr.ReadLine();
                while (yazi != null)
                {
                    silinen.Add(yazi);
                    yazi = sr.ReadLine();
                }
                yazi = silinen[0];
                silinen.RemoveAt(0);
                StreamWriter sw = new StreamWriter(dosya_yolu2, true);
                File.Delete(dosya_yolu2);
                for(int i=0; i < silinen.Count; i++)
                {
                    sw.WriteLine(silinen[i]);
                }
                sr.Close();
                f1.Close();
                return Convert.ToInt32(yazi);

            }
            else
            {
                if (File.Exists(dosya_yolu))
                {
                    FileStream f2 = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                    StreamReader s2 = new StreamReader(f2);
                    string yazi2=s2.ReadLine();
                    string aa="";

                    while (yazi2 != null)
                    {
                        aa = yazi2;
                        yazi2 = s2.ReadLine();
                    }
                    donecek= Convert.ToInt32(aa);
                    donecek++;
                    f2.Close();
                    s2.Close();
                    return donecek;

                }
                else
                {
                   
                    return 1;
                }
            }
        }

        

    }
}
