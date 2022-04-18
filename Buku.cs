using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    internal class Buku
    {
        public int idBuku { get; set; }
        public string judulBuku { get; set; }
        public int jumlahHalaman { get; set; }
        public string penulis { get; set; }
        public string penerbit { get; set; }
        public int tahunTerbit { get; set; }
        public string status { get; set; }

        public Buku(int idBuku, string judulBuku, int jumlahHalaman, string penulis, string penerbit, int tahunTerbit, string status)
        {
            this.idBuku = idBuku;
            this.judulBuku = judulBuku;
            this.jumlahHalaman = jumlahHalaman;
            this.penulis = penulis;
            this.penerbit = penerbit;
            this.tahunTerbit = tahunTerbit;
            this.status = status;
        }

        public static Buku search(Raw data, int id_buku)
        {
            foreach (Buku item in data.buku)
            {
                if (item.idBuku == id_buku)
                {
                    return item;
                }
            }
            return null;
        }

        public static Raw update(Raw data, int id_buku, string status)
        {
            foreach (Buku item in data.buku)
            {

            }
        }
    }
}
