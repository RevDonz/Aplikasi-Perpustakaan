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
    public partial class BookPage : Form
    {
        public BookPage()
        {
            InitializeComponent();
        }

        private void BookPage_Load(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            this.Size = new System.Drawing.Size(conf.width, conf.height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dashboard = new Form1();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }
    }
}
