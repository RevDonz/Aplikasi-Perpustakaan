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

            //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            //string file = "dataBuku2.json";

            //List<Buku> list_buku = new List<Buku>();

            //list_buku = SerializerBuku.deserialize(path + "\\" + file);
            //System.Diagnostics.Debug.WriteLine(path + "\\" + file);

            //foreach (Buku buku in list_buku)
            //{
            //    System.Diagnostics.Debug.WriteLine(buku.penulis);
            //}
        }
    }
}
