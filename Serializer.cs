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
        public static List<T> deserialize<T>(Raw raw)
        {
            dynamic list_result = new List<T>();

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
