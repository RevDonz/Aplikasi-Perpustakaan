using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class PageBook : Form
    {
        
        public PageBook()
        {
            InitializeComponent();
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void BookPage_Load(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            this.Size = new System.Drawing.Size(conf.width, conf.height);

            if (conf.bahasa == "id")
            {
                backButton.Text = conf.button.kembali.id;
            }
            else
            {
                backButton.Text = conf.button.kembali.en;
            }

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\databuku.json";
            List<Buku> list_buku = new List<Buku>();
            Raw raw = Raw.getRecord(path);

            list_buku = raw.buku;
            dgvDataBuku.DataSource = this.ToDataTable(list_buku);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageDashboard dashboard = new PageDashboard();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void dgvDataBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        

        private void labelJudul_Click(object sender, EventArgs e)

        {

        }

        private void labelPenerbit_Click(object sender, EventArgs e)
        {

        }
    }
}
