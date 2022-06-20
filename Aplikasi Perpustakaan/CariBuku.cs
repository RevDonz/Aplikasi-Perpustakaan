using System;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    internal class CariBuku
    {
        public T SearchBuku<T>(T searchBuku)
        {
            if (typeof(T) == typeof(string))
            {
                dynamic title = searchBuku;
                return (T)title;
            } else
            {
                return default(T);
            }
        }

        public bool BukuTersedia<T>(T cari)
        {
            dynamic temp = SearchBuku(cari);

            string convertTemp = Convert.ToString(temp);

            //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\databuku.json";

            //List<Buku> list_buku = new List<Buku>();

            //Raw raw = Raw.getRecord(path);

            //list_buku = raw.buku;

            dynamic list_buku = Buku.GetDataBuku();

            for (int i = 0; i < list_buku.Count; i++)
            {
                Buku dataBuku = list_buku[i];
                if (dataBuku.judulBuku == convertTemp)
                {
                    return true;
                }
            }
            return false;
        }
        public void TampilDataBuku(bool hasil, dynamic cari)
        {
            cari = Convert.ToString(cari);

            dynamic list_buku = Buku.GetDataBuku();

            if (hasil == true)
            {
                for (int i = 0; i < list_buku.Count; i++)
                {
                    Buku dataBuku = list_buku[i];
                    if (cari == dataBuku.judulBuku)
                    {
                        MessageBox.Show("judul: " + dataBuku.judulBuku + "\n" + "id: " + dataBuku.idBuku + "\n" + "jumlah halaman: " + dataBuku.jumlahHalaman + "\n" + "peulis: " + dataBuku.penulis + "\n" + "status peminjaman: " + dataBuku.status);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Buku Tidak Ditemukan !");
            }
        }
    }
}
