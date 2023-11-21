using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay12Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct herbalProduct = new HerbalProduct();
            Console.WriteLine("Enter Product Details:");
            herbalProduct.SetInformation();
            Console.WriteLine("\nProduct Details:");
            herbalProduct.ShowDetails();
            Console.ReadKey();
        }
    }
}
