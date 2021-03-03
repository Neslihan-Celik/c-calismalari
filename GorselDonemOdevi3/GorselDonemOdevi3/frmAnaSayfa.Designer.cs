
namespace GorselDonemOdevi3
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.lstKatilimci = new System.Windows.Forms.ListBox();
            this.lstOgrenci = new System.Windows.Forms.ListBox();
            this.btnIncele = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnHepsiniCikart = new System.Windows.Forms.Button();
            this.btnSeciliCikart = new System.Windows.Forms.Button();
            this.btnHepsiniEkle = new System.Windows.Forms.Button();
            this.btnSeciliEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMisafir = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lstKatilimci
            // 
            this.lstKatilimci.FormattingEnabled = true;
            this.lstKatilimci.ItemHeight = 20;
            this.lstKatilimci.Location = new System.Drawing.Point(423, 43);
            this.lstKatilimci.Margin = new System.Windows.Forms.Padding(4);
            this.lstKatilimci.Name = "lstKatilimci";
            this.lstKatilimci.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstKatilimci.Size = new System.Drawing.Size(226, 404);
            this.lstKatilimci.TabIndex = 21;
            this.toolTip1.SetToolTip(this.lstKatilimci, "Programa katılacak kişilerin listesi");
            // 
            // lstOgrenci
            // 
            this.lstOgrenci.FormattingEnabled = true;
            this.lstOgrenci.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstOgrenci.ItemHeight = 20;
            this.lstOgrenci.Items.AddRange(new object[] {
            "Deniz",
            "Derya",
            "Dilek",
            "Eda",
            "Elif",
            "Emin",
            "Fatma",
            "Fuat",
            "Halil",
            "Mehmet",
            "Mehtap",
            "Murat",
            "Mücahit",
            "Neslihan",
            "Osman"});
            this.lstOgrenci.Location = new System.Drawing.Point(44, 43);
            this.lstOgrenci.Margin = new System.Windows.Forms.Padding(4);
            this.lstOgrenci.Name = "lstOgrenci";
            this.lstOgrenci.ScrollAlwaysVisible = true;
            this.lstOgrenci.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstOgrenci.Size = new System.Drawing.Size(203, 364);
            this.lstOgrenci.TabIndex = 20;
            this.toolTip1.SetToolTip(this.lstOgrenci, "Öğrenci listesi");
            // 
            // btnIncele
            // 
            this.btnIncele.BackColor = System.Drawing.Color.White;
            this.btnIncele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncele.ImageKey = "Custom-Icon-Design-Pretty-Office-2-Personal-information.ico";
            this.btnIncele.ImageList = this.ımageList1;
            this.btnIncele.Location = new System.Drawing.Point(423, 493);
            this.btnIncele.Margin = new System.Windows.Forms.Padding(5);
            this.btnIncele.Name = "btnIncele";
            this.btnIncele.Size = new System.Drawing.Size(211, 75);
            this.btnIncele.TabIndex = 19;
            this.btnIncele.Text = "Kullanıcıları incele";
            this.btnIncele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnIncele, "Katılımcı listesini inceleyen ve düzenleyen buton");
            this.btnIncele.UseVisualStyleBackColor = false;
            this.btnIncele.Click += new System.EventHandler(this.btnIncele_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Double-J-Design-Super-Mono-3d-Button-round-arrow-right.ico");
            this.ımageList1.Images.SetKeyName(1, "Double-J-Design-Super-Mono-3d-Button-round-fast-forward.ico");
            this.ımageList1.Images.SetKeyName(2, "Double-J-Design-Super-Mono-3d-Button-round-fast-backward.ico");
            this.ımageList1.Images.SetKeyName(3, "Double-J-Design-Super-Mono-3d-Button-round-arrow-left.ico");
            this.ımageList1.Images.SetKeyName(4, "Custom-Icon-Design-Pretty-Office-2-Personal-information.ico");
            // 
            // btnHepsiniCikart
            // 
            this.btnHepsiniCikart.BackColor = System.Drawing.Color.White;
            this.btnHepsiniCikart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHepsiniCikart.ImageKey = "Double-J-Design-Super-Mono-3d-Button-round-fast-backward.ico";
            this.btnHepsiniCikart.ImageList = this.ımageList1;
            this.btnHepsiniCikart.Location = new System.Drawing.Point(287, 378);
            this.btnHepsiniCikart.Margin = new System.Windows.Forms.Padding(5);
            this.btnHepsiniCikart.Name = "btnHepsiniCikart";
            this.btnHepsiniCikart.Size = new System.Drawing.Size(99, 65);
            this.btnHepsiniCikart.TabIndex = 18;
            this.btnHepsiniCikart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnHepsiniCikart, "Tüm öğrencileri katılımcı listesinden çıkartan buton");
            this.btnHepsiniCikart.UseVisualStyleBackColor = false;
            this.btnHepsiniCikart.Click += new System.EventHandler(this.btnHepsiniCikart_Click);
            // 
            // btnSeciliCikart
            // 
            this.btnSeciliCikart.BackColor = System.Drawing.Color.White;
            this.btnSeciliCikart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeciliCikart.ImageKey = "Double-J-Design-Super-Mono-3d-Button-round-arrow-left.ico";
            this.btnSeciliCikart.ImageList = this.ımageList1;
            this.btnSeciliCikart.Location = new System.Drawing.Point(287, 162);
            this.btnSeciliCikart.Margin = new System.Windows.Forms.Padding(5);
            this.btnSeciliCikart.Name = "btnSeciliCikart";
            this.btnSeciliCikart.Size = new System.Drawing.Size(99, 65);
            this.btnSeciliCikart.TabIndex = 17;
            this.btnSeciliCikart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSeciliCikart, "Sadece seçili kişileri programadan çıkartan buton");
            this.btnSeciliCikart.UseVisualStyleBackColor = false;
            this.btnSeciliCikart.Click += new System.EventHandler(this.btnSeciliCikart_Click);
            // 
            // btnHepsiniEkle
            // 
            this.btnHepsiniEkle.BackColor = System.Drawing.Color.White;
            this.btnHepsiniEkle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHepsiniEkle.ImageKey = "Double-J-Design-Super-Mono-3d-Button-round-fast-forward.ico";
            this.btnHepsiniEkle.ImageList = this.ımageList1;
            this.btnHepsiniEkle.Location = new System.Drawing.Point(287, 271);
            this.btnHepsiniEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnHepsiniEkle.Name = "btnHepsiniEkle";
            this.btnHepsiniEkle.Size = new System.Drawing.Size(99, 65);
            this.btnHepsiniEkle.TabIndex = 16;
            this.btnHepsiniEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnHepsiniEkle, "Tüm öğrencileri katılımcı listesine ekleyen buton");
            this.btnHepsiniEkle.UseVisualStyleBackColor = false;
            this.btnHepsiniEkle.Click += new System.EventHandler(this.btnHepsiniEkle_Click);
            // 
            // btnSeciliEkle
            // 
            this.btnSeciliEkle.BackColor = System.Drawing.Color.White;
            this.btnSeciliEkle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeciliEkle.ImageKey = "Double-J-Design-Super-Mono-3d-Button-round-arrow-right.ico";
            this.btnSeciliEkle.ImageList = this.ımageList1;
            this.btnSeciliEkle.Location = new System.Drawing.Point(287, 44);
            this.btnSeciliEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnSeciliEkle.Name = "btnSeciliEkle";
            this.btnSeciliEkle.Size = new System.Drawing.Size(99, 65);
            this.btnSeciliEkle.TabIndex = 15;
            this.btnSeciliEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSeciliEkle, "Sadece seçili kişileri programa alan buton");
            this.btnSeciliEkle.UseVisualStyleBackColor = false;
            this.btnSeciliEkle.Click += new System.EventHandler(this.btnSeciliEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Katılımcı Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Öğrenci Listesi";
            // 
            // lstMisafir
            // 
            this.lstMisafir.FormattingEnabled = true;
            this.lstMisafir.ItemHeight = 20;
            this.lstMisafir.Location = new System.Drawing.Point(44, 455);
            this.lstMisafir.Name = "lstMisafir";
            this.lstMisafir.Size = new System.Drawing.Size(203, 124);
            this.lstMisafir.TabIndex = 22;
            this.toolTip1.SetToolTip(this.lstMisafir, "Misafir Bölümü bu bölüme yan sayfadan eklenen kişiler eklenir");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 429);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Misafir Öğrenci Listesi";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Bilgilendirme ";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstMisafir);
            this.Controls.Add(this.lstKatilimci);
            this.Controls.Add(this.lstOgrenci);
            this.Controls.Add(this.btnIncele);
            this.Controls.Add(this.btnHepsiniCikart);
            this.Controls.Add(this.btnSeciliCikart);
            this.Controls.Add(this.btnHepsiniEkle);
            this.Controls.Add(this.btnSeciliEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.toolTip1.SetToolTip(this, "Ana sayfa");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lstKatilimci;
        public System.Windows.Forms.ListBox lstOgrenci;
        public System.Windows.Forms.Button btnIncele;
        public System.Windows.Forms.Button btnHepsiniCikart;
        public System.Windows.Forms.Button btnSeciliCikart;
        public System.Windows.Forms.Button btnHepsiniEkle;
        public System.Windows.Forms.Button btnSeciliEkle;
        private System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox lstMisafir;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

