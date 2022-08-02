using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<int>>> dragons = new Dictionary<string, Dictionary<string, List<int>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                string type = tokens[0];
                string name = tokens[1];
                int damage = tokens[2] == "null" ? 45 : int.Parse(tokens[2]);
                int health = tokens[3] == "null" ? 250 : int.Parse(tokens[3]);
                int armor = tokens[4] == "null" ? 10 : int.Parse(tokens[4]);
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new Dictionary<string, List<int>>());
                }
                dragons[type][name] = new List<int>();
                dragons[type][name].Add(damage);
                dragons[type][name].Add(health);
                dragons[type][name].Add(armor);
            }
            PrintResult(dragons);
        }

        static void PrintResult(Dictionary<string, Dictionary<string, List<int>>> dragons)
        {
            foreach (var dragon in dragons)
            {
                double averageDamage = 1.00 * (dragon.Value.Values.Select(damage => damage[0]).Sum()) / dragons[dragon.Key].Count();
                double averageHealth = 1.00 * (dragon.Value.Values.Select(health => health[1]).Sum()) / dragons[dragon.Key].Count();
                double averageArmour = 1.00 * (dragon.Value.Values.Select(armour => armour[2]).Sum()) / dragons[dragon.Key].Count();
                Console.WriteLine($"{dragon.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmour:f2})");
                foreach (var personalDragon in dragon.Value.OrderBy(dragon => dragon.Key))
                {
                    Console.WriteLine($"-{personalDragon.Key} -> damage: {personalDragon.Value[0]}, health: {personalDragon.Value[1]}, armor: {personalDragon.Value[2]}");
                }
            }
        }
    }
}
