﻿namespace YazGel_II_Proje__1
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
            this.sefer = new System.Windows.Forms.Button();
            this.bilet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sefers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guncelSefer = new System.Windows.Forms.Button();
            this.gecmisSefer = new System.Windows.Forms.Button();
            this.tumSefer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(611, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sefer Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Üzerinde işlem yapmak istediğiniz seferi aşağıdaki listeden seçiniz:";
            // 
            // sefers
            // 
            this.sefers.AutoSize = true;
            this.sefers.Location = new System.Drawing.Point(424, 87);
            this.sefers.Name = "sefers";
            this.sefers.Size = new System.Drawing.Size(10, 13);
            this.sefers.TabIndex = 9;
            this.sefers.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 87);
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
            this.button1.Location = new System.Drawing.Point(611, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(943, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bilet);
            this.Controls.Add(this.sefer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}
