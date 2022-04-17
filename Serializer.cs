using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    internal class Serializer
    {
        public static List<T> deserialize<T>(string path)
        {
            dynamic list_result = new List<T>();
            Raw raw = new Raw();

            string raw_text = File.ReadAllText(path);

            raw = JsonConvert.DeserializeObject<Raw>(raw_text, new JsonSerializerSettings
            {
                DateFormatString = "dd/MM/yyyy"
            });

            if (typeof(T) == typeof(Buku))
            {
                list_result = raw.buku;
            }
            else
            {
                list_result = raw.peminjaman;
            }

            return list_result;

        }
    }
}
