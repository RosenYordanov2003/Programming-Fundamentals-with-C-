using System;
using System.Linq;
using System.Collections.Generic;
namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> comapnies = new Dictionary<string, List<string>>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" -> ").ToArray();
                string currentCompany = tokens[0];
                string currentEmployerID = tokens[1];
                if (!comapnies.ContainsKey(currentCompany))
                {
                    comapnies[currentCompany] = new List<string>();
                }
                comapnies[currentCompany].Add(currentEmployerID);
            }
            PrintResult(comapnies);
        }

        static void PrintResult(Dictionary<string, List<string>> comapnies)
        {
            foreach (KeyValuePair<string,List<string>> company in comapnies)
            {
                Console.WriteLine($"{company.Key}: {company.Value.Count}");
                foreach (string employer in company.Value)
                {
                    Console.WriteLine($"-- {employer}");
                }
            }
        }
    }
}
