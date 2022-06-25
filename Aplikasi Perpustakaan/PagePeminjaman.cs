﻿using System;
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

            if (LanguageCounter.identifier == "en")
            {
                backButton.Text = conf.button.kembali.en;
                ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
                dynamic conf_bahasa = config_bahasa.ReadConfigFile();
                labelPeminjam.Text = conf_bahasa.BahasaPagePeminjaman.LabelNamaPeminjam.En;
                labelIdBuku.Text = conf_bahasa.BahasaPagePeminjaman.LabelIdBuku.En;
                labeljudulpeminjaman.Text = "MyLibrary Book Loan Data";

            }
            else if (LanguageCounter.identifier == "id")
            {
                backButton.Text = conf.button.kembali.id;
                ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
                dynamic conf_bahasa = config_bahasa.ReadConfigFile();
                labelPeminjam.Text = conf_bahasa.BahasaPagePeminjaman.LabelNamaPeminjam.Id;
                labelIdBuku.Text = conf_bahasa.BahasaPagePeminjaman.LabelIdBuku.Id;
                labeljudulpeminjaman.Text = "Data Peminjaman MyLibrary";
            }

            List<ResponsePeminjaman> list_peminjaman = Peminjaman.GetDataPeminjaman();
            List<Buku> list_buku = Buku.GetDataBuku();


            dgvDataPeminjaman.DataSource = this.ToDataTable(list_peminjaman);
            dgvDataBuku.DataSource = this.ToDataTable(list_buku);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageDashboard dashboard = new PageDashboard();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            dynamic result = false;

            try
            {
                Peminjaman newPeminjaman = new Peminjaman(null, inputNama.Text, labelIdBuku.Text, DateTime.Now, null);
                
                List<ResponsePeminjaman> list_peminjaman = Peminjaman.GetDataPeminjaman();

                Console.WriteLine(newPeminjaman);
                //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dataBuku.json";
                //Raw raw = Raw.getRecord(path);
                result = Peminjaman.TambahPeminjaman(newPeminjaman);

                if (result)
                {
                    MessageBox.Show("Berhasil");
                }

                bool found = false;

                //foreach (Peminjaman item in list_peminjaman)
                //{
                //    if (item.namaPeminjam == newPeminjaman.namaPeminjam && item.idBuku == newPeminjaman.idBuku)
                //    {
                //        found = true;
                //        if (newPeminjaman.statusPeminjaman == "dikonfirmasi")
                //        {
                //            MessageBox.Show("Data peminjaman ditemukan. Apakah status yang dimaksud 'dikembalikan'?");
                //        }
                //        else
                //        {
                //            item.statusPeminjaman = newPeminjaman.statusPeminjaman;
                //            //string json = JsonConvert.SerializeObject(raw, Formatting.Indented);
                //            //File.WriteAllText(raw.path, json);
                //            //MessageBox.Show("Buku berhasil dikembalikan");
                //        }
                //    }
                //}
                //if (!found)
                //{
                //    raw = Peminjaman.pinjam(raw, newPeminjaman);
                //}

                dgvDataPeminjaman.DataSource = this.ToDataTable(list_peminjaman);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            inputNama.Text = "";
        }

        private void inputIdBuku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDataBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDataBuku.Rows[index];

            labelIdBuku.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelPeminjam_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            dynamic result = Peminjaman.DeleteDataPeminjaman(labelIdPeminjaman.Text);

            if (result != null)
            {
                MessageBox.Show("Hapus Data Berhasil", "Berhasil");
                dynamic peminjaman = Peminjaman.GetDataPeminjaman();
                dgvDataBuku.DataSource = this.ToDataTable(peminjaman);
            }
            else
            {
                MessageBox.Show("Hapus Data Gagal", "Gagal");
            }
        }

        private void dgvDataPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDataPeminjaman.Rows[index];

            labelIdBuku.Text = selectedRow.Cells[0].Value.ToString();
        }
    }
}
