using System;

namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string comand = string.Empty;
            double sum = 0;
            while (comand != "Start")
            {
                comand = Console.ReadLine();
                if (comand == "Start")
                {
                    break;
                }
                double coins = double.Parse(comand);
                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2)
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    continue;
                }
                sum += coins;

            }
            string product = string.Empty;
            while (true)
            {
                product = Console.ReadLine();
                double productPrice = 0;
                if (product == "End")
                {
                    break;
                }
                if (product == "Nuts")
                {
                    productPrice = 2.0;
                }
                else if (product == "Coke")
                {
                    productPrice = 1.0;
                }
                else if (product == "Water")
                {
                    productPrice = 0.7;
                }
                else if (product == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.5;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                if (sum >= productPrice)
                {
                    sum -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
