using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    internal class CariBuku<T>
    {
        public static T SearchBuku<T>(T searchBuku)
        {
            if (typeof(T) == typeof(string))
            {
                dynamic title = searchBuku;
                return (T)title;
            } else
            {
                dynamic id = searchBuku;
                return (T)id;
            }
        }

        public static bool BukuTersedia(T cari)
        {
            dynamic temp = SearchBuku(cari);
            List<Buku> list_buku = new List<Buku>();
            list_buku = Serializer.deserialize<Buku>(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\" + "dataBuku.json");
            for (int i = 0; i < list_buku.Count; i++)
            {
                Buku dataBuku = list_buku[i];
                if (dataBuku.idBuku == temp)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
