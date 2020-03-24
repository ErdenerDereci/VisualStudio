namespace YazGel_II_Proje__1
{
    partial class seferEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.saat = new System.Windows.Forms.TextBox();
            this.kapasite = new System.Windows.Forms.TextBox();
            this.biletFiyati = new System.Windows.Forms.TextBox();
            this.plaka = new System.Windows.Forms.TextBox();
            this.kaptan = new System.Windows.Forms.TextBox();
            this.seferadd = new System.Windows.Forms.Button();
            this.nereden = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nereye = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarih: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kapasite: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bilet fiyatı: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Plaka: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kaptan: ";
            // 
            // tarih
            // 
            this.tarih.CalendarMonthBackground = System.Drawing.SystemColors.WindowText;
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(77, 70);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(100, 20);
            this.tarih.TabIndex = 8;
            this.tarih.Value = new System.DateTime(2020, 2, 24, 0, 0, 0, 0);
            // 
            // saat
            // 
            this.saat.Location = new System.Drawing.Point(77, 115);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(100, 20);
            this.saat.TabIndex = 9;
            // 
            // kapasite
            // 
            this.kapasite.Location = new System.Drawing.Point(77, 157);
            this.kapasite.Name = "kapasite";
            this.kapasite.Size = new System.Drawing.Size(100, 20);
            this.kapasite.TabIndex = 10;
            // 
            // biletFiyati
            // 
            this.biletFiyati.Location = new System.Drawing.Point(77, 199);
            this.biletFiyati.Name = "biletFiyati";
            this.biletFiyati.Size = new System.Drawing.Size(100, 20);
            this.biletFiyati.TabIndex = 11;
            // 
            // plaka
            // 
            this.plaka.Location = new System.Drawing.Point(77, 241);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(100, 20);
            this.plaka.TabIndex = 12;
            // 
            // kaptan
            // 
            this.kaptan.Location = new System.Drawing.Point(77, 283);
            this.kaptan.Name = "kaptan";
            this.kaptan.Size = new System.Drawing.Size(100, 20);
            this.kaptan.TabIndex = 13;
            // 
            // seferadd
            // 
            this.seferadd.Location = new System.Drawing.Point(15, 350);
            this.seferadd.Name = "seferadd";
            this.seferadd.Size = new System.Drawing.Size(75, 23);
            this.seferadd.TabIndex = 14;
            this.seferadd.Text = "Ekle";
            this.seferadd.UseVisualStyleBackColor = true;
            this.seferadd.Click += new System.EventHandler(this.seferadd_Click);
            // 
            // nereden
            // 
            this.nereden.FormattingEnabled = true;
            this.nereden.Items.AddRange(new object[] {
            "Kocaeli",
            "Ankara",
            "İstanbul",
            "İzmir"});
            this.nereden.Location = new System.Drawing.Point(77, 31);
            this.nereden.Name = "nereden";
            this.nereden.Size = new System.Drawing.Size(61, 21);
            this.nereden.TabIndex = 15;
            this.nereden.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nereye:";
            // 
            // nereye
            // 
            this.nereye.FormattingEnabled = true;
            this.nereye.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir"});
            this.nereye.Location = new System.Drawing.Point(216, 31);
            this.nereye.Name = "nereye";
            this.nereye.Size = new System.Drawing.Size(61, 21);
            this.nereye.TabIndex = 17;
            // 
            // seferEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 399);
            this.Controls.Add(this.nereye);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nereden);
            this.Controls.Add(this.seferadd);
            this.Controls.Add(this.kaptan);
            this.Controls.Add(this.plaka);
            this.Controls.Add(this.biletFiyati);
            this.Controls.Add(this.kapasite);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "seferEkle";
            this.Text = "seferEkle";
            this.Load += new System.EventHandler(this.seferEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox saat;
        private System.Windows.Forms.TextBox kapasite;
        private System.Windows.Forms.TextBox biletFiyati;
        private System.Windows.Forms.TextBox plaka;
        private System.Windows.Forms.TextBox kaptan;
        private System.Windows.Forms.Button seferadd;
        private System.Windows.Forms.ComboBox nereden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox nereye;
    }
}