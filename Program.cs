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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Peminjaman peminjaman1 = new Peminjaman("Baru", 2, new DateTime(2022, 4, 13), "dikonfirmasi");

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dataBuku.json";

            Raw raw = Raw.getRecord(path);

            raw = Peminjaman.pinjam(raw, peminjaman1, path);

            //List<Buku> list_buku = new List<Buku>();
            //List<Peminjaman> list_peminjaman = new List<Peminjaman>();

            //list_buku = raw.buku;
            //list_peminjaman = raw.peminjaman;


            //foreach (Buku buku in list_buku)
            //{
            //    System.Diagnostics.Debug.WriteLine(buku.penulis);
            //}
            //foreach (Peminjaman peminjaman in list_peminjaman)
            //{
            //    System.Diagnostics.Debug.WriteLine(peminjaman.tanggal_pinjam.ToString("dd/MM/yyyy"));
            //}
        }
    }
}
