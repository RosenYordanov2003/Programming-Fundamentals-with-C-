using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\={1}|\/{1})(?<destination>[A-Z]{1}[A-Za-z]{2,})\1";
            Regex regex = new Regex(pattern);
            int sum = 0;
            List<string> validLocations = new List<string>();
            MatchCollection loctions = regex.Matches(input);
            foreach (Match match in loctions)
            {
                string currentDestination = match.Groups["destination"].Value;
                sum += currentDestination.Length;
                validLocations.Add(currentDestination);
            }
            Console.WriteLine($"Destinations: {string.Join(", ", validLocations)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
