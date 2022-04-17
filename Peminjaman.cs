using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    internal class Peminjaman
    {
        public string nama_peminjam { get; set; }
        public int id_buku { get; set; }
        public DateTime tanggal_pinjam { get; set; }
        public string status_peminjaman { get; set; }

        public Peminjaman(string nama_peminjam, int id_buku, DateTime tanggal_pinjam, string status_peminjaman)
        {
            this.nama_peminjam = nama_peminjam;
            this.id_buku = id_buku;
            this.tanggal_pinjam = tanggal_pinjam;
            this.status_peminjaman = status_peminjaman;
        }
    }
}
