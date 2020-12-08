
namespace rastgelelCalisma
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
            this.txt_yazi = new System.Windows.Forms.Label();
            this.txt_yazi2 = new System.Windows.Forms.Label();
            this.txt_yazi3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_yazi
            // 
            this.txt_yazi.BackColor = System.Drawing.Color.White;
            this.txt_yazi.Location = new System.Drawing.Point(102, 54);
            this.txt_yazi.Name = "txt_yazi";
            this.txt_yazi.Size = new System.Drawing.Size(230, 173);
            this.txt_yazi.TabIndex = 0;
            this.txt_yazi.Text = "label1";
            // 
            // txt_yazi2
            // 
            this.txt_yazi2.BackColor = System.Drawing.Color.White;
            this.txt_yazi2.Location = new System.Drawing.Point(102, 288);
            this.txt_yazi2.Name = "txt_yazi2";
            this.txt_yazi2.Size = new System.Drawing.Size(230, 164);
            this.txt_yazi2.TabIndex = 1;
            this.txt_yazi2.Text = "yazı iki";
            // 
            // txt_yazi3
            // 
            this.txt_yazi3.BackColor = System.Drawing.Color.White;
            this.txt_yazi3.Location = new System.Drawing.Point(388, 9);
            this.txt_yazi3.Name = "txt_yazi3";
            this.txt_yazi3.Size = new System.Drawing.Size(316, 632);
            this.txt_yazi3.TabIndex = 2;
            this.txt_yazi3.Text = "random çoklu kişiler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 685);
            this.Controls.Add(this.txt_yazi3);
            this.Controls.Add(this.txt_yazi2);
            this.Controls.Add(this.txt_yazi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txt_yazi;
        private System.Windows.Forms.Label txt_yazi2;
        private System.Windows.Forms.Label txt_yazi3;
    }
}

