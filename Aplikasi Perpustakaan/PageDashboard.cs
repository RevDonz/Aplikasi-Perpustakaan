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
    public partial class PageDashboard : Form
    {
        
        public PageDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            this.Size = new Size(conf.width, conf.height);

            if (conf.bahasa == "id")
            {
                LabelGreeting.Text = conf.text.greeting.id;
                buttonBook.Text = conf.button.dataBuku.id;
                buttonPeminjaman.Text = conf.button.dataPeminjaman.id;
                buttonSearch.Text = conf.button.cariBuku.id;
            }
            else
            {
                LabelGreeting.Text = conf.text.greeting.en;
                buttonBook.Text = conf.button.dataBuku.en;
                buttonPeminjaman.Text = conf.button.dataPeminjaman.en;
                buttonSearch.Text = conf.button.cariBuku.en;
            }
        }

        private void LabelGreeting_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageBook bookPage = new PageBook();
            bookPage.Closed += (s, args) => this.Close();
            bookPage.Show();
        }

        private void buttonPeminjaman_Click(object sender, EventArgs e)
        {
            this.Hide();
            PagePeminjaman peminjamanPage = new PagePeminjaman();
            peminjamanPage.Closed += (s, args) => this.Close();
            peminjamanPage.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageSearchBook bookSearch = new PageSearchBook();
            bookSearch.Closed += (s, args) => this.Close();
            bookSearch.Show();
        }

        private void LabelChooseLang_Click(object sender, EventArgs e)
        {

        }
    }
}
