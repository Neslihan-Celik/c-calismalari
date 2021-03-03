
namespace GorselDonemOdevi3
{
    partial class frmYanSayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYanSayfa));
            this.lblKisiGosterim = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pbxRenk = new System.Windows.Forms.PictureBox();
            this.lstInceleme = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtKisiGir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKisiGosterim
            // 
            this.lblKisiGosterim.AutoSize = true;
            this.lblKisiGosterim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKisiGosterim.Location = new System.Drawing.Point(357, 317);
            this.lblKisiGosterim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKisiGosterim.Name = "lblKisiGosterim";
            this.lblKisiGosterim.Size = new System.Drawing.Size(156, 23);
            this.lblKisiGosterim.TabIndex = 16;
            this.lblKisiGosterim.Text = "Katılımcı Sayısı : ";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.ImageKey = "Double-J-Design-Super-Mono-3d-Button-round-cancel.ico";
            this.btnKapat.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(431, 449);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(131, 70);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnKapat, "Çıkış butonu");
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Double-J-Design-Super-Mono-3d-Button-round-cancel.ico");
            this.ımageList1.Images.SetKeyName(1, "Double-J-Design-Super-Mono-3d-Load2-download.ico");
            this.ımageList1.Images.SetKeyName(2, "Icojam-Blue-Bits-Document-add.ico");
            this.ımageList1.Images.SetKeyName(3, "Icojam-Blue-Bits-Document-delete.ico");
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.ImageKey = "Double-J-Design-Super-Mono-3d-Load2-download.ico";
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(250, 449);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(131, 70);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnKaydet, "Tüm bilgileri onaylama butonu");
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(14, 23);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(117, 25);
            this.lblBaslik.TabIndex = 13;
            this.lblBaslik.Text = "Katılımcılar";
            // 
            // pbxRenk
            // 
            this.pbxRenk.BackColor = System.Drawing.Color.Red;
            this.pbxRenk.Location = new System.Drawing.Point(266, 294);
            this.pbxRenk.Margin = new System.Windows.Forms.Padding(5);
            this.pbxRenk.Name = "pbxRenk";
            this.pbxRenk.Size = new System.Drawing.Size(58, 58);
            this.pbxRenk.TabIndex = 12;
            this.pbxRenk.TabStop = false;
            this.toolTip1.SetToolTip(this.pbxRenk, "Durum göstergesi");
            // 
            // lstInceleme
            // 
            this.lstInceleme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInceleme.FormattingEnabled = true;
            this.lstInceleme.ItemHeight = 22;
            this.lstInceleme.Location = new System.Drawing.Point(14, 53);
            this.lstInceleme.Margin = new System.Windows.Forms.Padding(5);
            this.lstInceleme.Name = "lstInceleme";
            this.lstInceleme.Size = new System.Drawing.Size(207, 466);
            this.lstInceleme.TabIndex = 11;
            this.lstInceleme.SelectedIndexChanged += new System.EventHandler(this.lstInceleme_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageKey = "Icojam-Blue-Bits-Document-add.ico";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(412, 125);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(101, 67);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEkle, "Listeye kişi ekleme");
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "Icojam-Blue-Bits-Document-delete.ico";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(299, 125);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 67);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSil, "Listeden kişi silme");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtKisiGir
            // 
            this.txtKisiGir.Location = new System.Drawing.Point(268, 71);
            this.txtKisiGir.Name = "txtKisiGir";
            this.txtKisiGir.Size = new System.Drawing.Size(294, 22);
            this.txtKisiGir.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtKisiGir, "Listeye kişi ekleme");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Kişi Ekle";
            // 
            // frmYanSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 570);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtKisiGir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKisiGosterim);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.pbxRenk);
            this.Controls.Add(this.lstInceleme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYanSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yan Sayfa";
            this.toolTip1.SetToolTip(this, "Bilgi düzenleme sayfası");
            this.Load += new System.EventHandler(this.frmYanSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRenk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblKisiGosterim;
        public System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.PictureBox pbxRenk;
        public System.Windows.Forms.ListBox lstInceleme;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.TextBox txtKisiGir;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}