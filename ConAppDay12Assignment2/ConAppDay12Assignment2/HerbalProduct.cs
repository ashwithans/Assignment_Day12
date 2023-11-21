using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay12Assignment2
{
    public class HerbalProduct : Product
    {
        public string herbsUsed { get; set; }
        public DateTime mfDate { get; set; }
        public DateTime expDate { get; set; }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Herbs Used: {herbsUsed}");
            Console.WriteLine($"Manufacturing Date: {mfDate.ToShortDateString()}");
            Console.WriteLine($"Expiry Date: {expDate.ToShortDateString()}");
        }

        public override void SetInformation()
        {
            base.SetInformation();

            Console.WriteLine("Enter Herbs Used:");
            herbsUsed = Console.ReadLine();

            mfDate = DateTime.Now;

            expDate = mfDate.AddYears(3);
        }
    }
}
