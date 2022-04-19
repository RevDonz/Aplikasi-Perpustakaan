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
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dataBuku.json";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PageDashboard());

            //Raw raw = Raw.getRecord(path);

            //Buku buku1 = new Buku(7, "BUKU BARU", 10, "Bukan Saya", "Gramedia", 2022, "disimpan");
            //raw = buku1.tambah(raw);
            //foreach (Buku item in raw.buku)
            //{
            //    System.Diagnostics.Debug.WriteLine(item.judulBuku);
            //}
            //buku1.judulBuku = "Judulnya diganti";
            //raw = buku1.update(raw);
            //foreach (Buku item in raw.buku)
            //{
            //    System.Diagnostics.Debug.WriteLine(item.judulBuku);
            //}
        }
    }
}
