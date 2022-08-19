using System;
using System.Collections.Generic;

namespace P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Cities> dictionary = new Dictionary<string, Cities>();
            string command;
            while ((command = Console.ReadLine()) != "Sail")
            {
                string[] tokens = command.Split("||");
                string city = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);
                if (!dictionary.ContainsKey(city))
                {
                    dictionary[city] = new Cities(population, gold);
                }
                else
                {
                    dictionary[city].Population += population;
                    dictionary[city].Gold += gold;
                }
            }
            string secondCommand;
            while ((secondCommand = Console.ReadLine()) != "End")
            {
                string[] tokens = secondCommand.Split("=>");
                string action = tokens[0];
                if (action =="Plunder")
                {
                    string town = tokens[1];
                    int peopleToKill = int.Parse(tokens[2]);
                    int goldToGet = int.Parse(tokens[3]);
                    PlunderMethod(town, peopleToKill, goldToGet, dictionary);
                }
                else if (action=="Prosper")
                {
                    string town = tokens[1];
                    int goldToAdd = int.Parse(tokens[2]);
                    if (goldToAdd < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        ProsperMethod(town, goldToAdd, dictionary);
                    }
                }
            }
            PrintResult(dictionary);
        }

        static void PrintResult(Dictionary<string, Cities> dictionary)
        {
            if (dictionary.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dictionary.Count} wealthy settlements to go to:");
                foreach (KeyValuePair<string, Cities> city in dictionary)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        static void ProsperMethod(string town, int goldToAdd, Dictionary<string, Cities> dictionary)
        {
            dictionary[town].Gold += goldToAdd;
            Console.WriteLine($"{goldToAdd} gold added to the city treasury. {town} now has {dictionary[town].Gold} gold.");
        }

        static void PlunderMethod(string town, int peopleToKill, int goldToGet, Dictionary<string, Cities> dictionary)
        {
            dictionary[town].Population -= peopleToKill;
            dictionary[town].Gold -= goldToGet;
            Console.WriteLine($"{town} plundered! {goldToGet} gold stolen, {peopleToKill} citizens killed.");
            if (dictionary[town].Population <= 0 || dictionary[town].Gold <= 0)
            {
                Console.WriteLine($"{town} has been wiped off the map!");
                dictionary.Remove(town);
            }
        }
    }
    class Cities
    {
        public Cities(int population, int gold)
        {
            this.Population = population;
            this.Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
}
