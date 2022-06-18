using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using LibrariesAPI;

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

            dynamic result = Buku.GetDataBuku();
            dgvDataBuku.DataSource = this.ToDataTable(result);

            inputStatus.SelectedItem = "disimpan";
            
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dataBuku.json";
            Raw raw = Raw.getRecord(path);

            string id_buku = "idBuku";
            string judul = this.inputJudul.Text;
            int jumlahHalaman = int.Parse(this.inputJmlHal.Text);
            string penulis = this.inputPenulis.Text;
            string penerbit = this.inputPenerbit.Text;
            int tahun = int.Parse(this.inputTahun.Text);
            string status = this.inputStatus.Text;

            Buku buku = new Buku(id_buku, judul, jumlahHalaman, penulis, penerbit, tahun, status);

            bool found = false;
            foreach (Buku item in raw.buku)
            {
                if (item.idBuku == buku.idBuku)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                raw = buku.tambah(raw);
                MessageBox.Show("Buku berhasil ditambahkan");
            }
            else
            {
                raw = buku.update(raw);
                MessageBox.Show("Buku berhasil diupdate");
            }
            dgvDataBuku.DataSource = null;
            dgvDataBuku.DataSource = this.ToDataTable(raw.buku);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelJmlHal_Click(object sender, EventArgs e)
        {

        }

        private void dgvDataBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDataBuku.Rows[index];

            labelIdBuku.Text = selectedRow.Cells[0].Value.ToString();
            inputJudul.Text = selectedRow.Cells[1].Value.ToString();
            inputJmlHal.Text = selectedRow.Cells[2].Value.ToString();
            inputPenulis.Text = selectedRow.Cells[3].Value.ToString();
            inputPenerbit.Text = selectedRow.Cells[4].Value.ToString();
            inputTahun.Text = selectedRow.Cells[5].Value.ToString();
            inputStatus.SelectedItem = selectedRow.Cells[6].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dynamic result = Buku.DeleteDataBuku(labelIdBuku.Text);

            if (result != null)
            {
                MessageBox.Show("Hapus Data Berhasil", "Berhasil");
                dynamic buku = Buku.GetDataBuku();
                dgvDataBuku.DataSource = this.ToDataTable(buku);
                resetInput();
            } 
            else
            {
                MessageBox.Show("Hapus Data Gagal", "Gagal");
                resetInput();
            }
        }

        private void resetInput()
        {
            inputJmlHal.Text = "";
            inputJudul.Text = "";
            inputPenerbit.Text = "";
            inputPenulis.Text = "";
            inputTahun.Text = "";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetInput();
        }
    }
}
