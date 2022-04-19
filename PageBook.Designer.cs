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
            this.juduldatabuku = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.inputJudul = new System.Windows.Forms.TextBox();
            this.inputIdBuku = new System.Windows.Forms.TextBox();
            this.labelIdBuku = new System.Windows.Forms.Label();
            this.inputJmlHal = new System.Windows.Forms.TextBox();
            this.inputPenulis = new System.Windows.Forms.TextBox();
            this.labelJmlHal = new System.Windows.Forms.Label();
            this.labelPenulis = new System.Windows.Forms.Label();
            this.inputPenerbit = new System.Windows.Forms.TextBox();
            this.labelPenerbit = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MintCream;
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(25, 20);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 30);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Kembali";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dgvDataBuku
            // 
            this.dgvDataBuku.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvDataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBuku.Location = new System.Drawing.Point(25, 327);
            this.dgvDataBuku.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataBuku.Name = "dgvDataBuku";
            this.dgvDataBuku.RowHeadersWidth = 51;
            this.dgvDataBuku.RowTemplate.Height = 24;
            this.dgvDataBuku.Size = new System.Drawing.Size(648, 146);
            this.dgvDataBuku.TabIndex = 1;
            this.dgvDataBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBuku_CellContentClick);
            // 
            // juduldatabuku
            // 
            this.juduldatabuku.AutoSize = true;
            this.juduldatabuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juduldatabuku.Location = new System.Drawing.Point(234, 18);
            this.juduldatabuku.Name = "juduldatabuku";
            this.juduldatabuku.Size = new System.Drawing.Size(306, 33);
            this.juduldatabuku.TabIndex = 2;
            this.juduldatabuku.Text = "Data Buku MyLibrary";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelJudul.Location = new System.Drawing.Point(129, 127);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(66, 15);
            this.labelJudul.TabIndex = 2;
            this.labelJudul.Text = "Judul Buku";
            // 
            // inputJudul
            // 
            this.inputJudul.Location = new System.Drawing.Point(239, 124);
            this.inputJudul.Name = "inputJudul";
            this.inputJudul.Size = new System.Drawing.Size(319, 20);
            this.inputJudul.TabIndex = 3;
            // 
            // inputIdBuku
            // 
            this.inputIdBuku.Location = new System.Drawing.Point(239, 86);
            this.inputIdBuku.Name = "inputIdBuku";
            this.inputIdBuku.Size = new System.Drawing.Size(319, 20);
            this.inputIdBuku.TabIndex = 4;
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBuku.Location = new System.Drawing.Point(129, 86);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(50, 15);
            this.labelIdBuku.TabIndex = 5;
            this.labelIdBuku.Text = "ID Buku";
            // 
            // inputJmlHal
            // 
            this.inputJmlHal.Location = new System.Drawing.Point(239, 161);
            this.inputJmlHal.Name = "inputJmlHal";
            this.inputJmlHal.Size = new System.Drawing.Size(319, 20);
            this.inputJmlHal.TabIndex = 6;
            // 
            // inputPenulis
            // 
            this.inputPenulis.Location = new System.Drawing.Point(239, 197);
            this.inputPenulis.Name = "inputPenulis";
            this.inputPenulis.Size = new System.Drawing.Size(319, 20);
            this.inputPenulis.TabIndex = 7;
            // 
            // labelJmlHal
            // 
            this.labelJmlHal.AutoSize = true;
            this.labelJmlHal.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelJmlHal.Location = new System.Drawing.Point(129, 164);
            this.labelJmlHal.Name = "labelJmlHal";
            this.labelJmlHal.Size = new System.Drawing.Size(97, 15);
            this.labelJmlHal.TabIndex = 10;
            this.labelJmlHal.Text = "Jumlah Halaman";
            // 
            // labelPenulis
            // 
            this.labelPenulis.AutoSize = true;
            this.labelPenulis.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelPenulis.Location = new System.Drawing.Point(129, 200);
            this.labelPenulis.Name = "labelPenulis";
            this.labelPenulis.Size = new System.Drawing.Size(45, 15);
            this.labelPenulis.TabIndex = 11;
            this.labelPenulis.Text = "Penulis";
            // 
            // inputPenerbit
            // 
            this.inputPenerbit.Location = new System.Drawing.Point(239, 238);
            this.inputPenerbit.Name = "inputPenerbit";
            this.inputPenerbit.Size = new System.Drawing.Size(319, 20);
            this.inputPenerbit.TabIndex = 8;
            // 
            // labelPenerbit
            // 
            this.labelPenerbit.AutoSize = true;
            this.labelPenerbit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenerbit.Location = new System.Drawing.Point(129, 243);
            this.labelPenerbit.Name = "labelPenerbit";
            this.labelPenerbit.Size = new System.Drawing.Size(51, 15);
            this.labelPenerbit.TabIndex = 12;
            this.labelPenerbit.Text = "Penerbit";
            this.labelPenerbit.Click += new System.EventHandler(this.labelPenerbit_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.MintCream;
            this.buttonSubmit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(132, 272);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(59, 30);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.MintCream;
            this.buttonReset.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonReset.Location = new System.Drawing.Point(499, 271);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(59, 30);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // PageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.juduldatabuku);
            this.Controls.Add(this.labelPenerbit);
            this.Controls.Add(this.labelPenulis);
            this.Controls.Add(this.labelJmlHal);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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

        private System.Windows.Forms.Label juduldatabuku;

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox inputJudul;
        private System.Windows.Forms.TextBox inputIdBuku;
        private System.Windows.Forms.Label labelIdBuku;
        private System.Windows.Forms.TextBox inputJmlHal;
        private System.Windows.Forms.TextBox inputPenulis;
        private System.Windows.Forms.Label labelJmlHal;
        private System.Windows.Forms.Label labelPenulis;
        private System.Windows.Forms.TextBox inputPenerbit;
        private System.Windows.Forms.Label labelPenerbit;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReset;
    }
}