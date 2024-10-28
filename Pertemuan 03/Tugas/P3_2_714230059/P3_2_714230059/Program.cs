using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714230059
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ulangi = true;

            while (ulangi)
            {
                Console.Clear(); 
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        HitungLuas();
                        break;
                    case "2":
                        HitungKeliling();
                        break;
                    case "3":
                        ulangi = false;
                        Console.WriteLine("Program selesai. Terima kasih!");
                        break;
                    default:
                        Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                        break;
                }

                if (ulangi)
                {
                    Console.Write("\nIngin mengulang kembali (Y/T)? ");
                    string jawab = Console.ReadLine().ToUpper();
                    ulangi = (jawab == "Y");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void HitungLuas()
        {
            Console.Write("Masukkan panjang (cm): ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar (cm): ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;
            Console.WriteLine($"Luas Persegi Panjang: {luas} cm²");
        }

        static void HitungKeliling()
        {
            Console.Write("Masukkan panjang (cm): ");
            double panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan lebar (cm): ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double keliling = 2 * (panjang + lebar);
            Console.WriteLine($"Keliling Persegi Panjang: {keliling} cm");
        }
    }
}