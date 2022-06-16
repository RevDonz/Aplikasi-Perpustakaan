using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    internal class Buku
    {
        public string idBuku { get; set; }
        public string judulBuku { get; set; }
        public int jumlahHalaman { get; set; }
        public string penulis { get; set; }
        public string penerbit { get; set; }
        public int tahunTerbit { get; set; }
        public string status { get; set; }

        public Buku(string idBuku, string judulBuku, int jumlahHalaman, string penulis, string penerbit, int tahunTerbit, string status)
        {
            this.idBuku = idBuku;
            this.judulBuku = judulBuku;
            this.jumlahHalaman = jumlahHalaman;
            this.penulis = penulis;
            this.penerbit = penerbit;
            this.tahunTerbit = tahunTerbit;
            this.status = status;
        }

        public static Buku search(Raw data, string id_buku)
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

        public Raw update(Raw data)
        {
            bool changed = false;

            foreach (Buku item in data.buku)
            {
                if (item.idBuku == this.idBuku)
                {
                    changed = true;
                    item.status = status;
                    item.judulBuku = this.judulBuku;
                    item.jumlahHalaman = this.jumlahHalaman;
                    item.penulis = this.penulis;
                    item.penerbit = this.penerbit;
                    item.tahunTerbit = this.tahunTerbit;
                    break;
                }
            }

            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(data.path, json);

            if (changed)
            {
                return data;
            } else
            {
                return null;
            }
        }

        public Raw tambah(Raw raw)
        {
            raw.buku.Add(this);
            string json = JsonConvert.SerializeObject(raw, Formatting.Indented);
            File.WriteAllText(raw.path, json);
            return raw;
        }
    }
}
