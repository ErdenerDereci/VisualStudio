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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sefer_Click(object sender, EventArgs e)
        {
            label2.Text = tumSefer.Text;
            panel1.Visible = true;
            panel2.Visible = false;
            tumSefer.BackColor = Color.AliceBlue;
            tumSeferDataGridGuncelle();
            sefer.BackColor = Color.AliceBlue;
            bilet.BackColor = Color.LightGray;
        }

        private void bilet_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            sefer.BackColor = Color.LightGray;
            bilet.BackColor = Color.AliceBlue;
            guncelSeferDataGridGuncelle2();
            dataGridView3.Rows.Clear();
            biletTarih.Text = "";
            seferNoBilet.Text = "";
        }

        private void seferEkle_Click(object sender, EventArgs e)
        {
            seferEkle f = new seferEkle();
            
            f.ShowDialog();
        }

        

        private void tumSefer_Click(object sender, EventArgs e)
        {
            label2.Text = tumSefer.Text;
            //int seferSayisi = 0;
            tumSefer.BackColor = Color.AliceBlue;
            gecmisSefer.BackColor = Color.LightGray;
            guncelSefer.BackColor = Color.LightGray;
            
            tumSeferDataGridGuncelle();

        }
        private bool bosMu(string x)
        {
            if (File.Exists(x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void gecmisSefer_Click(object sender, EventArgs e)
        {
            label2.Text = gecmisSefer.Text;
            //int seferSayisi = 0;
            tumSefer.BackColor = Color.LightGray;
            gecmisSefer.BackColor = Color.AliceBlue;
            guncelSefer.BackColor = Color.LightGray;
           
            
            gecmisSeferDataGridGuncelle();
        }
       
        private void guncelSefer_Click(object sender, EventArgs e)
        {
            label2.Text = guncelSefer.Text;
            //int seferSayisi = 0;
            tumSefer.BackColor = Color.LightGray;
            gecmisSefer.BackColor = Color.LightGray;
            guncelSefer.BackColor = Color.AliceBlue;
            
            guncelSeferDataGridGuncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeferSil f1 = new SeferSil();
            if (bosMu(System.Windows.Forms.Application.StartupPath  +"\\"+"Tarihler.txt"))
            {
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sefer veri tabanı boş..!!");
            }
           


        }

        private void Form1_Activated(object sender, EventArgs e)
        {



            if (tumSefer.BackColor == Color.AliceBlue)
            {
                label2.Text = tumSefer.Text;
                tumSeferDataGridGuncelle();
            }
            else if (guncelSefer.BackColor == Color.AliceBlue)
            {
                label2.Text = guncelSefer.Text;
                guncelSeferDataGridGuncelle();
            }
            else
            {
                label2.Text = gecmisSefer.Text;
                gecmisSeferDataGridGuncelle();
            }
            if(bilet.BackColor == Color.AliceBlue)
            {
                koltukListesiGuncelle();
            }
            


        }
        private void koltukListesiGuncelle()
        {
            dataGridView3.Rows.Clear();
            SeferListeyeAtClass liste = new SeferListeyeAtClass();
            SeferListesi temp = liste.seferListeyeAt(seferNoBilet.Text, biletTarih.Text);



            string[] dizi = new string[4];
            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Name = "Koltuk No";
            dataGridView3.Columns[1].Name = "Yolcu Adı";
            dataGridView3.Columns[2].Name = "Cinsiyeti";
            dataGridView3.Columns[3].Name = "Durum";

            for (int i = 0; i < temp.dugumCek(0).koltukBilgileri.Count(); i++)
            {
                dizi[0] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).numara;
                dizi[1] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).yolcuAdi;
                dizi[2] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).yolcuCinsiyeti;
                dizi[3] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).durum;

                dataGridView3.Rows.Add(dizi);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = tumSefer.Text;
            sefer.BackColor = Color.AliceBlue;
            tumSefer.BackColor = Color.AliceBlue;
            tumSeferDataGridGuncelle();
        }


        private void tumSeferDataGridGuncelle()
        {
            int seferSayisi = 0;
            tumSefer.BackColor = Color.AliceBlue;
            gecmisSefer.BackColor = Color.LightGray;
            guncelSefer.BackColor = Color.LightGray;
            dataGridView1.Rows.Clear();
            SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();

            TarihListesi tarihtemp = new TarihListesi();

            string dosya_yolu = System.Windows.Forms.Application.StartupPath +"\\" + "Tarihler.txt";

            if (File.Exists(dosya_yolu))
            {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                StreamReader sw = new StreamReader(fs);

                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    tarihtemp.Ekle(yazi, listeyeAt.seferListeyeAt("", yazi));
                    yazi = sw.ReadLine();
                }

                sw.Close();
                fs.Close();

                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "Sefer No";
                dataGridView1.Columns[1].Name = "Güzergah";
                dataGridView1.Columns[2].Name = "Tarih";
                dataGridView1.Columns[3].Name = "Saat";
                dataGridView1.Columns[4].Name = "Kapasite";
                dataGridView1.Columns[5].Name = "Bilet Fiyatı";
                dataGridView1.Columns[6].Name = "Plaka";
                dataGridView1.Columns[7].Name = "Kaptan";
                

                string[] dizi = new string[8];


                for (int i = 0; i < tarihtemp.Count(); i++)
                {
                    seferSayisi += tarihtemp.dugumCek(i).sefer.Count();
                    for (int j = 0; j < tarihtemp.dugumCek(i).sefer.Count(); j++)
                    {
                        dizi[0] = tarihtemp.dugumCek(i).sefer.dugumCek(j).seferNo;
                        dizi[1] = tarihtemp.dugumCek(i).sefer.dugumCek(j).guzergah;
                        dizi[2] = tarihtemp.dugumCek(i).sefer.dugumCek(j).tarih;
                        dizi[3] = tarihtemp.dugumCek(i).sefer.dugumCek(j).saat;
                        dizi[4] = tarihtemp.dugumCek(i).sefer.dugumCek(j).kapasite;
                        dizi[5] = tarihtemp.dugumCek(i).sefer.dugumCek(j).fiyat.ToString();
                        dizi[6] = tarihtemp.dugumCek(i).sefer.dugumCek(j).plaka;
                        dizi[7] = tarihtemp.dugumCek(i).sefer.dugumCek(j).kaptan;


                        dataGridView1.Rows.Add(dizi);
                    }
                }
                sefers.Text = seferSayisi.ToString();
            }
            else
            {
                
            }
        }
        private void guncelSeferDataGridGuncelle()
        {
            int seferSayisi = 0;
            tumSefer.BackColor = Color.LightGray;
            gecmisSefer.BackColor = Color.LightGray;
            guncelSefer.BackColor = Color.AliceBlue;
            dataGridView1.Rows.Clear();
            SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();

            TarihListesi tarihtemp = new TarihListesi();

            string dosya_yolu = System.Windows.Forms.Application.StartupPath  +"\\"+ "Tarihler.txt";

            if (File.Exists(dosya_yolu))
            {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                StreamReader sw = new StreamReader(fs);

                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    DateTime tarih = Convert.ToDateTime(yazi);
                    if (tarih >= DateTime.Today.Date)
                    {
                        tarihtemp.Ekle(yazi, listeyeAt.seferListeyeAt("", yazi));
                    }

                    yazi = sw.ReadLine();
                }

                sw.Close();
                fs.Close();

                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "Sefer No";
                dataGridView1.Columns[1].Name = "Güzergah";
                dataGridView1.Columns[2].Name = "Tarih";
                dataGridView1.Columns[3].Name = "Saat";
                dataGridView1.Columns[4].Name = "Kapasite";
                dataGridView1.Columns[5].Name = "Bilet Fiyatı";
                dataGridView1.Columns[6].Name = "Plaka";
                dataGridView1.Columns[7].Name = "Kaptan";
                

                string[] dizi = new string[8];


                for (int i = 0; i < tarihtemp.Count(); i++)
                {
                    seferSayisi += tarihtemp.dugumCek(i).sefer.Count();
                    for (int j = 0; j < tarihtemp.dugumCek(i).sefer.Count(); j++)
                    {
                        dizi[0] = tarihtemp.dugumCek(i).sefer.dugumCek(j).seferNo;
                        dizi[1] = tarihtemp.dugumCek(i).sefer.dugumCek(j).guzergah;
                        dizi[2] = tarihtemp.dugumCek(i).sefer.dugumCek(j).tarih;
                        dizi[3] = tarihtemp.dugumCek(i).sefer.dugumCek(j).saat;
                        dizi[4] = tarihtemp.dugumCek(i).sefer.dugumCek(j).kapasite;
                        dizi[5] = tarihtemp.dugumCek(i).sefer.dugumCek(j).fiyat.ToString();
                        dizi[6] = tarihtemp.dugumCek(i).sefer.dugumCek(j).plaka;
                        dizi[7] = tarihtemp.dugumCek(i).sefer.dugumCek(j).kaptan;


                        dataGridView1.Rows.Add(dizi);
                    }
                }

                sefers.Text = seferSayisi.ToString();


            }
            else
            {
               
            }
        }
        private void guncelSeferDataGridGuncelle2()
        {
            int seferSayisi = 0;
            tumSefer.BackColor = Color.LightGray;
            gecmisSefer.BackColor = Color.LightGray;
            guncelSefer.BackColor = Color.AliceBlue;
            dataGridView2.Rows.Clear();
            SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();

            TarihListesi tarihtemp = new TarihListesi();

            string dosya_yolu = System.Windows.Forms.Application.StartupPath+"\\"  + "Tarihler.txt";

            if (File.Exists(dosya_yolu))
            {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                StreamReader sw = new StreamReader(fs);

                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    DateTime tarih = Convert.ToDateTime(yazi);
                    if (tarih >= DateTime.Today.Date)
                    {
                        tarihtemp.Ekle(yazi, listeyeAt.seferListeyeAt("", yazi));
                    }

                    yazi = sw.ReadLine();
                }

                sw.Close();
                fs.Close();

                dataGridView2.ColumnCount = 8;
                dataGridView2.Columns[0].Name = "Sefer No";
                dataGridView2.Columns[1].Name = "Güzergah";
                dataGridView2.Columns[2].Name = "Tarih";
                dataGridView2.Columns[3].Name = "Saat";
                dataGridView2.Columns[4].Name = "Kapasite";
                dataGridView2.Columns[5].Name = "Bilet Fiyatı";
                dataGridView2.Columns[6].Name = "Plaka";
                dataGridView2.Columns[7].Name = "Kaptan";
                

                string[] dizi = new string[8];


                for (int i = 0; i < tarihtemp.Count(); i++)
                {
                    seferSayisi += tarihtemp.dugumCek(i).sefer.Count();
                    for (int j = 0; j < tarihtemp.dugumCek(i).sefer.Count(); j++)
                    {
                        dizi[0] = tarihtemp.dugumCek(i).sefer.dugumCek(j).seferNo;
                        dizi[1] = tarihtemp.dugumCek(i).sefer.dugumCek(j).guzergah;
                        dizi[2] = tarihtemp.dugumCek(i).sefer.dugumCek(j).tarih;
                        dizi[3] = tarihtemp.dugumCek(i).sefer.dugumCek(j).saat;
                        dizi[4] = tarihtemp.dugumCek(i).sefer.dugumCek(j).kapasite;
                        dizi[5] = tarihtemp.dugumCek(i).sefer.dugumCek(j).fiyat.ToString();
                        dizi[6] = tarihtemp.dugumCek(i).sefer.dugumCek(j).plaka;
                        dizi[7] = tarihtemp.dugumCek(i).sefer.dugumCek(j).kaptan;


                        dataGridView2.Rows.Add(dizi);
                    }
                }

                sefers.Text = seferSayisi.ToString();


            }
            else
            {

            }
        }
        private void gecmisSeferDataGridGuncelle()
        {
            int seferSayisi = 0;
            tumSefer.BackColor = Color.LightGray;
            gecmisSefer.BackColor = Color.AliceBlue;
            guncelSefer.BackColor = Color.LightGray;
            dataGridView1.Rows.Clear();
            SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();

            TarihListesi tarihtemp = new TarihListesi();

            string dosya_yolu = System.Windows.Forms.Application.StartupPath +"\\" + "Tarihler.txt";

            if (File.Exists(dosya_yolu))
            {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                StreamReader sw = new StreamReader(fs);

                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    DateTime tarih = Convert.ToDateTime(yazi);
                    if (tarih < DateTime.Today.Date)
                    {
                        tarihtemp.Ekle(yazi, listeyeAt.seferListeyeAt("", yazi));
                    }

                    yazi = sw.ReadLine();
                }

                sw.Close();
                fs.Close();

                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].Name = "Sefer No";
                dataGridView1.Columns[1].Name = "Güzergah";
                dataGridView1.Columns[2].Name = "Tarih";
                dataGridView1.Columns[3].Name = "Saat";
                dataGridView1.Columns[4].Name = "Kapasite";
                dataGridView1.Columns[5].Name = "Bilet Fiyatı";
                dataGridView1.Columns[6].Name = "Plaka";
                dataGridView1.Columns[7].Name = "Kaptan";
                

                string[] dizi = new string[8];


                for (int i = 0; i < tarihtemp.Count(); i++)
                {
                    seferSayisi += tarihtemp.dugumCek(i).sefer.Count();
                    for (int j = 0; j < tarihtemp.dugumCek(i).sefer.Count(); j++)
                    {
                        dizi[0] = tarihtemp.dugumCek(i).sefer.dugumCek(j).seferNo;
                        dizi[1] = tarihtemp.dugumCek(i).sefer.dugumCek(j).guzergah;
                        dizi[2] = tarihtemp.dugumCek(i).sefer.dugumCek(j).tarih;
                        dizi[3] = tarihtemp.dugumCek(i).sefer.dugumCek(j).saat;
                        dizi[4] = tarihtemp.dugumCek(i).sefer.dugumCek(j).kapasite;
                        dizi[5] = tarihtemp.dugumCek(i).sefer.dugumCek(j).fiyat.ToString();
                        dizi[6] = tarihtemp.dugumCek(i).sefer.dugumCek(j).plaka;
                        dizi[7] = tarihtemp.dugumCek(i).sefer.dugumCek(j).kaptan;


                        dataGridView1.Rows.Add(dizi);
                    }
                }


                sefers.Text = seferSayisi.ToString();

            }
            else
            {
                
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            double fiyat = 0;
            SeferListeyeAtClass liste = new SeferListeyeAtClass();
            SeferListesi temp = liste.seferListeyeAt(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

            KoltukListele form = new KoltukListele();
            string[] dizi = new string[4];
            form.dataGridView1.ColumnCount = 4;
            form.dataGridView1.Columns[0].Name = "Koltuk No";
            form.dataGridView1.Columns[1].Name = "Yolcu Adı";
            form.dataGridView1.Columns[2].Name = "Cinsiyeti";
            form.dataGridView1.Columns[3].Name = "Durum";

            for (int i=0; i < temp.dugumCek(0).koltukBilgileri.Count(); i++)
            {
                dizi[0] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).numara;
                dizi[1] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).yolcuAdi;
                dizi[2] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).yolcuCinsiyeti;
                dizi[3] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).durum;

                form.dataGridView1.Rows.Add(dizi);
            }
            fiyat = (temp.dugumCek(0).koltukBilgileri.kacKoltukDolu()) * (temp.dugumCek(0).fiyat);
            form.label2.Text = fiyat.ToString();
            form.ShowDialog();

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView3.Rows.Clear();
            SeferListeyeAtClass liste = new SeferListeyeAtClass();
            SeferListesi temp = liste.seferListeyeAt(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
            biletTarih.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            seferNoBilet.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();



            string[] dizi = new string[4];
            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Name = "Koltuk No";
            dataGridView3.Columns[1].Name = "Yolcu Adı";
            dataGridView3.Columns[2].Name = "Cinsiyeti";
            dataGridView3.Columns[3].Name = "Durum";

            for (int i = 0; i < temp.dugumCek(0).koltukBilgileri.Count(); i++)
            {
                dizi[0] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).numara;
                dizi[1] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).yolcuAdi;
                dizi[2] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).yolcuCinsiyeti;
                dizi[3] = temp.dugumCek(0).koltukBilgileri.dugumCek(i).durum;

                dataGridView3.Rows.Add(dizi);
            }
        }
       

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if(dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString()=="Boş")
            {
                BiletKes x = new BiletKes();
                x.label6.Text = biletTarih.Text;
                x.label5.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
                x.label7.Text = seferNoBilet.Text;
                x.ShowDialog();
            }
            else
            {
                Biletİptal x = new Biletİptal();
                x.label10.Text = biletTarih.Text;
                x.label6.Text = seferNoBilet.Text;
                x.label7.Text= dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
                x.label8.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                x.label9.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
                x.ShowDialog();
            }

            
        }
    }
}
