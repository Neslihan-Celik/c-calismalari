
namespace WindowsFormsApp1
{
    partial class birim
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
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btn_diger_sayfalar = new System.Windows.Forms.Button();
            this.txttaban = new System.Windows.Forms.TextBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 55);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı girniz";
            // 
            // txtsayi
            // 
            this.txtsayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayi.Location = new System.Drawing.Point(202, 52);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsayi.Size = new System.Drawing.Size(160, 30);
            this.txtsayi.TabIndex = 1;
            this.txtsayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deger);
            // 
            // btnhesapla
            // 
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(72, 185);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnhesapla.Size = new System.Drawing.Size(136, 39);
            this.btnhesapla.TabIndex = 3;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taban giriniz";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 269);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuç";
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.Color.White;
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Location = new System.Drawing.Point(186, 263);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSonuc.Size = new System.Drawing.Size(181, 31);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = " ";
            // 
            // btn_diger_sayfalar
            // 
            this.btn_diger_sayfalar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_diger_sayfalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diger_sayfalar.Location = new System.Drawing.Point(269, 354);
            this.btn_diger_sayfalar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_diger_sayfalar.Name = "btn_diger_sayfalar";
            this.btn_diger_sayfalar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_diger_sayfalar.Size = new System.Drawing.Size(98, 40);
            this.btn_diger_sayfalar.TabIndex = 61;
            this.btn_diger_sayfalar.Text = "Geri ";
            this.btn_diger_sayfalar.UseVisualStyleBackColor = false;
            this.btn_diger_sayfalar.Click += new System.EventHandler(this.btn_diger_sayfalar_Click);
            // 
            // txttaban
            // 
            this.txttaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttaban.Location = new System.Drawing.Point(202, 120);
            this.txttaban.Name = "txttaban";
            this.txttaban.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttaban.Size = new System.Drawing.Size(160, 30);
            this.txttaban.TabIndex = 62;
            this.txttaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deger);
            // 
            // btntemizle
            // 
            this.btntemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Location = new System.Drawing.Point(232, 185);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btntemizle.Size = new System.Drawing.Size(130, 39);
            this.btntemizle.TabIndex = 63;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // birim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(422, 432);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.txttaban);
            this.Controls.Add(this.btn_diger_sayfalar);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.label1);
            this.Name = "birim";
            this.Text = "Tabanlar arası dönüşüm ekranı";
            this.Load += new System.EventHandler(this.birim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btn_diger_sayfalar;
        private System.Windows.Forms.TextBox txttaban;
        private System.Windows.Forms.Button btntemizle;
    }
}