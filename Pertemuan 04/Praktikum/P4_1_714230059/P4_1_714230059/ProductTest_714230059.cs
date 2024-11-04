using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230059
{
    internal class ProductTest_714230059
    {
        static void Main(string[] args)
        {
            //Product_714230059 myProduct = new Product_714230059();

            //Console.WriteLine(myProduct.GetMyType());

            //myProduct.MyType = "DVD";

            //Console.WriteLine(myProduct.MyType);

            Book_714230059 product1 = new Book_714230059("Book", "C# Object Oriented Solution", "300");
            DVD_714230059 product2 = new DVD_714230059("Ethernal Sunshine Of The Spotless Mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();

        }
    }
}
