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
            panel1.Visible = true;
            sefer.BackColor = Color.AliceBlue;
            bilet.BackColor = Color.LightGray;
        }

        private void bilet_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            sefer.BackColor = Color.LightGray;
            bilet.BackColor = Color.AliceBlue;
        }

        private void seferEkle_Click(object sender, EventArgs e)
        {
            seferEkle f = new seferEkle();
            
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeferSil f = new SeferSil();
            f.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();
            
            TarihListesi tarihtemp = new TarihListesi();
            
            string dosya_yolu = @"C:\Users\fed\Desktop\YazGel_Txt_Dosyalari\Tarihler.txt";

            if (File.Exists(dosya_yolu))
            {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                StreamReader sw = new StreamReader(fs);

                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    tarihtemp.Ekle(yazi,listeyeAt.seferListeyeAt("",yazi));
                    yazi = sw.ReadLine();
                }

                sw.Close();
                fs.Close();

                dataGridView1.ColumnCount = 9;
                dataGridView1.Columns[0].Name = "Sefer No";
                dataGridView1.Columns[1].Name = "Güzergah";
                dataGridView1.Columns[2].Name = "Tarih";
                dataGridView1.Columns[3].Name = "Saat";
                dataGridView1.Columns[4].Name = "Kapasite";
                dataGridView1.Columns[5].Name = "Bilet Fiyatı";
                dataGridView1.Columns[6].Name = "Plaka";
                dataGridView1.Columns[7].Name = "Kaptan";
                dataGridView1.Columns[8].Name = "Yer Var mı?";

                string[] dizi = new string[8];

                
                for(int i=0; i<tarihtemp.Count(); i++)
                {
                    for(int j =0; j<tarihtemp.dugumCek(i).sefer.Count(); j++)
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




            }
            else
            {
                MessageBox.Show("Sefer veri tabanı boş..!!");
            }
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();

            TarihListesi tarihtemp = new TarihListesi();

            string dosya_yolu = @"C:\Users\fed\Desktop\YazGel_Txt_Dosyalari\Tarihler.txt";

            if (File.Exists(dosya_yolu))
            {
                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

                StreamReader sw = new StreamReader(fs);
                
                string yazi = sw.ReadLine();
                while (yazi != null)
                {
                    DateTime tarih = Convert.ToDateTime(yazi);
                    if(tarih< DateTime.Today.Date)
                    {
                        tarihtemp.Ekle(yazi, listeyeAt.seferListeyeAt("", yazi));
                    }
                        
                    yazi = sw.ReadLine();
                }

                sw.Close();
                fs.Close();

                dataGridView1.ColumnCount = 9;
                dataGridView1.Columns[0].Name = "Sefer No";
                dataGridView1.Columns[1].Name = "Güzergah";
                dataGridView1.Columns[2].Name = "Tarih";
                dataGridView1.Columns[3].Name = "Saat";
                dataGridView1.Columns[4].Name = "Kapasite";
                dataGridView1.Columns[5].Name = "Bilet Fiyatı";
                dataGridView1.Columns[6].Name = "Plaka";
                dataGridView1.Columns[7].Name = "Kaptan";
                dataGridView1.Columns[8].Name = "Yer Var mı?";

                string[] dizi = new string[8];


                for (int i = 0; i < tarihtemp.Count(); i++)
                {
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




            }
            else
            {
                MessageBox.Show("Sefer veri tabanı boş..!!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SeferListeyeAtClass listeyeAt = new SeferListeyeAtClass();

            TarihListesi tarihtemp = new TarihListesi();

            string dosya_yolu = @"C:\Users\fed\Desktop\YazGel_Txt_Dosyalari\Tarihler.txt";

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

                dataGridView1.ColumnCount = 9;
                dataGridView1.Columns[0].Name = "Sefer No";
                dataGridView1.Columns[1].Name = "Güzergah";
                dataGridView1.Columns[2].Name = "Tarih";
                dataGridView1.Columns[3].Name = "Saat";
                dataGridView1.Columns[4].Name = "Kapasite";
                dataGridView1.Columns[5].Name = "Bilet Fiyatı";
                dataGridView1.Columns[6].Name = "Plaka";
                dataGridView1.Columns[7].Name = "Kaptan";
                dataGridView1.Columns[8].Name = "Yer Var mı?";

                string[] dizi = new string[8];


                for (int i = 0; i < tarihtemp.Count(); i++)
                {
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




            }
            else
            {
                MessageBox.Show("Sefer veri tabanı boş..!!");
            }
        }
    }
}
