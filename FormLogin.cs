using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class FormLogin : Form
    {
        int attempt = 0;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string[] username = { "yuna01","doni02", "zahrandi03","naufal04", "rama05" };
            string[] password = { "aa01", "bb02", "cc03", "dd04", "ee05" };

            if(username.Contains(inputUsername.Text) && password.Contains(inputPassword.Text) && Array.IndexOf(username, inputUsername.Text) ==
                Array.IndexOf(password, inputPassword.Text))
            {
                MessageBox.Show("Sukses Login! Selamat Datang di MyLibrary");
            }
            else
            {
                inputUsername.Clear();
                inputPassword.Clear();
                MessageBox.Show("Username atau Password Salah!");
                attempt += 1;

                if (attempt == 3)
                {
                    Application.Exit();
                }

            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }


        private void labelJudul_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void inputPassword_TextChanged(object sender, EventArgs e)
        {
           

            inputPassword.ForeColor = Color.Black;

            inputPassword.PasswordChar = '●';

        }

        private void inputUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
