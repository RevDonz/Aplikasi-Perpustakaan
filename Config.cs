using System;

namespace Aplikasi_Perpustakaan
{
    class Config
    {
        public int height { get; set; }
        public int width { get; set; }
        public String bahasa { get; set; }
        public text text { get; set; }

        public Config() { }
        public Config(int height, int width, string bahasa, text text)
        {
            this.height = height;
            this.width = width;
            this.bahasa = bahasa;
            this.text = text;
        }
    }

    class text
    {
        public greeting greeting { get; set; }
        public pilihBahasa pilihBahasa { get; set; }
        public text() { }

        public text(greeting greeting, pilihBahasa pilihBahasa)
        {
            this.greeting = greeting;
            this.pilihBahasa = pilihBahasa;
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

    class pilihBahasa
    {
        public string id { get; set; }
        public string en { get; set; }

        public pilihBahasa() { }
        public pilihBahasa(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }
}
