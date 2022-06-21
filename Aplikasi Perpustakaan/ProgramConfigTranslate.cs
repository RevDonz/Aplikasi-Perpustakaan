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
            defaultConfigBahasa = new ConfigTranslate(bahasaPagePeminjaman);
        }

        public dynamic ReadConfigFile()
        {
            string jsonFromFile = File.ReadAllText(path + '/' + configFileName);
            conf = JsonConvert.DeserializeObject<Config>(jsonFromFile);
            return conf;
        }

        private void WriteNewConfigFile()
        {

            String jsonString = JsonConvert.SerializeObject(defaultConfigBahasa);
            string fullPath = path + '/' + configFileName;
            File.WriteAllText(fullPath, jsonString);
        }
    }










}
