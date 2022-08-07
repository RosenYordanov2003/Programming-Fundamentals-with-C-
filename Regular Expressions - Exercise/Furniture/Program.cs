using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regular_Expressions___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            string command;
            double sum = 0;
            List<string> items = new List<string>();
            while ((command=Console.ReadLine())!="Purchase")
            {
                MatchCollection macthes = Regex.Matches(command, patern);
                foreach (Match item in macthes)
                {
                    string furniture = item.Groups["furniture"].Value;
                    items.Add(furniture);
                   double price =  double.Parse(item.Groups["price"].Value);
                   int quantity = int.Parse(item.Groups["quantity"].Value);
                    sum += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (string furniture in items)
            {
                Console.WriteLine(furniture);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
