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
            this.backButton.Location = new System.Drawing.Point(29, 14);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 37);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Kembali";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dgvDataPeminjaman
            // 
            this.dgvDataPeminjaman.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvDataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPeminjaman.Location = new System.Drawing.Point(161, 386);
            this.dgvDataPeminjaman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDataPeminjaman.Name = "dgvDataPeminjaman";
            this.dgvDataPeminjaman.RowHeadersWidth = 51;
            this.dgvDataPeminjaman.RowTemplate.Height = 24;
            this.dgvDataPeminjaman.Size = new System.Drawing.Size(617, 194);
            this.dgvDataPeminjaman.TabIndex = 2;
            this.dgvDataPeminjaman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBuku_CellContentClick);
            // 
            // labelPenulis
            // 
            this.labelPenulis.AutoSize = true;
            this.labelPenulis.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenulis.Location = new System.Drawing.Point(56, 261);
            this.labelPenulis.Name = "labelPenulis";
            this.labelPenulis.Size = new System.Drawing.Size(50, 20);
            this.labelPenulis.TabIndex = 22;
            this.labelPenulis.Text = "Status";
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBuku.Location = new System.Drawing.Point(56, 158);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(63, 20);
            this.labelIdBuku.TabIndex = 16;
            this.labelIdBuku.Text = "ID Buku";
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(219, 207);
            this.inputNama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(241, 22);
            this.inputNama.TabIndex = 14;
            this.inputNama.TextChanged += new System.EventHandler(this.inputNama_TextChanged);
            // 
            // labelPeminjam
            // 
            this.labelPeminjam.AutoSize = true;
            this.labelPeminjam.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeminjam.Location = new System.Drawing.Point(56, 209);
            this.labelPeminjam.Name = "labelPeminjam";
            this.labelPeminjam.Size = new System.Drawing.Size(122, 20);
            this.labelPeminjam.TabIndex = 13;
            this.labelPeminjam.Text = "Nama Peminjam";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.MintCream;
            this.buttonSubmit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(59, 314);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(79, 37);
            this.buttonSubmit.TabIndex = 23;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.MintCream;
            this.buttonReset.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(383, 314);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(79, 37);
            this.buttonReset.TabIndex = 24;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dgvDataBuku
            // 
            this.dgvDataBuku.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvDataBuku.ColumnHeadersHeight = 29;
            this.dgvDataBuku.Location = new System.Drawing.Point(529, 148);
            this.dgvDataBuku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDataBuku.Name = "dgvDataBuku";
            this.dgvDataBuku.RowHeadersWidth = 51;
            this.dgvDataBuku.RowTemplate.Height = 24;
            this.dgvDataBuku.Size = new System.Drawing.Size(349, 150);
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
            this.comboBoxStatus.Location = new System.Drawing.Point(219, 260);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(241, 24);
            this.comboBoxStatus.TabIndex = 26;
            // 
            // inputIdBuku
            // 
            this.inputIdBuku.AccessibleName = "";
            this.inputIdBuku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputIdBuku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputIdBuku.FormattingEnabled = true;
            this.inputIdBuku.Location = new System.Drawing.Point(219, 158);
            this.inputIdBuku.Margin = new System.Windows.Forms.Padding(4);
            this.inputIdBuku.Name = "inputIdBuku";
            this.inputIdBuku.Size = new System.Drawing.Size(241, 24);
            this.inputIdBuku.TabIndex = 27;
            this.inputIdBuku.SelectedIndexChanged += new System.EventHandler(this.inputIdBuku_SelectedIndexChanged);
            // 
            // labeljudulpeminjaman
            // 
            this.labeljudulpeminjaman.AutoSize = true;
            this.labeljudulpeminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljudulpeminjaman.Location = new System.Drawing.Point(273, 55);
            this.labeljudulpeminjaman.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeljudulpeminjaman.Name = "labeljudulpeminjaman";
            this.labeljudulpeminjaman.Size = new System.Drawing.Size(471, 39);
            this.labeljudulpeminjaman.TabIndex = 28;
            this.labeljudulpeminjaman.Text = "Data Peminjaman MyLibrary";
            // 
            // PagePeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(939, 617);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PagePeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tes";
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