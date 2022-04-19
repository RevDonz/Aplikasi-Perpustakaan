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
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonPeminjaman = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelGreeting
            // 
            this.LabelGreeting.AutoSize = true;
            this.LabelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGreeting.Location = new System.Drawing.Point(374, 39);
            this.LabelGreeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelGreeting.Name = "LabelGreeting";
            this.LabelGreeting.Size = new System.Drawing.Size(195, 29);
            this.LabelGreeting.TabIndex = 0;
            this.LabelGreeting.Text = "Selamat Datang";
            this.LabelGreeting.Click += new System.EventHandler(this.LabelGreeting_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBook.Location = new System.Drawing.Point(13, 542);
            this.buttonBook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(193, 62);
            this.buttonBook.TabIndex = 7;
            this.buttonBook.Text = "Data Buku";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonPeminjaman
            // 
            this.buttonPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPeminjaman.Location = new System.Drawing.Point(235, 542);
            this.buttonPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPeminjaman.Name = "buttonPeminjaman";
            this.buttonPeminjaman.Size = new System.Drawing.Size(193, 62);
            this.buttonPeminjaman.TabIndex = 8;
            this.buttonPeminjaman.Text = "Data Peminjaman";
            this.buttonPeminjaman.UseVisualStyleBackColor = true;
            this.buttonPeminjaman.Click += new System.EventHandler(this.buttonPeminjaman_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Location = new System.Drawing.Point(459, 542);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(186, 62);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Cari Buku";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // PageDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonPeminjaman);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.LabelGreeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "PageDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Perpustakaan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGreeting;
        private System.Windows.Forms.Button buttonPeminjaman;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonSearch;
    }
}

