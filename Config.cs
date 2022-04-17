using System;

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
