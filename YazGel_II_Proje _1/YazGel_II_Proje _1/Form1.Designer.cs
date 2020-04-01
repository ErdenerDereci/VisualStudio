namespace YazGel_II_Proje__1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sefer = new System.Windows.Forms.Button();
            this.bilet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sefers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guncelSefer = new System.Windows.Forms.Button();
            this.gecmisSefer = new System.Windows.Forms.Button();
            this.tumSefer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.seferNoBilet = new System.Windows.Forms.Label();
            this.biletTarih = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sefer
            // 
            this.sefer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sefer.Cursor = System.Windows.Forms.Cursors.Default;
            this.sefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sefer.Location = new System.Drawing.Point(768, 224);
            this.sefer.Name = "sefer";
            this.sefer.Size = new System.Drawing.Size(163, 36);
            this.sefer.TabIndex = 0;
            this.sefer.Text = "Sefer İşlemleri";
            this.sefer.UseVisualStyleBackColor = false;
            this.sefer.Click += new System.EventHandler(this.sefer_Click);
            // 
            // bilet
            // 
            this.bilet.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bilet.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bilet.Location = new System.Drawing.Point(768, 276);
            this.bilet.Name = "bilet";
            this.bilet.Size = new System.Drawing.Size(163, 36);
            this.bilet.TabIndex = 1;
            this.bilet.Text = "Bilet Satış işlemleri";
            this.bilet.UseVisualStyleBackColor = false;
            this.bilet.Click += new System.EventHandler(this.bilet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sefers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guncelSefer);
            this.panel1.Controls.Add(this.gecmisSefer);
            this.panel1.Controls.Add(this.tumSefer);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 558);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(580, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sefer Sil/Kaptan Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Üzerinde işlem yapmak istediğiniz seferi aşağıdaki listeden seçiniz:";
            // 
            // sefers
            // 
            this.sefers.AutoSize = true;
            this.sefers.Location = new System.Drawing.Point(398, 87);
            this.sefers.Name = "sefers";
            this.sefers.Size = new System.Drawing.Size(10, 13);
            this.sefers.TabIndex = 9;
            this.sefers.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sefer Sayisi: ";
            // 
            // guncelSefer
            // 
            this.guncelSefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guncelSefer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.guncelSefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelSefer.Location = new System.Drawing.Point(195, 82);
            this.guncelSefer.Name = "guncelSefer";
            this.guncelSefer.Size = new System.Drawing.Size(90, 23);
            this.guncelSefer.TabIndex = 7;
            this.guncelSefer.Text = "Güncel Seferler";
            this.guncelSefer.UseVisualStyleBackColor = false;
            this.guncelSefer.Click += new System.EventHandler(this.guncelSefer_Click);
            // 
            // gecmisSefer
            // 
            this.gecmisSefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gecmisSefer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gecmisSefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gecmisSefer.Location = new System.Drawing.Point(99, 82);
            this.gecmisSefer.Name = "gecmisSefer";
            this.gecmisSefer.Size = new System.Drawing.Size(90, 23);
            this.gecmisSefer.TabIndex = 6;
            this.gecmisSefer.Text = "Geçmiş Seferler";
            this.gecmisSefer.UseVisualStyleBackColor = false;
            this.gecmisSefer.Click += new System.EventHandler(this.gecmisSefer_Click);
            // 
            // tumSefer
            // 
            this.tumSefer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tumSefer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tumSefer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tumSefer.Location = new System.Drawing.Point(3, 82);
            this.tumSefer.Name = "tumSefer";
            this.tumSefer.Size = new System.Drawing.Size(90, 23);
            this.tumSefer.TabIndex = 5;
            this.tumSefer.Text = "Tüm Seferler";
            this.tumSefer.UseVisualStyleBackColor = false;
            this.tumSefer.Click += new System.EventHandler(this.tumSefer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(580, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sefer Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.seferEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.seferNoBilet);
            this.panel2.Controls.Add(this.biletTarih);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 564);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // seferNoBilet
            // 
            this.seferNoBilet.AutoSize = true;
            this.seferNoBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seferNoBilet.ForeColor = System.Drawing.Color.Blue;
            this.seferNoBilet.Location = new System.Drawing.Point(618, 66);
            this.seferNoBilet.Name = "seferNoBilet";
            this.seferNoBilet.Size = new System.Drawing.Size(83, 13);
            this.seferNoBilet.TabIndex = 17;
            this.seferNoBilet.Text = "Koltuk Listesi";
            // 
            // biletTarih
            // 
            this.biletTarih.AutoSize = true;
            this.biletTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletTarih.ForeColor = System.Drawing.Color.Blue;
            this.biletTarih.Location = new System.Drawing.Point(529, 66);
            this.biletTarih.Name = "biletTarih";
            this.biletTarih.Size = new System.Drawing.Size(83, 13);
            this.biletTarih.TabIndex = 16;
            this.biletTarih.Text = "Koltuk Listesi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(440, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Koltuk Listesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(689, 39);
            this.label5.TabIndex = 14;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(443, 82);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(304, 479);
            this.dataGridView3.TabIndex = 13;
            this.dataGridView3.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Güncel Seferler";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(431, 479);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(936, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bilet);
            this.Controls.Add(this.sefer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sefer;
        private System.Windows.Forms.Button bilet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sefers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guncelSefer;
        private System.Windows.Forms.Button gecmisSefer;
        private System.Windows.Forms.Button tumSefer;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label biletTarih;
        private System.Windows.Forms.Label seferNoBilet;
    }
}

