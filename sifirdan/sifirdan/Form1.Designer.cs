
namespace sifirdan
{
    partial class Form1
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
            this.liste1 = new System.Windows.Forms.ListBox();
            this.liste2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tekEkle = new System.Windows.Forms.Button();
            this.tekCikart = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.cikart = new System.Windows.Forms.Button();
            this.incele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liste1
            // 
            this.liste1.FormattingEnabled = true;
            this.liste1.ItemHeight = 16;
            this.liste1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.liste1.Location = new System.Drawing.Point(23, 44);
            this.liste1.Name = "liste1";
            this.liste1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.liste1.Size = new System.Drawing.Size(156, 276);
            this.liste1.TabIndex = 0;
            // 
            // liste2
            // 
            this.liste2.FormattingEnabled = true;
            this.liste2.ItemHeight = 16;
            this.liste2.Location = new System.Drawing.Point(342, 44);
            this.liste2.Name = "liste2";
            this.liste2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.liste2.Size = new System.Drawing.Size(156, 276);
            this.liste2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Katılımcı";
            // 
            // tekEkle
            // 
            this.tekEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekEkle.Location = new System.Drawing.Point(225, 44);
            this.tekEkle.Name = "tekEkle";
            this.tekEkle.Size = new System.Drawing.Size(75, 42);
            this.tekEkle.TabIndex = 4;
            this.tekEkle.Text = ">";
            this.tekEkle.UseVisualStyleBackColor = true;
            this.tekEkle.Click += new System.EventHandler(this.tekEkle_Click);
            // 
            // tekCikart
            // 
            this.tekCikart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekCikart.Location = new System.Drawing.Point(225, 104);
            this.tekCikart.Name = "tekCikart";
            this.tekCikart.Size = new System.Drawing.Size(75, 42);
            this.tekCikart.TabIndex = 5;
            this.tekCikart.Text = "<";
            this.tekCikart.UseVisualStyleBackColor = true;
            this.tekCikart.Click += new System.EventHandler(this.tekCikart_Click);
            // 
            // ekle
            // 
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle.Location = new System.Drawing.Point(225, 185);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 42);
            this.ekle.TabIndex = 6;
            this.ekle.Text = ">>";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // cikart
            // 
            this.cikart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikart.Location = new System.Drawing.Point(225, 259);
            this.cikart.Name = "cikart";
            this.cikart.Size = new System.Drawing.Size(75, 42);
            this.cikart.TabIndex = 7;
            this.cikart.Text = "<<";
            this.cikart.UseVisualStyleBackColor = true;
            this.cikart.Click += new System.EventHandler(this.cikart_Click);
            // 
            // incele
            // 
            this.incele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incele.Location = new System.Drawing.Point(181, 332);
            this.incele.Name = "incele";
            this.incele.Size = new System.Drawing.Size(160, 55);
            this.incele.TabIndex = 8;
            this.incele.Text = "İncele";
            this.incele.UseVisualStyleBackColor = true;
            this.incele.Click += new System.EventHandler(this.incele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 406);
            this.Controls.Add(this.incele);
            this.Controls.Add(this.cikart);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.tekCikart);
            this.Controls.Add(this.tekEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liste2);
            this.Controls.Add(this.liste1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox liste1;
        public System.Windows.Forms.ListBox liste2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button tekEkle;
        public System.Windows.Forms.Button tekCikart;
        public System.Windows.Forms.Button ekle;
        public System.Windows.Forms.Button cikart;
        public System.Windows.Forms.Button incele;
    }
}

