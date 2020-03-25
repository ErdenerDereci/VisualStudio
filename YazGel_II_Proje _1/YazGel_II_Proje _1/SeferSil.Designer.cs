namespace YazGel_II_Proje__1
{
    partial class SeferSil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.RadioButton();
            this.kaptanGuncelle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(503, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İşlem yapmak istediğiniz sefere çift tıklayınız:";
            // 
            // sil
            // 
            this.sil.AutoSize = true;
            this.sil.Checked = true;
            this.sil.Location = new System.Drawing.Point(15, 25);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(36, 17);
            this.sil.TabIndex = 2;
            this.sil.TabStop = true;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            // 
            // kaptanGuncelle
            // 
            this.kaptanGuncelle.AutoSize = true;
            this.kaptanGuncelle.Location = new System.Drawing.Point(57, 25);
            this.kaptanGuncelle.Name = "kaptanGuncelle";
            this.kaptanGuncelle.Size = new System.Drawing.Size(104, 17);
            this.kaptanGuncelle.TabIndex = 3;
            this.kaptanGuncelle.TabStop = true;
            this.kaptanGuncelle.Text = "Kaptan Güncelle";
            this.kaptanGuncelle.UseVisualStyleBackColor = true;
            // 
            // SeferSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 468);
            this.Controls.Add(this.kaptanGuncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeferSil";
            this.Text = "SeferSil";
            this.Activated += new System.EventHandler(this.SeferSil_Activated);
            this.Load += new System.EventHandler(this.SeferSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton sil;
        private System.Windows.Forms.RadioButton kaptanGuncelle;
    }
}