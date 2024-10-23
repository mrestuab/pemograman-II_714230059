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
            do
            {
                Console.Clear();

                Console.Write("Menentukan indeks prestasi mahasiswa\n--------");
                Console.Write("\nmasukan nama mahasiswa:");

                String nama = Console.ReadLine();

                Console.WriteLine("Masukan Nilai : ");

                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D" };

                if (nilai >= 85)
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}",nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}",nama, grade[1]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}",nama, grade[2]);
                }
                else
                {
                    Console.WriteLine("indeks nilai {0} adalah {1}",nama, grade[3]);
                }
                Console.Write("\nmasukan indeks yang ditampilkan : ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks prestasi {0} adalah ", nama);

                prestasi(indeks);

                Console.Write("\n ingin mengulang kembali (y/t)?");
            }
            while (Console.ReadLine() == "Y");
        }
        private static void prestasi(char indeks)
        {
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("sangat baik");
                    break;
                case 'B':
                    Console.WriteLine("baik");
                    break;
                case 'C':
                    Console.WriteLine("cukup");
                    break;
                case 'D':
                    Console.WriteLine("sangat buruk");
                    break;
                default:
                    Console.WriteLine("invalid indeks prestasi");
                    break;
            }
        }
    }
}
