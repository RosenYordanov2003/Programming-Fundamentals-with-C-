using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            ProductPrice(product,count);
        }

        static void ProductPrice(string product,int count)
        {
           double price=0.0;
            if (product=="water")
            {
                price += 1.00*count;
            }
            else if (product == "coke")
            {
                price += 1.40*count;
            }
            else if (product=="snacks")
            {
                price += 2.00*count;
            }
            else if (product=="coffee")
            {
                price += 1.50*count;
            }
            Console.WriteLine($"{price:f2}");            
        }
    }
}
