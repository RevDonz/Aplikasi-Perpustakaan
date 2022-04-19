using Newtonsoft.Json;
using System;
using System.IO;

namespace Aplikasi_Perpustakaan
{
    internal class ProgramConfig
    {
        public dynamic conf;
        public Config defaultConfig;
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public string configFileName = "configApp.json";

        public ProgramConfig()
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
            greeting pesanAwal = new greeting("Selamat Datang", "Welcome");
            pilihBahasa pilihBahasaAwal = new pilihBahasa("Pilih Bahasa", "Choose Language");
            text textAwal = new text(pesanAwal, pilihBahasaAwal);

            tambah btnTambah = new tambah("Tambah", "Add");
            hapus btnHapus = new hapus("Hapus", "Delete");
            kembali btnKembali = new kembali("Kembali", "Back");
            dataBuku btnDataBuku= new dataBuku("Data Buku", "Book Data");
            cariBuku btnCariBuku = new cariBuku("Cari Buku", "Search Book");

            button btnAwal = new button(btnTambah, btnHapus, btnKembali, btnDataBuku, btnCariBuku);
            defaultConfig = new Config(720, 1080, "id", textAwal, btnAwal);
        }

        public dynamic ReadConfigFile()
        {
            string jsonFromFile = File.ReadAllText(path + '/' + configFileName);
            conf = JsonConvert.DeserializeObject<Config>(jsonFromFile);
            return conf;
        }

        private void WriteNewConfigFile()
        {
            String jsonString = JsonConvert.SerializeObject(defaultConfig);
            string fullPath = path + '/' + configFileName;
            File.WriteAllText(fullPath, jsonString);
        }
    }
}
