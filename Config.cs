using Newtonsoft.Json;
using System;
using System.IO;

namespace Aplikasi_Perpustakaan
{
    class Config
    {
        public int height { get; set; }
        public int width { get; set; }
        public String bahasa { get; set; }
        public greeting greeting { get; set; }

        public Config() { }
        public Config(int height, int width, string bahasa, greeting greeting)
        {
            this.height = height;
            this.width = width;
            this.bahasa = bahasa;
            this.greeting = greeting;
        }
    }

    class ProgramConfig
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
                Console.WriteLine("berhasil");
            }
            catch
            {
                SetDefault();
                WriteNewConfigFile();
                Console.WriteLine("gagal");
            }
        }

        private void SetDefault()
        {
            greeting pesanAwal = new greeting("Selamat Datang", "Welcome");
            defaultConfig = new Config(720, 1080, "id", pesanAwal);
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

    class greeting
    {
        public string id { get; set; }
        public string en { get; set; }

        public greeting() { }
        public greeting(string id, string en)
        {
            this.id = id;
            this.en = en;
        }

    }
}
