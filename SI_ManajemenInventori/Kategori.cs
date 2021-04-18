using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_ManajemenInventori
{
    public class Kategori
    {
        private int kodeKategori;
        private string namaKategori;

        public int KodeKategori { get => kodeKategori; set => kodeKategori = value; }
        public string NamaKategori { get => namaKategori; set => namaKategori = value; }

        public Kategori(int kodeKategori, string namaKategori)
        {
            KodeKategori = kodeKategori;
            NamaKategori = namaKategori;
        }

        public static void TambahData(Kategori k)
        {
            string sql = "insert into kategori(nama_kategori) values('" + k.NamaKategori + "')";
            Koneksi.JalankanPerintahDML(sql);
        }
    }
}
