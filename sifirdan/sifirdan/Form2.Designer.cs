
namespace sifirdan
{
    partial class Form2
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
            this.kontrolListesi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kaydet = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.yazi = new System.Windows.Forms.Label();
            this.resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.SuspendLayout();
            // 
            // kontrolListesi
            // 
            this.kontrolListesi.FormattingEnabled = true;
            this.kontrolListesi.ItemHeight = 16;
            this.kontrolListesi.Location = new System.Drawing.Point(23, 51);
            this.kontrolListesi.Name = "kontrolListesi";
            this.kontrolListesi.Size = new System.Drawing.Size(156, 276);
            this.kontrolListesi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Listesi";
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydet.Location = new System.Drawing.Point(224, 198);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(160, 55);
            this.kaydet.TabIndex = 9;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // kapat
            // 
            this.kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kapat.Location = new System.Drawing.Point(224, 272);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(160, 55);
            this.kapat.TabIndex = 10;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // yazi
            // 
            this.yazi.AutoSize = true;
            this.yazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yazi.Location = new System.Drawing.Point(285, 77);
            this.yazi.Name = "yazi";
            this.yazi.Size = new System.Drawing.Size(120, 20);
            this.yazi.TabIndex = 11;
            this.yazi.Text = "Doluluk oranı";
            // 
            // resim
            // 
            this.resim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.resim.Location = new System.Drawing.Point(214, 63);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(65, 50);
            this.resim.TabIndex = 12;
            this.resim.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 375);
            this.Controls.Add(this.resim);
            this.Controls.Add(this.yazi);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kontrolListesi);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button kaydet;
        public System.Windows.Forms.Button kapat;
        public System.Windows.Forms.Label yazi;
        public System.Windows.Forms.PictureBox resim;
        public System.Windows.Forms.ListBox kontrolListesi;
        public System.Windows.Forms.Label label1;
    }
}