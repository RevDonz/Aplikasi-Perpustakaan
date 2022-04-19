using System;
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
            Application.Run(new FormLogin());

            //Peminjaman peminjaman1 = new Peminjaman("Baru", 2, new DateTime(2022, 4, 13), "dikonfirmasi");

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dataBuku.json";

            Raw raw = Raw.getRecord(path);

            //raw = Peminjaman.pinjam(raw, peminjaman1, path);
            raw = Buku.update(raw, 2, "hilang");

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
            CariBuku book = new CariBuku();
            //dynamic q = book.BukuTersedia("Buku1");
            //Console.WriteLine(q);

            dynamic rq = book.BukuTersedia("Buku1");
            Console.WriteLine(rq);

        }
    }
}
