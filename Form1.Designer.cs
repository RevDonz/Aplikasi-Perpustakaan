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
            this.addBook = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelGreeting
            // 
            this.LabelGreeting.AutoSize = true;
            this.LabelGreeting.Location = new System.Drawing.Point(386, 34);
            this.LabelGreeting.Name = "LabelGreeting";
            this.LabelGreeting.Size = new System.Drawing.Size(104, 16);
            this.LabelGreeting.TabIndex = 0;
            this.LabelGreeting.Text = "Selamat Datang";
            this.LabelGreeting.Click += new System.EventHandler(this.LabelGreeting_Click);
            // 
            // LabelChooseLang
            // 
            this.LabelChooseLang.AutoSize = true;
            this.LabelChooseLang.Location = new System.Drawing.Point(3, 0);
            this.LabelChooseLang.Name = "LabelChooseLang";
            this.LabelChooseLang.Size = new System.Drawing.Size(82, 16);
            this.LabelChooseLang.TabIndex = 4;
            this.LabelChooseLang.Text = "Pilih Bahasa";
            // 
            // btn_idn
            // 
            this.btn_idn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_idn.Location = new System.Drawing.Point(3, 35);
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
            this.btn_en.Location = new System.Drawing.Point(3, 68);
            this.btn_en.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_en.Name = "btn_en";
            this.btn_en.Size = new System.Drawing.Size(108, 30);
            this.btn_en.TabIndex = 6;
            this.btn_en.Text = "Inggris";
            this.btn_en.UseVisualStyleBackColor = true;
            this.btn_en.Click += new System.EventHandler(this.btn_en_Click);
            // 
            // addBook
            // 
            this.addBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBook.Location = new System.Drawing.Point(112, 284);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(145, 50);
            this.addBook.TabIndex = 7;
            this.addBook.Text = "Tambah Buku";
            this.addBook.UseVisualStyleBackColor = true;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LabelChooseLang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_en, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_idn, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(796, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(131, 100);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.LabelGreeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Aplikasi Perpustakaan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGreeting;
        private System.Windows.Forms.Label LabelChooseLang;
        private System.Windows.Forms.Button btn_idn;
        private System.Windows.Forms.Button btn_en;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

