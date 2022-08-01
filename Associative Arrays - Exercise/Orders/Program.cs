using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ProductsProperties> products = new Dictionary<string, ProductsProperties>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] tokens = command.Split(" ").ToArray();
                string product = tokens[0];
                decimal currentPrice = decimal.Parse(tokens[1]);
                int currentCount = int.Parse(tokens[2]);
                ProductsProperties currentProp = new ProductsProperties(currentPrice, currentCount);
                if (products.ContainsKey(product))
                {
                    if (products[product].Price != currentPrice)
                    {
                        products[product].Price = currentPrice;
                    }
                    products[product].Count += currentCount;
                }
                else
                {
                    products[product] = currentProp;
                }
            }
            PrintResult(products);
        }
        static void PrintResult(Dictionary<string, ProductsProperties> products)
        {
            foreach (KeyValuePair<string, ProductsProperties> item in products)
            {
                decimal currentPordutTotalPrice = item.Value.TotalPrice = item.Value.Price * item.Value.Count;
                Console.WriteLine($"{item.Key} -> {currentPordutTotalPrice:f2}");
            }
        }
    }
    class ProductsProperties
    {
        public ProductsProperties(decimal price, int count)
        {
            this.Price = price;
            this.Count = count;
        }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
