namespace YazGel_II_Proje__1
{
    partial class KaptanGuncelle
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.kaptan = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.seferno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kaptanText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(11, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Yukarıdaki bilgilere sahip olan \r\nkaptan güncellenecek!!";
            // 
            // kaptan
            // 
            this.kaptan.AutoSize = true;
            this.kaptan.Location = new System.Drawing.Point(73, 98);
            this.kaptan.Name = "kaptan";
            this.kaptan.Size = new System.Drawing.Size(35, 13);
            this.kaptan.TabIndex = 17;
            this.kaptan.Text = "label7";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Location = new System.Drawing.Point(73, 59);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(35, 13);
            this.tarih.TabIndex = 16;
            this.tarih.Text = "label6";
            // 
            // seferno
            // 
            this.seferno.AutoSize = true;
            this.seferno.Location = new System.Drawing.Point(73, 20);
            this.seferno.Name = "seferno";
            this.seferno.Size = new System.Drawing.Size(35, 13);
            this.seferno.TabIndex = 15;
            this.seferno.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kaptan :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "SeferNo :";
            // 
            // kaptanText
            // 
            this.kaptanText.Location = new System.Drawing.Point(114, 181);
            this.kaptanText.Name = "kaptanText";
            this.kaptanText.Size = new System.Drawing.Size(100, 20);
            this.kaptanText.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Kaptan ismi giriniz:";
            // 
            // KaptanGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kaptanText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kaptan);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.seferno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "KaptanGuncelle";
            this.Text = "KaptanGuncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label kaptan;
        public System.Windows.Forms.Label tarih;
        public System.Windows.Forms.Label seferno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kaptanText;
        private System.Windows.Forms.Label label5;
    }
}