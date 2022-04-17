namespace Aplikasi_Perpustakaan
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
            this.LabelGreeting = new System.Windows.Forms.Label();
            this.LabelChooseLang = new System.Windows.Forms.Label();
            this.btn_idn = new System.Windows.Forms.Button();
            this.btn_en = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelGreeting
            // 
            this.LabelGreeting.AutoSize = true;
            this.LabelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGreeting.Location = new System.Drawing.Point(338, 29);
            this.LabelGreeting.Name = "LabelGreeting";
            this.LabelGreeting.Size = new System.Drawing.Size(195, 29);
            this.LabelGreeting.TabIndex = 0;
            this.LabelGreeting.Text = "Selamat Datang";
            this.LabelGreeting.Click += new System.EventHandler(this.LabelGreeting_Click);
            // 
            // LabelChooseLang
            // 
            this.LabelChooseLang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelChooseLang.AutoSize = true;
            this.LabelChooseLang.Location = new System.Drawing.Point(818, 16);
            this.LabelChooseLang.Name = "LabelChooseLang";
            this.LabelChooseLang.Size = new System.Drawing.Size(82, 16);
            this.LabelChooseLang.TabIndex = 4;
            this.LabelChooseLang.Text = "Pilih Bahasa";
            this.LabelChooseLang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_idn
            // 
            this.btn_idn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_idn.Location = new System.Drawing.Point(807, 34);
            this.btn_idn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_idn.Name = "btn_idn";
            this.btn_idn.Size = new System.Drawing.Size(108, 29);
            this.btn_idn.TabIndex = 5;
            this.btn_idn.Text = "Indonesia";
            this.btn_idn.UseVisualStyleBackColor = true;
            this.btn_idn.Click += new System.EventHandler(this.btn_idn_Click);
            // 
            // btn_en
            // 
            this.btn_en.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_en.Location = new System.Drawing.Point(807, 67);
            this.btn_en.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(108, 30);
            this.btn_en.TabIndex = 6;
            this.btn_en.Text = "Inggris";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBook.Location = new System.Drawing.Point(59, 533);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(145, 50);
            this.buttonBook.TabIndex = 7;
            this.buttonBook.Text = "Data Buku";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.btn_en);
            this.Controls.Add(this.LabelChooseLang);
            this.Controls.Add(this.btn_idn);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.LabelGreeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Aplikasi Perpustakaan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGreeting;
        private System.Windows.Forms.Label LabelChooseLang;
        private System.Windows.Forms.Button btn_idn;
        private System.Windows.Forms.Button btn_en;
        private System.Windows.Forms.Button buttonBook;
    }
}

