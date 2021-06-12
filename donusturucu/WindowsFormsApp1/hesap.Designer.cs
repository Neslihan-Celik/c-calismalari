namespace WindowsFormsApp1
{
    partial class hesap
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
            this.btn_diger_sayfalar = new System.Windows.Forms.Button();
            this.btn_eksiIsaret = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.lbl_islemTut = new System.Windows.Forms.Label();
            this.txt_hesap = new System.Windows.Forms.TextBox();
            this.btn_kare = new System.Windows.Forms.Button();
            this.btn_esittir = new System.Windows.Forms.Button();
            this.btn_karekok = new System.Windows.Forms.Button();
            this.btn_yuzde = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_virgul = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_carpi = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.btn_eksi = new System.Windows.Forms.Button();
            this.btn_arti = new System.Windows.Forms.Button();
            this.btn_us = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_faktoriyel = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_diger_sayfalar
            // 
            this.btn_diger_sayfalar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_diger_sayfalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diger_sayfalar.Location = new System.Drawing.Point(437, 642);
            this.btn_diger_sayfalar.Name = "btn_diger_sayfalar";
            this.btn_diger_sayfalar.Size = new System.Drawing.Size(171, 42);
            this.btn_diger_sayfalar.TabIndex = 60;
            this.btn_diger_sayfalar.Text = "Geri ";
            this.btn_diger_sayfalar.UseVisualStyleBackColor = false;
            this.btn_diger_sayfalar.Click += new System.EventHandler(this.btn_diger_sayfalar_Click);
            // 
            // btn_eksiIsaret
            // 
            this.btn_eksiIsaret.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_eksiIsaret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eksiIsaret.Location = new System.Drawing.Point(326, 433);
            this.btn_eksiIsaret.Name = "btn_eksiIsaret";
            this.btn_eksiIsaret.Size = new System.Drawing.Size(139, 54);
            this.btn_eksiIsaret.TabIndex = 59;
            this.btn_eksiIsaret.Text = "-  +";
            this.btn_eksiIsaret.UseVisualStyleBackColor = false;
            this.btn_eksiIsaret.Click += new System.EventHandler(this.btn_eksiIsaret_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_sonuc);
            this.panel1.Controls.Add(this.lbl_islemTut);
            this.panel1.Location = new System.Drawing.Point(38, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 79);
            this.panel1.TabIndex = 58;
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.BackColor = System.Drawing.Color.White;
            this.lbl_sonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_sonuc.Enabled = false;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sonuc.Location = new System.Drawing.Point(3, 32);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(715, 47);
            this.lbl_sonuc.TabIndex = 28;
            this.lbl_sonuc.Text = "Sonuç :";
            // 
            // lbl_islemTut
            // 
            this.lbl_islemTut.BackColor = System.Drawing.Color.White;
            this.lbl_islemTut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_islemTut.Location = new System.Drawing.Point(3, 0);
            this.lbl_islemTut.Name = "lbl_islemTut";
            this.lbl_islemTut.Size = new System.Drawing.Size(715, 32);
            this.lbl_islemTut.TabIndex = 0;
            // 
            // txt_hesap
            // 
            this.txt_hesap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_hesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hesap.ForeColor = System.Drawing.Color.Black;
            this.txt_hesap.Location = new System.Drawing.Point(38, 25);
            this.txt_hesap.Multiline = true;
            this.txt_hesap.Name = "txt_hesap";
            this.txt_hesap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_hesap.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_hesap.Size = new System.Drawing.Size(570, 51);
            this.txt_hesap.TabIndex = 57;
            this.txt_hesap.TextChanged += new System.EventHandler(this.txt_hesap_TextChanged);
            // 
            // btn_kare
            // 
            this.btn_kare.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_kare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kare.ForeColor = System.Drawing.Color.White;
            this.btn_kare.Location = new System.Drawing.Point(471, 245);
            this.btn_kare.Name = "btn_kare";
            this.btn_kare.Size = new System.Drawing.Size(137, 51);
            this.btn_kare.TabIndex = 56;
            this.btn_kare.Text = "Kare";
            this.btn_kare.UseVisualStyleBackColor = false;
            this.btn_kare.Click += new System.EventHandler(this.btn_kare_Click);
            // 
            // btn_esittir
            // 
            this.btn_esittir.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esittir.ForeColor = System.Drawing.Color.White;
            this.btn_esittir.Location = new System.Drawing.Point(471, 369);
            this.btn_esittir.Name = "btn_esittir";
            this.btn_esittir.Size = new System.Drawing.Size(137, 246);
            this.btn_esittir.TabIndex = 55;
            this.btn_esittir.Text = "=";
            this.btn_esittir.UseVisualStyleBackColor = false;
            this.btn_esittir.Click += new System.EventHandler(this.btn_esittir_Click);
            // 
            // btn_karekok
            // 
            this.btn_karekok.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_karekok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_karekok.ForeColor = System.Drawing.Color.White;
            this.btn_karekok.Location = new System.Drawing.Point(319, 185);
            this.btn_karekok.Name = "btn_karekok";
            this.btn_karekok.Size = new System.Drawing.Size(137, 51);
            this.btn_karekok.TabIndex = 54;
            this.btn_karekok.Text = "√¯";
            this.btn_karekok.UseVisualStyleBackColor = false;
            this.btn_karekok.Click += new System.EventHandler(this.btn_karekok_Click);
            // 
            // btn_yuzde
            // 
            this.btn_yuzde.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_yuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yuzde.ForeColor = System.Drawing.Color.White;
            this.btn_yuzde.Location = new System.Drawing.Point(181, 183);
            this.btn_yuzde.Name = "btn_yuzde";
            this.btn_yuzde.Size = new System.Drawing.Size(137, 51);
            this.btn_yuzde.TabIndex = 53;
            this.btn_yuzde.Text = "%";
            this.btn_yuzde.UseVisualStyleBackColor = false;
            this.btn_yuzde.Click += new System.EventHandler(this.btn_yuzde_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(181, 369);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(128, 58);
            this.btn_8.TabIndex = 52;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.AutoSizeChanged += new System.EventHandler(this.btn_secim);
            this.btn_8.Click += new System.EventHandler(this.btn_secim);
            // 
            // btn_virgul
            // 
            this.btn_virgul.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_virgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_virgul.Location = new System.Drawing.Point(36, 430);
            this.btn_virgul.Name = "btn_virgul";
            this.btn_virgul.Size = new System.Drawing.Size(137, 54);
            this.btn_virgul.TabIndex = 51;
            this.btn_virgul.Text = ",";
            this.btn_virgul.UseVisualStyleBackColor = false;
            this.btn_virgul.Click += new System.EventHandler(this.btn_virgul_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(38, 302);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(128, 57);
            this.btn_4.TabIndex = 50;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.AutoSizeChanged += new System.EventHandler(this.btn_secim);
            this.btn_4.Click += new System.EventHandler(this.btn_secim);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(38, 367);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(128, 57);
            this.btn_7.TabIndex = 49;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.AutoSizeChanged += new System.EventHandler(this.btn_secim);
            this.btn_7.Click += new System.EventHandler(this.btn_secim);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_C.ForeColor = System.Drawing.Color.Snow;
            this.btn_C.Location = new System.Drawing.Point(326, 559);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(139, 56);
            this.btn_C.TabIndex = 48;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(329, 243);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(127, 57);
            this.btn_3.TabIndex = 47;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_secim);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(329, 306);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(127, 57);
            this.btn_6.TabIndex = 46;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.AutoSizeChanged += new System.EventHandler(this.btn_secim);
            this.btn_6.Click += new System.EventHandler(this.btn_secim);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(181, 433);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(128, 54);
            this.btn_0.TabIndex = 45;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_secim);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Snow;
            this.btn_delete.Location = new System.Drawing.Point(36, 559);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 56);
            this.btn_delete.TabIndex = 44;
            this.btn_delete.Text = "DEL";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(181, 243);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(128, 57);
            this.btn_2.TabIndex = 43;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.AutoSizeChanged += new System.EventHandler(this.btn_secim);
            this.btn_2.Click += new System.EventHandler(this.btn_secim);
            // 
            // btn_carpi
            // 
            this.btn_carpi.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_carpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_carpi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_carpi.Location = new System.Drawing.Point(326, 489);
            this.btn_carpi.Name = "btn_carpi";
            this.btn_carpi.Size = new System.Drawing.Size(139, 58);
            this.btn_carpi.TabIndex = 42;
            this.btn_carpi.Text = "x";
            this.btn_carpi.UseVisualStyleBackColor = false;
            this.btn_carpi.Click += new System.EventHandler(this.btn_carpi_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bol.Location = new System.Drawing.Point(471, 309);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(137, 54);
            this.btn_bol.TabIndex = 41;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = false;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // btn_eksi
            // 
            this.btn_eksi.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_eksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eksi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eksi.Location = new System.Drawing.Point(183, 490);
            this.btn_eksi.Name = "btn_eksi";
            this.btn_eksi.Size = new System.Drawing.Size(137, 57);
            this.btn_eksi.TabIndex = 40;
            this.btn_eksi.Text = "-";
            this.btn_eksi.UseVisualStyleBackColor = false;
            this.btn_eksi.Click += new System.EventHandler(this.btn_eksi_Click);
            // 
            // btn_arti
            // 
            this.btn_arti.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_arti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_arti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_arti.Location = new System.Drawing.Point(36, 490);
            this.btn_arti.Name = "btn_arti";
            this.btn_arti.Size = new System.Drawing.Size(137, 57);
            this.btn_arti.TabIndex = 39;
            this.btn_arti.Text = "+";
            this.btn_arti.UseVisualStyleBackColor = false;
            this.btn_arti.Click += new System.EventHandler(this.btn_arti_Click);
            // 
            // btn_us
            // 
            this.btn_us.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_us.ForeColor = System.Drawing.Color.White;
            this.btn_us.Location = new System.Drawing.Point(469, 185);
            this.btn_us.Name = "btn_us";
            this.btn_us.Size = new System.Drawing.Size(137, 51);
            this.btn_us.TabIndex = 38;
            this.btn_us.Text = "^";
            this.btn_us.UseVisualStyleBackColor = false;
            this.btn_us.Click += new System.EventHandler(this.btn_us_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(181, 305);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(128, 58);
            this.btn_5.TabIndex = 37;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.AutoSizeChanged += new System.EventHandler(this.btn_secim);
            this.btn_5.Click += new System.EventHandler(this.btn_secim);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(328, 369);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(128, 57);
            this.btn_9.TabIndex = 36;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.AutoSizeChanged += new System.EventHandler(this.btn_secim);
            this.btn_9.Click += new System.EventHandler(this.btn_secim);
            // 
            // btn_CE
            // 
            this.btn_CE.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CE.ForeColor = System.Drawing.Color.Snow;
            this.btn_CE.Location = new System.Drawing.Point(181, 559);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(139, 56);
            this.btn_CE.TabIndex = 35;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_faktoriyel
            // 
            this.btn_faktoriyel.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_faktoriyel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_faktoriyel.ForeColor = System.Drawing.Color.White;
            this.btn_faktoriyel.Location = new System.Drawing.Point(38, 183);
            this.btn_faktoriyel.Name = "btn_faktoriyel";
            this.btn_faktoriyel.Size = new System.Drawing.Size(137, 51);
            this.btn_faktoriyel.TabIndex = 34;
            this.btn_faktoriyel.Text = "!";
            this.btn_faktoriyel.UseVisualStyleBackColor = false;
            this.btn_faktoriyel.Click += new System.EventHandler(this.btn_faktoriyel_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(38, 240);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(128, 57);
            this.btn_1.TabIndex = 33;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.AutoSizeChanged += new System.EventHandler(this.btn_secim);
            this.btn_1.Click += new System.EventHandler(this.btn_secim);
            // 
            // hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(662, 696);
            this.Controls.Add(this.btn_diger_sayfalar);
            this.Controls.Add(this.btn_eksiIsaret);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_hesap);
            this.Controls.Add(this.btn_kare);
            this.Controls.Add(this.btn_esittir);
            this.Controls.Add(this.btn_karekok);
            this.Controls.Add(this.btn_yuzde);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_virgul);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_carpi);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.btn_eksi);
            this.Controls.Add(this.btn_arti);
            this.Controls.Add(this.btn_us);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_faktoriyel);
            this.Controls.Add(this.btn_1);
            this.Name = "hesap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.hesap_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_diger_sayfalar;
        private System.Windows.Forms.Button btn_eksiIsaret;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label lbl_islemTut;
        public System.Windows.Forms.TextBox txt_hesap;
        private System.Windows.Forms.Button btn_kare;
        private System.Windows.Forms.Button btn_esittir;
        private System.Windows.Forms.Button btn_karekok;
        private System.Windows.Forms.Button btn_yuzde;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_virgul;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_carpi;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button btn_eksi;
        private System.Windows.Forms.Button btn_arti;
        private System.Windows.Forms.Button btn_us;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_faktoriyel;
        private System.Windows.Forms.Button btn_1;
    }
}

