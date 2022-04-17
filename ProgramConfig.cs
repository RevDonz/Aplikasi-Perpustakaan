﻿using Newtonsoft.Json;
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
}
