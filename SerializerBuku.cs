using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    internal class SerializerBuku
    {
        public static List<Buku> deserialize(string path)
        {
            List<Buku> list_buku = new List<Buku>();
            //RawBuku raw = new RawBuku();

            string raw_text = File.ReadAllText(path);

            list_buku = JsonConvert.DeserializeObject<List<Buku>>(raw_text);
            //raw = JsonConvert.DeserializeObject<RawBuku>(raw_text);
            //list_buku = raw.buku;

            return list_buku;

        }
    }

    internal class RawBuku
    {
        public List<Buku> buku { get; set; }
    }
}
