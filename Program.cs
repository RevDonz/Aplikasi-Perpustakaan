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
            //Peminjaman peminjaman1 = new Peminjaman("Baru", 2, new DateTime(), "dikonfirmasi");
            //Buku buku1 = new Buku(7, "BUKUBARU", 10, "Bukan saya", "Gramedia", 2022, "disimpan");

            //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dataBuku.json";
            //System.Diagnostics.Debug.WriteLine(path);

            //Raw raw = Raw.getRecord(path);
            //raw = buku1.tambah(raw);

            //raw = Peminjaman.pinjam(raw, peminjaman1);
            //raw = Buku.tambah(raw, buku1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PageDashboard());

            //raw = Buku.update(raw, 2, "hilang");

            //list<buku> list_buku = new list<buku>();
            //list<peminjaman> list_peminjaman = new list<peminjaman>();

            //list_buku = raw.buku;
            //list_peminjaman = raw.peminjaman;


            //foreach (buku buku in list_buku)
            //{
            //    system.diagnostics.debug.writeline(buku.penulis);
            //}
            //foreach (peminjaman peminjaman in list_peminjaman)
            //{
            //    system.diagnostics.debug.writeline(peminjaman.tanggal_pinjam.tostring("dd/mm/yyyy"));
            //}
            //CariBuku book = new CariBuku();
            //dynamic q = book.BukuTersedia("Buku1");
            //Console.WriteLine(q);

            //dynamic rq = book.BukuTersedia("Buku1");
            //Console.WriteLine(rq);

        }
    }
}
