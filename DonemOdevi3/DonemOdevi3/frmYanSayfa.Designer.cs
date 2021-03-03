
namespace DonemOdevi3
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
            this.lstInceleme = new System.Windows.Forms.ListBox();
            this.pbxRenk = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblYuzdeGosterim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKisiGir = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // lstInceleme
            // 
            this.lstInceleme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInceleme.FormattingEnabled = true;
            this.lstInceleme.ItemHeight = 22;
            this.lstInceleme.Location = new System.Drawing.Point(14, 46);
            this.lstInceleme.Margin = new System.Windows.Forms.Padding(5);
            this.lstInceleme.Name = "lstInceleme";
            this.lstInceleme.Size = new System.Drawing.Size(207, 422);
            this.lstInceleme.TabIndex = 0;
            this.lstInceleme.SelectedIndexChanged += new System.EventHandler(this.lstInceleme_SelectedIndexChanged);
            // 
            // pbxRenk
            // 
            this.pbxRenk.BackColor = System.Drawing.Color.Red;
            this.pbxRenk.Location = new System.Drawing.Point(255, 221);
            this.pbxRenk.Margin = new System.Windows.Forms.Padding(5);
            this.pbxRenk.Name = "pbxRenk";
            this.pbxRenk.Size = new System.Drawing.Size(58, 57);
            this.pbxRenk.TabIndex = 1;
            this.pbxRenk.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Katılımcılar";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.ImageKey = "Double-J-Design-Super-Mono-3d-Load2-download.ico";
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(251, 363);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(132, 71);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Icojam-Blue-Bits-Document-add.ico");
            this.ımageList1.Images.SetKeyName(1, "Icojam-Blue-Bits-Document-delete.ico");
            this.ımageList1.Images.SetKeyName(2, "Double-J-Design-Super-Mono-3d-Load2-download.ico");
            this.ımageList1.Images.SetKeyName(3, "Double-J-Design-Super-Mono-3d-Button-round-cancel.ico");
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.ImageKey = "Double-J-Design-Super-Mono-3d-Button-round-cancel.ico";
            this.btnKapat.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(410, 363);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(5);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(132, 71);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblYuzdeGosterim
            // 
            this.lblYuzdeGosterim.AutoSize = true;
            this.lblYuzdeGosterim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYuzdeGosterim.Location = new System.Drawing.Point(341, 241);
            this.lblYuzdeGosterim.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYuzdeGosterim.Name = "lblYuzdeGosterim";
            this.lblYuzdeGosterim.Size = new System.Drawing.Size(156, 23);
            this.lblYuzdeGosterim.TabIndex = 6;
            this.lblYuzdeGosterim.Text = "Katılımcı Sayısı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kişi Ekle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKisiGir
            // 
            this.txtKisiGir.Location = new System.Drawing.Point(251, 71);
            this.txtKisiGir.Name = "txtKisiGir";
            this.txtKisiGir.Size = new System.Drawing.Size(294, 34);
            this.txtKisiGir.TabIndex = 8;
            this.txtKisiGir.TextChanged += new System.EventHandler(this.txtKisiGir_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "Icojam-Blue-Bits-Document-delete.ico";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(282, 125);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(101, 55);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.ImageKey = "Icojam-Blue-Bits-Document-add.ico";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(395, 125);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(101, 55);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmYanSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 522);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtKisiGir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblYuzdeGosterim);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxRenk);
            this.Controls.Add(this.lstInceleme);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmYanSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi sayfası";
            this.Load += new System.EventHandler(this.frmYanSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRenk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.ListBox lstInceleme;
        public System.Windows.Forms.PictureBox pbxRenk;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Button btnKapat;
        public System.Windows.Forms.Label lblYuzdeGosterim;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtKisiGir;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnEkle;
    }
}