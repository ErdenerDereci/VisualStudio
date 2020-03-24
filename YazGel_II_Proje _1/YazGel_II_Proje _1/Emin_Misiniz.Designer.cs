namespace YazGel_II_Proje__1
{
    partial class Emin_Misiniz
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seferno = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.kaptan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SeferNo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kaptan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarih :";
            // 
            // seferno
            // 
            this.seferno.AutoSize = true;
            this.seferno.Location = new System.Drawing.Point(71, 26);
            this.seferno.Name = "seferno";
            this.seferno.Size = new System.Drawing.Size(35, 13);
            this.seferno.TabIndex = 4;
            this.seferno.Text = "label5";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Location = new System.Drawing.Point(71, 65);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(35, 13);
            this.tarih.TabIndex = 5;
            this.tarih.Text = "label6";
            // 
            // kaptan
            // 
            this.kaptan.AutoSize = true;
            this.kaptan.Location = new System.Drawing.Point(71, 104);
            this.kaptan.Name = "kaptan";
            this.kaptan.Size = new System.Drawing.Size(35, 13);
            this.kaptan.TabIndex = 6;
            this.kaptan.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(9, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Yukarıdaki bilgilere sahip olan sefer silinecek!!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Evet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Devam etmek istediğinizden emin misiniz ?";
            // 
            // Emin_Misiniz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 290);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.kaptan);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.seferno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Emin_Misiniz";
            this.Text = "Emin_Misiniz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label seferno;
        public System.Windows.Forms.Label tarih;
        public System.Windows.Forms.Label kaptan;
    }
}