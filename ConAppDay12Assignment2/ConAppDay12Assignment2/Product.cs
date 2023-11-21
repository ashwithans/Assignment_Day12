using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay12Assignment2
{
    public class Product
    {
        public int pid { get; set; }
        public string pname { get; set; }
        public double pprice { get; set; }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Product ID: {pid}");
            Console.WriteLine($"Product Name: {pname}");
            Console.WriteLine($"Product Price: ${pprice}");
        }

        public virtual void SetInformation()
        {
            Console.WriteLine("Enter Product ID:");
            pid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Name:");
            pname = Console.ReadLine();

            Console.WriteLine("Enter Product Price:");
            pprice = double.Parse(Console.ReadLine());
        }
    }

}