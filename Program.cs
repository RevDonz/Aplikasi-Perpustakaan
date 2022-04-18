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
            Application.Run(new Form1());

            //string path = directory.getparent(directory.getcurrentdirectory()).parent.fullname;
            //string file = "databuku.json";

            //list<buku> list_buku = new list<buku>();
            //list<peminjaman> list_peminjaman = new list<peminjaman>();

            //list_buku = serializer.deserialize<buku>(path + "\\" + file);
            //list_peminjaman = serializer.deserialize<peminjaman>(path + "\\" + file);
            //system.diagnostics.debug.writeline(path + "\\" + file);

            //foreach (buku buku in list_buku)
            //{
            //    system.diagnostics.debug.writeline(buku.penulis);
            //}
            //foreach (peminjaman peminjaman in list_peminjaman)
            //{
            //    system.diagnostics.debug.writeline(peminjaman.tanggal_pinjam.tostring("dd/mm/yyyy"));
            //}
        }
    }
}
