namespace Aplikasi_Perpustakaan
{
    partial class PageBook
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
            this.backButton = new System.Windows.Forms.Button();
            this.dgvDataBuku = new System.Windows.Forms.DataGridView();
            this.labelJudul = new System.Windows.Forms.Label();
            this.inputJudul = new System.Windows.Forms.TextBox();
            this.inputIdBuku = new System.Windows.Forms.TextBox();
            this.labelIdBuku = new System.Windows.Forms.Label();
            this.inputJmlHal = new System.Windows.Forms.TextBox();
            this.inputPenulis = new System.Windows.Forms.TextBox();
            this.inputPenerbit = new System.Windows.Forms.TextBox();
            this.inputTahun = new System.Windows.Forms.TextBox();
            this.labelJmlHal = new System.Windows.Forms.Label();
            this.labelPenulis = new System.Windows.Forms.Label();
            this.labelPenerbit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Kembali";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dgvDataBuku
            // 
            this.dgvDataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBuku.Location = new System.Drawing.Point(29, 411);
            this.dgvDataBuku.Name = "dgvDataBuku";
            this.dgvDataBuku.RowHeadersWidth = 51;
            this.dgvDataBuku.RowTemplate.Height = 24;
            this.dgvDataBuku.Size = new System.Drawing.Size(884, 150);
            this.dgvDataBuku.TabIndex = 1;
            this.dgvDataBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBuku_CellContentClick);
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Location = new System.Drawing.Point(485, 130);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(72, 16);
            this.labelJudul.TabIndex = 2;
            this.labelJudul.Text = "Judul Buku";
            this.labelJudul.Click += new System.EventHandler(this.labelJudul_Click);
            // 
            // inputJudul
            // 
            this.inputJudul.Location = new System.Drawing.Point(594, 127);
            this.inputJudul.Name = "inputJudul";
            this.inputJudul.Size = new System.Drawing.Size(319, 22);
            this.inputJudul.TabIndex = 3;
            // 
            // inputIdBuku
            // 
            this.inputIdBuku.Location = new System.Drawing.Point(338, 85);
            this.inputIdBuku.Name = "inputIdBuku";
            this.inputIdBuku.Size = new System.Drawing.Size(319, 22);
            this.inputIdBuku.TabIndex = 4;
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Location = new System.Drawing.Point(335, 52);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(53, 16);
            this.labelIdBuku.TabIndex = 5;
            this.labelIdBuku.Text = "ID Buku";
            // 
            // inputJmlHal
            // 
            this.inputJmlHal.Location = new System.Drawing.Point(594, 183);
            this.inputJmlHal.Name = "inputJmlHal";
            this.inputJmlHal.Size = new System.Drawing.Size(319, 22);
            this.inputJmlHal.TabIndex = 6;
            // 
            // inputPenulis
            // 
            this.inputPenulis.Location = new System.Drawing.Point(594, 236);
            this.inputPenulis.Name = "inputPenulis";
            this.inputPenulis.Size = new System.Drawing.Size(319, 22);
            this.inputPenulis.TabIndex = 7;
            // 
            // inputPenerbit
            // 
            this.inputPenerbit.Location = new System.Drawing.Point(594, 287);
            this.inputPenerbit.Name = "inputPenerbit";
            this.inputPenerbit.Size = new System.Drawing.Size(319, 22);
            this.inputPenerbit.TabIndex = 8;
            // 
            // inputTahun
            // 
            this.inputTahun.Location = new System.Drawing.Point(594, 338);
            this.inputTahun.Name = "inputTahun";
            this.inputTahun.Size = new System.Drawing.Size(319, 22);
            this.inputTahun.TabIndex = 9;
            // 
            // labelJmlHal
            // 
            this.labelJmlHal.AutoSize = true;
            this.labelJmlHal.Location = new System.Drawing.Point(466, 186);
            this.labelJmlHal.Name = "labelJmlHal";
            this.labelJmlHal.Size = new System.Drawing.Size(108, 16);
            this.labelJmlHal.TabIndex = 10;
            this.labelJmlHal.Text = "Jumlah Halaman";
            // 
            // labelPenulis
            // 
            this.labelPenulis.AutoSize = true;
            this.labelPenulis.Location = new System.Drawing.Point(449, 242);
            this.labelPenulis.Name = "labelPenulis";
            this.labelPenulis.Size = new System.Drawing.Size(51, 16);
            this.labelPenulis.TabIndex = 11;
            this.labelPenulis.Text = "Penulis";
            // 
            // labelPenerbit
            // 
            this.labelPenerbit.AutoSize = true;
            this.labelPenerbit.Location = new System.Drawing.Point(444, 300);
            this.labelPenerbit.Name = "labelPenerbit";
            this.labelPenerbit.Size = new System.Drawing.Size(57, 16);
            this.labelPenerbit.TabIndex = 12;
            this.labelPenerbit.Text = "Penerbit";
            // 
            // PageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.labelPenerbit);
            this.Controls.Add(this.labelPenulis);
            this.Controls.Add(this.labelJmlHal);
            this.Controls.Add(this.inputTahun);
            this.Controls.Add(this.inputPenerbit);
            this.Controls.Add(this.inputPenulis);
            this.Controls.Add(this.inputJmlHal);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.inputIdBuku);
            this.Controls.Add(this.inputJudul);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.dgvDataBuku);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PageBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Buku";
            this.Load += new System.EventHandler(this.BookPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dgvDataBuku;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox inputJudul;
        private System.Windows.Forms.TextBox inputIdBuku;
        private System.Windows.Forms.Label labelIdBuku;
        private System.Windows.Forms.TextBox inputJmlHal;
        private System.Windows.Forms.TextBox inputPenulis;
        private System.Windows.Forms.TextBox inputPenerbit;
        private System.Windows.Forms.TextBox inputTahun;
        private System.Windows.Forms.Label labelJmlHal;
        private System.Windows.Forms.Label labelPenulis;
        private System.Windows.Forms.Label labelPenerbit;
    }
}