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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            this.Size = new Size(conf.width, conf.height);
        }

        private void LabelGreeting_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_idn_Click(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            LabelGreeting.Text = conf.text.greeting.id;
            LabelChooseLang.Text = conf.text.pilihBahasa.id;
            buttonBook.Text = conf.button.dataBuku.id;
        }

        private void btn_en_Click(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            LabelGreeting.Text = conf.text.greeting.en;
            LabelChooseLang.Text = conf.text.pilihBahasa.en;
            buttonBook.Text = conf.button.dataBuku.en;
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookPage bookPage = new BookPage();
            bookPage.Closed += (s, args) => this.Close();
            bookPage.Show();
        }

    }
}
