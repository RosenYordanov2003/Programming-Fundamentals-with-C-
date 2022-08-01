using System;
using System.Linq;
using System.Collections.Generic;
namespace Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployess = new Dictionary<string, List<string>>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArguments = command.Split(" -> ").ToArray();
                string company = commandArguments[0];
                string currentEmployerID = commandArguments[1];
                if (!companyEmployess.ContainsKey(company))
                {
                    companyEmployess[company] = new List<string>();
                }
                if (!companyEmployess[company].Contains(currentEmployerID))
                {
                    companyEmployess[company].Add(currentEmployerID);
                }
            }
            PrintResult(companyEmployess);
        }

        static void PrintResult(Dictionary<string, List<string>> companyEmployess)
        {
            foreach (KeyValuePair<string,List<string>> company in companyEmployess)
            {
                Console.WriteLine(company.Key);
                foreach (string userId in company.Value)
                {
                    Console.WriteLine($"-- {userId}");
                }
            }
        }
    }
}
