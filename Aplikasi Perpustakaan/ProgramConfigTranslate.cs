using Newtonsoft.Json;
using System;
using System.IO;

namespace Aplikasi_Perpustakaan
{
    internal class ProgramConfigTranslate
    {
        public dynamic conf;
        public ConfigTranslate defaultConfigBahasa;
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public string configFileName = "configTranslate.json";

        public ProgramConfigTranslate()
        {
            try
            {
                ReadConfigFile();
            }
            catch
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        private void SetDefault()
        {
            labelIdBuku labelIdBuku = new labelIdBuku("ID Buku","Book ID");
            labelNamaPeminjam labelNamaPeminjam = new labelNamaPeminjam("Nama Peminjam","Borrower's name");
            bahasaPagePeminjaman bahasaPagePeminjaman = new bahasaPagePeminjaman(labelIdBuku, labelNamaPeminjam);

            labelJudulBuku labelJudulBuku = new labelJudulBuku("Judul Buku","Book's Title");
            labelPenulis labelPenulis = new labelPenulis("Penulis","Writer");
            labelPenerbit labelPenerbit = new labelPenerbit("Penerbit", "Publisher");
            labelTahunPenerbit labelTahunPenerbit = new labelTahunPenerbit("Tahun Terbit", "Publication Year");
            labelJumlahHalaman labelJumlahHalaman = new labelJumlahHalaman("Jumlah Halaman", "Number of Pages");
            buttonHapus buttonHapus = new buttonHapus("Hapus", "Delete");
            buttonKembali buttonKembali = new buttonKembali("Kembali", "Back");
            bahasaPageBook bahasaPageBook = new bahasaPageBook(labelJudulBuku, labelPenulis,
                labelPenerbit, labelTahunPenerbit, labelJumlahHalaman, buttonHapus, buttonKembali);
            defaultConfigBahasa = new ConfigTranslate(bahasaPagePeminjaman, bahasaPageBook);
        }

        public dynamic ReadConfigFile()
        {
            string jsonFromFilee = File.ReadAllText(path + '/' + configFileName);
            conf = JsonConvert.DeserializeObject<ConfigTranslate>(jsonFromFilee);
            return conf;
        }

        private void WriteNewConfigFile()
        {

            String jsonStringg = JsonConvert.SerializeObject(defaultConfigBahasa);
            string fullPath = path + '/' + configFileName;
            File.WriteAllText(fullPath, jsonStringg);
        }
    }










}
