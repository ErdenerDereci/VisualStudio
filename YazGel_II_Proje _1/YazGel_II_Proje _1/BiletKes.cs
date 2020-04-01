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
    public partial class BiletKes : Form
    {
        public BiletKes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yolcuAdi.Text == "")
            {
                MessageBox.Show("Alanlar doldurulmak zorundadır!!");
            }
            else
            {
                SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();
                SeferListesi temp = listeyeAt.seferListeyeAt("", label6.Text);
                string dosya_yolu = System.Windows.Forms.Application.StartupPath +"\\"+ label6.Text + ".txt";
                temp.seferNoDugumCek(label7.Text).koltukBilgileri.dugumCek(Convert.ToInt32(label5.Text) - 1).yolcuAdi = yolcuAdi.Text;
                temp.seferNoDugumCek(label7.Text).koltukBilgileri.dugumCek(Convert.ToInt32(label5.Text) - 1).yolcuCinsiyeti = cinsiyeti.Text;
                temp.seferNoDugumCek(label7.Text).koltukBilgileri.dugumCek(Convert.ToInt32(label5.Text) - 1).durum = durum.Text;
                File.Delete(dosya_yolu);
                StreamWriter sw = new StreamWriter(dosya_yolu, true);
                for (int i = 0; i < temp.Count(); i++)
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

                    for (int j = 0; j < Convert.ToInt32(temp.dugumCek(i).kapasite); j++)
                    {
                        sw.WriteLine("Koltuk No: '" + temp.dugumCek(i).koltukBilgileri.dugumCek(j).numara + "'");
                        sw.WriteLine("Yolcu Adı: '" + temp.dugumCek(i).koltukBilgileri.dugumCek(j).yolcuAdi + "'");
                        sw.WriteLine("Cinsiyeti: '" + temp.dugumCek(i).koltukBilgileri.dugumCek(j).yolcuCinsiyeti + "'");
                        sw.WriteLine("Durum: '" + temp.dugumCek(i).koltukBilgileri.dugumCek(j).durum + "'");
                        sw.WriteLine("");
                    }
                    sw.WriteLine("----------------------------------------------------------------------------------------------------");

                }
                sw.Close();
                MessageBox.Show("Bilet Kesildi!! ");
                this.Close();

            }
            
        }
    }
}
