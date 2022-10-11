using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MySampleProgrammOOPS
{
    internal class Product
    {
        //Properties
        int ProductID;
        string ProductName;
        int MRPRate;
        float GST = 13.2f;
        float Discount;
        float AfterDiscount;
        int Count;
        int Total;
        float FinalTotal;
        //methods
        public void AddProducts()
        {
            Console.WriteLine("Enter Product ID:");
            ProductID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name:");
            ProductName = Console.ReadLine();

            Console.WriteLine("Enter MRPRate:");
            MRPRate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Discount:");
            Discount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"How many products do you want to Buy:");
            Count = Convert.ToInt32(Console.ReadLine());

            Total = MRPRate * Count;
            AfterDiscount = Total - (Total * Discount / 100);
            FinalTotal = (AfterDiscount * GST) / 100;
            Console.WriteLine($"You have to pay amount Rs: {Total} ");
            Console.WriteLine("--------------------------------");

        }
        public void DisplayProductDetails()
        {
            Console.WriteLine( $"{Total} {AfterDiscount} {FinalTotal}");
        }
    }
}
      









