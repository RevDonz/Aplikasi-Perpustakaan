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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            CariBuku book = new CariBuku();
            dynamic availableBook = book.BukuTersedia(Text);
            book.TampilDataBuku(availableBook, Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageDashboard dashboard = new PageDashboard();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }

<<<<<<< HEAD
      
=======
        private void SearchBook_Load(object sender, EventArgs e)
        {

        }
>>>>>>> 26fd3be148d92129fda3c2782ff7462c2f711eab
    }
}
