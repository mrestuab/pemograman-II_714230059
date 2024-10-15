using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan angka pertama :");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukan angka pertama :");
            double input2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("angka pertama = " + input);
            Console.WriteLine("angka kedua = " + input2);
            Console.WriteLine(input + "+" + input2 + "=" + (input + input2));
            Console.WriteLine(input + "-" + input2 + "=" + (input - input2));
            Console.WriteLine(input + "*" + input2 + "=" + (input * input2));
            Console.WriteLine(input + "/" + input2 + "=" + (input / input2));
        }
    }
}
