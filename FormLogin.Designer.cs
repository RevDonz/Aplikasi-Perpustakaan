namespace Aplikasi_Perpustakaan
{
    partial class FormLogin
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
            this.labelJudul = new System.Windows.Forms.Label();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Gaegu", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(78, 30);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(208, 29);
            this.labelJudul.TabIndex = 5;
            this.labelJudul.Text = "Login MyLibrary";
            this.labelJudul.Click += new System.EventHandler(this.labelJudul_Click);
            // 
            // inputUsername
            // 
            this.inputUsername.Location = new System.Drawing.Point(101, 115);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(152, 20);
            this.inputUsername.TabIndex = 8;
            this.inputUsername.TextChanged += new System.EventHandler(this.inputUsername_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(98, 154);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(101, 173);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(152, 20);
            this.inputPassword.TabIndex = 9;
            this.inputPassword.TextChanged += new System.EventHandler(this.inputPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Teal;
            this.buttonLogin.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(178, 208);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 29);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.inputUsername);
            this.panel1.Controls.Add(this.labelJudul);
            this.panel1.Location = new System.Drawing.Point(-44, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 266);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(271, 261);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Perpustakaan";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;
    }
}

