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

namespace Aplikasi_Perpustakaan
{
    public partial class PagePeminjaman : Form
    {
        public PagePeminjaman()
        {
            InitializeComponent();
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\databuku.json";
            List<Peminjaman> list_peminjaman = new List<Peminjaman>();
            Raw raw = Raw.getRecord(path);
            list_peminjaman = raw.peminjaman;
            dgvDataPeminjaman.DataSource = this.ToDataTable(list_peminjaman);

            List<Buku> list_buku = new List<Buku>();
            list_buku = raw.buku;
            dgvDataBuku.DataSource = this.ToDataTable(list_buku);
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
                raw = Peminjaman.pinjam(raw, newPeminjaman);
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Id Buku harus berupa angka");
            }

        }
    }
}
