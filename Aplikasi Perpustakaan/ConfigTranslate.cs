using System;


namespace Aplikasi_Perpustakaan
{
    class ConfigTranslate
    {
        public bahasaPagePeminjaman bahasaPagePeminjaman { get; set; }
        public bahasaPageBook bahasaPageBook { get; set; }
        public ConfigTranslate() { }
        public ConfigTranslate(bahasaPagePeminjaman bahasaPagePeminjaman, bahasaPageBook bahasaPageBook)
        {
            this.bahasaPagePeminjaman = bahasaPagePeminjaman;
            this.bahasaPageBook = bahasaPageBook;
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

    class bahasaPageBook
    {
        public labelJudulBuku labelJudulBuku { get; set; }
        public labelPenulis labelPenulis { get; set; }
        public labelPenerbit labelPenerbit { get; set; }
        public labelTahunPenerbit labelTahunPenerbit { get; set; }
        public labelJumlahHalaman labelJumlahHalaman { get; set; }
        public buttonHapus buttonHapus { get; set; }
        public buttonKembali buttonKembali { get; set; }

        public bahasaPageBook() {}
        public bahasaPageBook(labelJudulBuku labelJudulBuku, labelPenulis labelPenulis,
            labelPenerbit labelPenerbit, labelTahunPenerbit labelTahunPenerbit,
            labelJumlahHalaman labelJumlahHalaman, buttonHapus buttonHapus, buttonKembali
            buttonKembali)
        {
            this.labelJudulBuku = labelJudulBuku;
            this.labelPenulis = labelPenulis;
            this.labelPenerbit = labelPenerbit;
            this.labelTahunPenerbit = labelTahunPenerbit;
            this.labelJumlahHalaman = labelJumlahHalaman;
            this.buttonHapus = buttonHapus;
            this.buttonKembali = buttonKembali;
        }
    }

    class labelJudulBuku
    {
        public string id { get; set; }
        public string en { get; set; }
        public labelJudulBuku() { }
        public labelJudulBuku(string id, string en)
        {
            this.id= id;
            this.en= en;
        }
    }

    class labelPenulis
    {
        public string id { get; set; }
        public string en { get; set; }
        public labelPenulis() { }
        public labelPenulis(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class labelPenerbit
    {
        public string id { get; set; }
        public string en { get; set; }
        public labelPenerbit() { }
        public labelPenerbit(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class labelTahunPenerbit
    {
        public string id { get; set; }
        public string en { get; set; }
        public labelTahunPenerbit() { }
        public labelTahunPenerbit(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class labelJumlahHalaman
    {
        public string id { get; set; }
        public string en { get; set; }
        public labelJumlahHalaman() { }
        public labelJumlahHalaman(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class buttonHapus
    {
        public string id { get; set; }
        public string en { get; set; }
        public buttonHapus() { }
        public buttonHapus(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class buttonKembali
    {
        public string id { get; set; }
        public string en { get; set; }
        public buttonKembali() { }
        public buttonKembali(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

}
