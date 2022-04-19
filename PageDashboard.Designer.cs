namespace Aplikasi_Perpustakaan
{
    partial class PageDashboard
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
            this.buttonPeminjaman = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelGreeting
            // 
            this.LabelGreeting.AutoSize = true;
            this.LabelGreeting.Font = new System.Drawing.Font("Gaegu", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGreeting.Location = new System.Drawing.Point(124, 133);
            this.LabelGreeting.Name = "LabelGreeting";
            this.LabelGreeting.Size = new System.Drawing.Size(447, 35);
            this.LabelGreeting.TabIndex = 0;
            this.LabelGreeting.Text = "Selamat Datang di MyLibrary";
            this.LabelGreeting.Click += new System.EventHandler(this.LabelGreeting_Click);
            // 
            // LabelChooseLang
            // 
            this.LabelChooseLang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelChooseLang.AutoSize = true;
            this.LabelChooseLang.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChooseLang.Location = new System.Drawing.Point(604, 10);
            this.LabelChooseLang.Name = "LabelChooseLang";
            this.LabelChooseLang.Size = new System.Drawing.Size(70, 15);
            this.LabelChooseLang.TabIndex = 4;
            this.LabelChooseLang.Text = "Pilih Bahasa";
            this.LabelChooseLang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelChooseLang.Click += new System.EventHandler(this.LabelChooseLang_Click);
            // 
            // btn_idn
            // 
            this.btn_idn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_idn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_idn.Location = new System.Drawing.Point(595, 36);
            this.btn_idn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_idn.Name = "btn_idn";
            this.btn_idn.Size = new System.Drawing.Size(88, 29);
            this.btn_idn.TabIndex = 5;
            this.btn_idn.Text = "Indonesia";
            this.btn_idn.UseVisualStyleBackColor = true;
            this.btn_idn.Click += new System.EventHandler(this.btn_idn_Click);
            // 
            // btn_en
            // 
            this.btn_en.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_en.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_en.Location = new System.Drawing.Point(595, 69);
            this.btn_en.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(88, 30);
            this.btn_en.TabIndex = 6;
            this.btn_en.Text = "Inggris";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.MintCream;
            this.buttonBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBook.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBook.Location = new System.Drawing.Point(107, 258);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(145, 62);
            this.buttonBook.TabIndex = 7;
            this.buttonBook.Text = "Data Buku";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonPeminjaman
            // 
            this.buttonPeminjaman.BackColor = System.Drawing.Color.MintCream;
            this.buttonPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPeminjaman.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPeminjaman.Location = new System.Drawing.Point(281, 258);
            this.buttonPeminjaman.Name = "buttonPeminjaman";
            this.buttonPeminjaman.Size = new System.Drawing.Size(145, 62);
            this.buttonPeminjaman.TabIndex = 8;
            this.buttonPeminjaman.Text = "Data Peminjaman";
            this.buttonPeminjaman.UseVisualStyleBackColor = false;
            this.buttonPeminjaman.Click += new System.EventHandler(this.buttonPeminjaman_Click);
            // 
            // buttonSearch
            // 

            this.buttonSearch.BackColor = System.Drawing.Color.MintCream;
            this.buttonSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(452, 258);
            this.buttonSearch.Name = "button1";
            this.buttonSearch.Size = new System.Drawing.Size(149, 62);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Cari Buku";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);

            // 
            // PageDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.buttonSearch);

            this.Controls.Add(this.buttonPeminjaman);
            this.Controls.Add(this.btn_en);
            this.Controls.Add(this.LabelChooseLang);
            this.Controls.Add(this.btn_idn);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.LabelGreeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button buttonPeminjaman;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonSearch;
    }
}

