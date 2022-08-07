using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            string pattern = @"\%(?<client>[A-Z]{1}[a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<quantity>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$";
            string command;
            decimal totalPrice = 0m;
            while ((command = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(command, pattern);
                if (match.Success)
                {
                    string clientName = match.Groups["client"].Value;
                    string productName = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal totalClientPrice = quantity * price;
                    totalPrice += totalClientPrice;
                    Customer currentCustomer = new Customer(clientName, productName, totalClientPrice);
                    customers.Add(currentCustomer);
                }
            }
            PrintResult(customers, totalPrice);
        }

        static void PrintResult(List<Customer> customers, decimal totalPrice)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"{customer.Name}: {customer.Product} - {customer.TotalPrice:f2}");
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
    class Customer
    {
        public Customer(string name, string product, decimal totalPrice)
        {
            this.Name = name;
            this.Product = product;
            this.TotalPrice = totalPrice;
        }
        public string Name { get; set; }
        public decimal TotalPrice { get; set; }
        public string Product { get; set; }
    }
}
