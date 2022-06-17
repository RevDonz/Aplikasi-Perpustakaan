﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace LibrariesAPI
{
    public class API
    {
        //public static void Main(string[] args)
        //{
        //    String url = "https://w5bzmo.deta.dev/buku/get";
        //    dynamic result = Get<Buku>(url);


        //    foreach (Buku item in result)
        //    {
        //        Console.WriteLine("Judul Buku : " + item.judulBuku);
        //        Console.WriteLine("Tahun terbit : " + item.tahunTerbit);
        //        Console.WriteLine();
        //    }
        //}

        public static List<T> Get<T>(String url)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(String.Format(url));
            WebReq.Method = "GET";
            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            Console.WriteLine(jsonString);

            List<T> items = JsonConvert.DeserializeObject<List<T>>(jsonString);
            return items as List<T>;

        }

        public static bool Post<T>(String url, T value)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(String.Format(url));
            WebReq.Method = "POST";
            //HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            if (typeof(T) == typeof(Buku))
            {
                return true;
            }
            else if (typeof(T) == typeof(Peminjaman))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Post
    {
        public int kode { get; set; }
        public String message { get; set; }
        public bool status { get; set; }
        public Buku value { get; set; }
    }

    class Buku
    {
        public string idBuku { get; set; }
        public string judulBuku { get; set; }
        public int jumlahHalaman { get; set; }
        public string penulis { get; set; }
        public string penerbit { get; set; }
        public int tahunTerbit { get; set; }
        public string status { get; set; }
    }

    class Peminjaman
    {
        public string nama_peminjam { get; set; }
        public int id_buku { get; set; }
        public DateTime tanggal_pinjam { get; set; }
        public string status_peminjaman { get; set; }
    }
}
