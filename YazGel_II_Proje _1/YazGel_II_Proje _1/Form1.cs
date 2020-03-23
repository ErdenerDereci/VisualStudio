using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
