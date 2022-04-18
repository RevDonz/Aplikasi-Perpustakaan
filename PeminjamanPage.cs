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
    public partial class PeminjamanPage : Form
    {
        public PeminjamanPage()
        {
            InitializeComponent();
        }

        private void PeminjamanPage_Load(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            this.Size = new Size(conf.width, conf.height);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dashboard = new Form1();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }
    }
}
