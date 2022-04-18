﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            //string file = "dataBuku.json";

            //List<Buku> list_buku = new List<Buku>();
            //List<Peminjaman> list_peminjaman = new List<Peminjaman>();

            //list_buku = Serializer.deserialize<Buku>(path + "\\" + file);
            //list_peminjaman = Serializer.deserialize<Peminjaman>(path + "\\" + file);
            //System.Diagnostics.Debug.WriteLine(path + "\\" + file);

            //foreach (Buku buku in list_buku)
            //{
            //    System.Diagnostics.Debug.WriteLine(buku.penulis);
            //}
            //foreach (Peminjaman peminjaman in list_peminjaman)
            //{
            //    System.Diagnostics.Debug.WriteLine(peminjaman.tanggal_pinjam.ToString("dd/MM/yyyy"));
            //}
            AutomataStatusBuku test = new AutomataStatusBuku();
            Console.WriteLine(test.StatusBukuSaatIni);
            test.TriggerAksi(AutomataStatusBuku.Aksi.hilang);
            Console.WriteLine(test.StatusBukuSaatIni);


        }
    }
}
