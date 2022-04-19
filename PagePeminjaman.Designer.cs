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
            this.inputNama = new System.Windows.Forms.TextBox();
            this.labelPeminjam = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dgvDataBuku = new System.Windows.Forms.DataGridView();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.inputIdBuku = new System.Windows.Forms.ComboBox();
            this.labeljudulpeminjaman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MintCream;
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(22, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Kembali";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dgvDataPeminjaman
            // 
            this.dgvDataPeminjaman.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvDataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPeminjaman.Location = new System.Drawing.Point(121, 314);
            this.dgvDataPeminjaman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDataPeminjaman.Name = "dgvDataPeminjaman";
            this.dgvDataPeminjaman.RowHeadersWidth = 51;
            this.dgvDataPeminjaman.RowTemplate.Height = 24;
            this.dgvDataPeminjaman.Size = new System.Drawing.Size(456, 158);
            this.dgvDataPeminjaman.TabIndex = 2;
            this.dgvDataPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBuku_CellContentClick);
            // 
            // labelPenulis
            // 
            this.labelPenulis.AutoSize = true;
            this.labelPenulis.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenulis.Location = new System.Drawing.Point(42, 212);
            this.labelPenulis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPenulis.Name = "labelPenulis";
            this.labelPenulis.Size = new System.Drawing.Size(40, 15);
            this.labelPenulis.TabIndex = 22;
            this.labelPenulis.Text = "Status";
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBuku.Location = new System.Drawing.Point(42, 128);
            this.labelIdBuku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(50, 15);
            this.labelIdBuku.TabIndex = 16;
            this.labelIdBuku.Text = "ID Buku";
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(164, 168);
            this.inputNama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(182, 20);
            this.inputNama.TabIndex = 14;
            // 
            // labelPeminjam
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(42, 170);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(96, 15);
            this.labelJudul.TabIndex = 13;
            this.labelJudul.Text = "Nama Peminjam";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.MintCream;
            this.buttonSubmit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(44, 255);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(59, 30);
            this.buttonSubmit.TabIndex = 23;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.MintCream;
            this.buttonReset.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(287, 255);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(59, 30);
            this.buttonReset.TabIndex = 24;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dgvDataBuku
            // 
            this.dgvDataBuku.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvDataBuku.Location = new System.Drawing.Point(397, 120);
            this.dgvDataBuku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDataBuku.Name = "dgvDataBuku";
            this.dgvDataBuku.RowHeadersWidth = 51;
            this.dgvDataBuku.RowTemplate.Height = 24;
            this.dgvDataBuku.Size = new System.Drawing.Size(262, 122);
            this.dgvDataBuku.TabIndex = 25;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "dikonfirmasi",
            "dikembalikan"});
            this.comboBoxStatus.Location = new System.Drawing.Point(164, 211);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(182, 21);
            this.comboBoxStatus.TabIndex = 26;
            // 
            // inputIdBuku
            // 
            this.inputIdBuku.AccessibleName = "";
            this.inputIdBuku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputIdBuku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputIdBuku.FormattingEnabled = true;
            this.inputIdBuku.Location = new System.Drawing.Point(164, 128);
            this.inputIdBuku.Name = "inputIdBuku";
            this.inputIdBuku.Size = new System.Drawing.Size(182, 21);
            this.inputIdBuku.TabIndex = 27;
            // 
            // labeljudulpeminjaman
            // 
            this.labeljudulpeminjaman.AutoSize = true;
            this.labeljudulpeminjaman.Font = new System.Drawing.Font("Gaegu", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljudulpeminjaman.Location = new System.Drawing.Point(205, 45);
            this.labeljudulpeminjaman.Name = "labeljudulpeminjaman";
            this.labeljudulpeminjaman.Size = new System.Drawing.Size(329, 28);
            this.labeljudulpeminjaman.TabIndex = 28;
            this.labeljudulpeminjaman.Text = "Data Peminjaman MyLibrary";
            // 
            // PagePeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.labeljudulpeminjaman);
            this.Controls.Add(this.inputIdBuku);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dgvDataBuku);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelPenulis);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.labelPeminjam);
            this.Controls.Add(this.dgvDataPeminjaman);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.Label labelPeminjam;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dgvDataBuku;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox inputIdBuku;
        private System.Windows.Forms.Label labeljudulpeminjaman;
    }
}