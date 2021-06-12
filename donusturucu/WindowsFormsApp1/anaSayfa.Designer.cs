namespace WindowsFormsApp1
{
    partial class anaSayfa
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
            this.btn_Hesap = new System.Windows.Forms.Button();
            this.btn_birim = new System.Windows.Forms.Button();
            this.btnBirim2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz yapmak istediğiniz işlemi seçiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Hesap
            // 
            this.btn_Hesap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Hesap.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hesap.Location = new System.Drawing.Point(63, 201);
            this.btn_Hesap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Hesap.Name = "btn_Hesap";
            this.btn_Hesap.Size = new System.Drawing.Size(230, 108);
            this.btn_Hesap.TabIndex = 1;
            this.btn_Hesap.Text = "Hesap Makinesi";
            this.btn_Hesap.UseVisualStyleBackColor = false;
            this.btn_Hesap.Click += new System.EventHandler(this.btn_Hesap_Click);
            // 
            // btn_birim
            // 
            this.btn_birim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_birim.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_birim.Location = new System.Drawing.Point(388, 201);
            this.btn_birim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_birim.Name = "btn_birim";
            this.btn_birim.Size = new System.Drawing.Size(230, 108);
            this.btn_birim.TabIndex = 2;
            this.btn_birim.Text = "1.Birim Dönüşüm Ekranı";
            this.btn_birim.UseVisualStyleBackColor = false;
            this.btn_birim.Click += new System.EventHandler(this.btn_birim_Click);
            // 
            // btnBirim2
            // 
            this.btnBirim2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBirim2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBirim2.Location = new System.Drawing.Point(213, 343);
            this.btnBirim2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBirim2.Name = "btnBirim2";
            this.btnBirim2.Size = new System.Drawing.Size(230, 108);
            this.btnBirim2.TabIndex = 3;
            this.btnBirim2.Text = "2. Birim Dönüşüm Ekranı";
            this.btnBirim2.UseVisualStyleBackColor = false;
            this.btnBirim2.Click += new System.EventHandler(this.btnBirim2_Click);
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(724, 502);
            this.Controls.Add(this.btnBirim2);
            this.Controls.Add(this.btn_birim);
            this.Controls.Add(this.btn_Hesap);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "anaSayfa";
            this.Text = "Seçim Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Hesap;
        private System.Windows.Forms.Button btn_birim;
        private System.Windows.Forms.Button btnBirim2;
    }
}