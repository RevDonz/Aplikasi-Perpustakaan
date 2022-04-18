namespace Aplikasi_Perpustakaan
{
    partial class BookPage
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
            this.dgvDataBuku.Location = new System.Drawing.Point(51, 293);
            this.dgvDataBuku.Name = "dgvDataBuku";
            this.dgvDataBuku.RowHeadersWidth = 51;
            this.dgvDataBuku.RowTemplate.Height = 24;
            this.dgvDataBuku.Size = new System.Drawing.Size(777, 150);
            this.dgvDataBuku.TabIndex = 1;
            this.dgvDataBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBuku_CellContentClick);
            // 
            // BookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.dgvDataBuku);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BookPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Buku";
            this.Load += new System.EventHandler(this.BookPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dgvDataBuku;
    }
}