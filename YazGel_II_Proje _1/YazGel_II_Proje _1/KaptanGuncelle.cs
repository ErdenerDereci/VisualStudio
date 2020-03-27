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
    public partial class KaptanGuncelle : Form
    {
        public KaptanGuncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kaptanText.Text == null)
            {
                MessageBox.Show("Lütfen kaptan adı giriniz!");
            }
            else { 
            SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();
            SeferListesi temp = listeyeAt.seferListeyeAt("", tarih.Text);
                string dosya_yolu = System.Windows.Forms.Application.StartupPath + "\\YazGelTxt\\" + tarih.Text + ".txt";

                temp.KaptanDuzenle(seferno.Text, kaptanText.Text).kaptan = kaptanText.Text;
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

                    for (int j = 1; j < Convert.ToInt32(temp.dugumCek(i).kapasite) + 1; j++)
                    {
                        sw.WriteLine("Koltuk No: '" + j + "'");
                        sw.WriteLine("Yolcu Adı: 'Boş'");
                        sw.WriteLine("Cinsiyeti: 'Boş'");
                        sw.WriteLine("Durum: 'Boş'");
                        sw.WriteLine("");
                    }
                    sw.WriteLine("----------------------------------------------------------------------------------------------------");

                }
                sw.Close();
                MessageBox.Show("'"+kaptan.Text+"' verisi '"+kaptanText.Text+"' verisine güncellendi.!! ");
            this.Close();
            }
        }
    }
}
