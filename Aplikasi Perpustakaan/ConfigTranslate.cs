using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    class ConfigTranslate
    {
        public bahasaPagePeminjaman bahasaPagePeminjaman { get; set; }
        public ConfigTranslate() { }
        public ConfigTranslate(bahasaPagePeminjaman bahasaPagePeminjaman)
        {
            this.bahasaPagePeminjaman = bahasaPagePeminjaman;
        }
    }

    class bahasaPagePeminjaman
    {
        public labelIdBuku labelIdBuku { get; set; }
        public labelNamaPeminjam labelNamaPeminjam { get; set; }

        public bahasaPagePeminjaman() {}
        public bahasaPagePeminjaman(labelIdBuku labelIdBuku, 
            labelNamaPeminjam labelNamaPeminjam)
        {
            this.labelIdBuku = labelIdBuku;
            this.labelNamaPeminjam = labelNamaPeminjam;
        }

    }

    class labelIdBuku
    {
        public string id { get; set; }
        public string en { get; set; }

        public labelIdBuku() { }
        public labelIdBuku(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class labelNamaPeminjam
    {
        public string id { get; set; }
        public string en { get; set; }

        public labelNamaPeminjam() { }
        public labelNamaPeminjam(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }








}
