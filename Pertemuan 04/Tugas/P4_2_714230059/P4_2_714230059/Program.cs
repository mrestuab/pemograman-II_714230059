using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714230059
{
    abstract class PemainSepakBola
    {
        // Constructor (membuat objek pemain sepak bola dengan beberapa properti dasar)
        protected PemainSepakBola(string nama, int nomorPunggung)
        {
            Nama = nama;
            NomorPunggung = nomorPunggung;
        }

        // Encapsulation (field privat dengan properti getter)
        public string Nama { get; }
        public int NomorPunggung { get; }

        // Abstract Method untuk bermain (aksi khas berdasarkan posisi)
        public abstract string Bermain();

        // Abstract Method untuk peran utama (fungsi unik sesuai posisi)
        public abstract string PeranUtama();
    }

    // Inheritance
    class Penyerang : PemainSepakBola
    {
        // Constructor
        public Penyerang(string nama, int nomorPunggung)
            : base(nama, nomorPunggung)
        {
        }

        // Polymorphism (implementasi bermain yang berbeda untuk penyerang)
        public override string Bermain()
        {
            return $"{Nama} menyerang dan bermain dengan sangat baik!";
        }

        // Polymorphism (implementasi peran utama yang berbeda untuk penyerang)
        public override string PeranUtama()
        {
            return $"Peran utama {Nama} adalah mencetak gol.";
        }
    }

    // Inheritance
    class Kiper : PemainSepakBola
    {
        // Constructor (menambahkan properti jumlah penyelamatan)
        public Kiper(string nama, int nomorPunggung, int jumlahPenyelamatan)
            : base(nama, nomorPunggung)
        {
            JumlahPenyelamatan = jumlahPenyelamatan;
        }

        // Encapsulation (field privat dengan properti getter)
        public int JumlahPenyelamatan { get; }

        // Polymorphism (implementasi bermain yang berbeda untuk kiper)
        public override string Bermain()
        {
            return $"{Nama} menjaga gawang dan mencegah bola masuk!";
        }

        // Polymorphism (implementasi peran utama yang berbeda untuk kiper)
        public override string PeranUtama()
        {
            return $"Peran utama {Nama} adalah melakukan penyelamatan sebanyak {JumlahPenyelamatan} kali.";
        }
    }

    // Program Utama
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Data Pemain Penyerang:");
            Console.Write("Nama: ");
            string namaPenyerang = Console.ReadLine();
            Console.Write("Nomor Punggung: ");
            int nomorPunggungPenyerang = int.Parse(Console.ReadLine());

            Penyerang penyerang = new Penyerang(namaPenyerang, nomorPunggungPenyerang);

            Console.WriteLine("\nInput Data Pemain Kiper:");
            Console.Write("Nama: ");
            string namaKiper = Console.ReadLine();
            Console.Write("Nomor Punggung: ");
            int nomorPunggungKiper = int.Parse(Console.ReadLine());
            Console.Write("Jumlah Penyelamatan: ");
            int jumlahPenyelamatanKiper = int.Parse(Console.ReadLine());

            Kiper kiper = new Kiper(namaKiper, nomorPunggungKiper, jumlahPenyelamatanKiper);

            Console.WriteLine("\nData Pemain Penyerang:");
            Console.WriteLine(penyerang.Bermain());
            Console.WriteLine(penyerang.PeranUtama());

            Console.WriteLine("\nData Pemain Kiper:");
            Console.WriteLine(kiper.Bermain());
            Console.WriteLine(kiper.PeranUtama());
        }
    }
}