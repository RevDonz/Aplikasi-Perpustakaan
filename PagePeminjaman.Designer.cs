namespace Aplikasi_Perpustakaan
{
    partial class PagePeminjaman
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
            this.dgvDataPeminjaman = new System.Windows.Forms.DataGridView();
            this.labelPenulis = new System.Windows.Forms.Label();
            this.labelIdBuku = new System.Windows.Forms.Label();
            this.inputIdBuku = new System.Windows.Forms.TextBox();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dgvDataBuku = new System.Windows.Forms.DataGridView();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Kembali";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dgvDataPeminjaman
            // 
            this.dgvDataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPeminjaman.Location = new System.Drawing.Point(67, 420);
            this.dgvDataPeminjaman.Name = "dgvDataPeminjaman";
            this.dgvDataPeminjaman.RowHeadersWidth = 51;
            this.dgvDataPeminjaman.RowTemplate.Height = 24;
            this.dgvDataPeminjaman.Size = new System.Drawing.Size(309, 150);
            this.dgvDataPeminjaman.TabIndex = 2;
            this.dgvDataPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBuku_CellContentClick);
            // 
            // labelPenulis
            // 
            this.labelPenulis.AutoSize = true;
            this.labelPenulis.Location = new System.Drawing.Point(224, 179);
            this.labelPenulis.Name = "labelPenulis";
            this.labelPenulis.Size = new System.Drawing.Size(44, 16);
            this.labelPenulis.TabIndex = 22;
            this.labelPenulis.Text = "Status";
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Location = new System.Drawing.Point(224, 74);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(53, 16);
            this.labelIdBuku.TabIndex = 16;
            this.labelIdBuku.Text = "ID Buku";
            // 
            // inputIdBuku
            // 
            this.inputIdBuku.Location = new System.Drawing.Point(386, 71);
            this.inputIdBuku.Name = "inputIdBuku";
            this.inputIdBuku.Size = new System.Drawing.Size(319, 22);
            this.inputIdBuku.TabIndex = 15;
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(386, 123);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(319, 22);
            this.inputNama.TabIndex = 14;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Location = new System.Drawing.Point(224, 126);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(107, 16);
            this.labelJudul.TabIndex = 13;
            this.labelJudul.Text = "Nama Peminjam";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(227, 231);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 23;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(630, 231);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 24;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // dgvDataBuku
            // 
            this.dgvDataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBuku.Location = new System.Drawing.Point(511, 420);
            this.dgvDataBuku.Name = "dgvDataBuku";
            this.dgvDataBuku.RowHeadersWidth = 51;
            this.dgvDataBuku.RowTemplate.Height = 24;
            this.dgvDataBuku.Size = new System.Drawing.Size(349, 150);
            this.dgvDataBuku.TabIndex = 25;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "dikonfirmasi",
            "dikembalikan"});
            this.comboBoxStatus.Location = new System.Drawing.Point(386, 176);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(319, 24);
            this.comboBoxStatus.TabIndex = 26;
            // 
            // PagePeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dgvDataBuku);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelPenulis);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.inputIdBuku);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.dgvDataPeminjaman);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PagePeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Peminjaman";
            this.Load += new System.EventHandler(this.PeminjamanPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dgvDataPeminjaman;
        private System.Windows.Forms.Label labelPenulis;
        private System.Windows.Forms.Label labelIdBuku;
        private System.Windows.Forms.TextBox inputIdBuku;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dgvDataBuku;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}