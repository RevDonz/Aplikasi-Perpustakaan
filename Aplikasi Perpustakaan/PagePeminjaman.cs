using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Aplikasi_Perpustakaan
{
    public partial class PagePeminjaman : Form
    {
        public PagePeminjaman()
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

        private void PeminjamanPage_Load(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            this.Size = new Size(conf.width, conf.height);
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\databuku.json";

            Raw raw = Raw.getRecord(path);
            foreach (Buku item in raw.buku)
            {
                this.inputIdBuku.Items.Add(item.idBuku);
            }

            List<Peminjaman> list_peminjaman = new List<Peminjaman>();
            List<Buku> list_buku = new List<Buku>();

            list_peminjaman = raw.peminjaman;
            dgvDataPeminjaman.DataSource = this.ToDataTable(list_peminjaman);
            
            list_buku = raw.buku;
            dgvDataBuku.DataSource = this.ToDataTable(list_buku);

            comboBoxStatus.SelectedItem = "dikonfirmasi";
            inputIdBuku.SelectedItem = 1;

            if (conf.bahasa == "id")
            {
                backButton.Text = conf.button.kembali.id;
                labelIdBuku.Text = conf.text.formDataBuku.idBuku.id;
                labelPeminjam.Text = conf.text.formDataBuku.namaPeminjam.id;
            }
            else
            {
                backButton.Text = conf.button.kembali.en;
                labelIdBuku.Text = conf.text.formDataBuku.idBuku.en;
                labelPeminjam.Text = conf.text.formDataBuku.namaPeminjam.en;
            }
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Peminjaman newPeminjaman = new Peminjaman(inputNama.Text, int.Parse(inputIdBuku.Text), DateTime.Now, comboBoxStatus.Text);
                string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dataBuku.json";
                Raw raw = Raw.getRecord(path);

                bool found = false;
                foreach (Peminjaman item in raw.peminjaman)
                {
                    if (item.nama_peminjam == newPeminjaman.nama_peminjam && item.id_buku == newPeminjaman.id_buku)
                    {
                        found = true;
                        if (newPeminjaman.status_peminjaman == "dikonfirmasi")
                        {
                            MessageBox.Show("Data peminjaman ditemukan. Apakah status yang dimaksud 'dikembalikan'?");
                        }
                        else
                        {
                            item.status_peminjaman = newPeminjaman.status_peminjaman;
                            string json = JsonConvert.SerializeObject(raw, Formatting.Indented);
                            File.WriteAllText(raw.path, json);
                            MessageBox.Show("Buku berhasil dikembalikan");
                        }
                    }
                }
                if (!found)
                {
                    raw = Peminjaman.pinjam(raw, newPeminjaman);
                }
                dgvDataPeminjaman.DataSource = null;
                dgvDataPeminjaman.DataSource = this.ToDataTable(raw.peminjaman);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Id Buku harus berupa angka");
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedItem = "dikonfirmasi";
            inputIdBuku.SelectedItem = 1;
            inputNama.Text = "";
        }

        private void inputIdBuku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
            dynamic conf_bahasa = config_bahasa.ReadConfigFile();
            labelIdBuku.Text = conf_bahasa.bahasaPagePeminjaman.labelIdBuku.en;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
