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
            int sfno;
            
           
           
            
            if (nereden.Text=="" || nereye.Text=="" || tarih.Text=="" || saat.Text=="" || kapasite.Text=="" || biletFiyati.Text=="" || plaka.Text=="" || kaptan.Text=="")
            {
                MessageBox.Show("Alanlar boş bırakılamaz!!!");
            }
            else
            {
                SeferListesi temp = ListeyeAt.seferListeyeAt("", tarih.Text);

                if (temp == null)
                {
                    sfno = seferNoDondur();
                    MessageBox.Show(""+tarih.Text+" dosyası oluşturuldu..");
                    dosyayaYaz(sfno.ToString(), nereden.Text + "-" + nereye.Text, tarih.Text, saat.Text, Convert.ToInt32(kapasite.Text), Convert.ToInt32(biletFiyati.Text), plaka.Text, kaptan.Text);
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
                        sfno= seferNoDondur();
                        dosyayaYaz(sfno.ToString(), nereden.Text + "-" + nereye.Text, tarih.Text, saat.Text, Convert.ToInt32(kapasite.Text), Convert.ToInt32(biletFiyati.Text), plaka.Text, kaptan.Text);
                        dosyayaYazSeferNo(sfno);
                        MessageBox.Show("Ekleme başarılı.. ");
                        dosyayaYazSeferTarih(tarih.Text);
                    
                }
                }
            }


            

        }
        
        private void dosyayaYaz(string seferNo,string guzergah,string tarih,string saat,int kapasite,int biletFiyati, string plaka,string kaptan)
        {

            string dosya_yolu = System.Windows.Forms.Application.StartupPath +"\\"+ tarih + ".txt";
            
            
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
                sw.WriteLine("Yolcu Adı: 'Boş'");
                sw.WriteLine("Cinsiyeti: 'Boş'");
                sw.WriteLine("Durum: 'Boş'");
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
            string dosya_yolu = System.Windows.Forms.Application.StartupPath+"\\" +"Tarihler.txt";


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
            string dosya_yolu = System.Windows.Forms.Application.StartupPath +"\\"+"SeferNo.txt";
            StreamWriter sw = new StreamWriter(dosya_yolu,true);

            sw.WriteLine(i);
            sw.Close();

        }
        private void seferEkle_Load(object sender, EventArgs e)
        {
            nereden.BackColor = Color.White;
        }
        private int seferNoSilinendenDondur()
        {
            List<string> liste = new List<string>();
            string dosya_yolu = System.Windows.Forms.Application.StartupPath +"\\"+"SilinenSeferNo.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();
            while (yazi != null)
            {
                liste.Add(yazi);
                yazi = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
            File.Delete(dosya_yolu);
            yazi = liste[0];
            liste.RemoveAt(0);

            StreamWriter sw = new StreamWriter(dosya_yolu, true);

            for (int i = 0; i < liste.Count; i++)
            {
                sw.WriteLine(liste[i]);
            }
            sw.Close();
            if (liste.Count == 0)
            {
                File.Delete(dosya_yolu);
            }
            return Convert.ToInt32(yazi);

        }

        private int seferNoDondur()
        {
            int donecek = 0;
            List<string> silinen = new List<string>();
            string dosya_yolu = System.Windows.Forms.Application.StartupPath +"\\"+"SeferNo.txt";
            string dosya_yolu2 = System.Windows.Forms.Application.StartupPath+"\\" +"SilinenSeferNo.txt";

            if (File.Exists(dosya_yolu2))
            {

                return seferNoSilinendenDondur();

            }
            else
            {
                if (File.Exists(dosya_yolu))
                {
                    FileStream f2 = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                    StreamReader s2 = new StreamReader(f2);
                    string yazi2=s2.ReadLine();
                    List<int> aa = new List<int>();

                    while (yazi2 != null)
                    {
                        aa.Add(Convert.ToInt32(yazi2));
                        yazi2 = s2.ReadLine();
                    }
                    for(int i = 0; i < aa.Count; i++)
                    {
                        if (donecek < aa[i])
                        {
                            donecek = aa[i];
                        }
                    }

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

        private void kapasite_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //Sadece rakam girmek için https://www.muratyazici.com/c-textboxa-sadece-harf-girme-sadece-sayi-girme.html
        }

        private void biletFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); //rakam https://www.muratyazici.com/c-textboxa-sadece-harf-girme-sadece-sayi-girme.html
        }

        private void kaptan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar); //sadece harf https://www.muratyazici.com/c-textboxa-sadece-harf-girme-sadece-sayi-girme.html
        }
    }
}
