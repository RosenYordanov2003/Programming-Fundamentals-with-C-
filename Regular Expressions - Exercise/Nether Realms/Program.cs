using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] {' ',','};
            List<string> demons = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<Demon> demonsList = new List<Demon>();
            demons = demons.OrderBy(x => x).ToList();
            decimal demonDamage = 0m;
            decimal demonHealth = 0m;
            for (int i = 0; i < demons.Count; i++)
            {
                string currentDemon = demons[i];
                currentDemon=currentDemon.Trim();
                demonHealth = SumDemonHealth(currentDemon);
                demonDamage = SumDemonDamage(currentDemon);
                demonDamage = MultiplyOrDivideDemonDamage(demonDamage, currentDemon);
                Demon currentrDemon = new Demon(currentDemon, demonHealth, demonDamage);
                demonsList.Add(currentrDemon);
            }
            PrintResult(demonsList);
        }
        static void PrintResult(List<Demon> demonsList)
        {
            foreach (Demon demon in demonsList)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        static decimal MultiplyOrDivideDemonDamage(decimal demonDamage, string currentDemon)
        {
            foreach (char symbol in currentDemon)
            {
                if (symbol == '*')
                {
                    demonDamage *= 2;
                }
                else if (symbol == '/')
                {
                    demonDamage /= 2;
                }
            }
            return demonDamage;
        }

        static decimal SumDemonDamage(string currentDemon)
        {
            string pattern = @"(?<numbers>(\-|\+)?\d+(\.\d+)?)";
            decimal damage = 0m;
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(currentDemon);
            foreach (Match number in matches)
            {
                damage += decimal.Parse(number.Value);
            }
            return damage;
        }

        static decimal SumDemonHealth(string currentDemon)
        {
            decimal sum = 0m;
            foreach (char symbol in currentDemon)
            {
                if ((!char.IsDigit(symbol)) && symbol != '+' && symbol != '-' && symbol != '*' && symbol != '/' && symbol != '.')
                {
                    sum += (decimal)(symbol);
                }
            }
            return sum;
        }
        class Demon
        {
            public Demon(string name, decimal health, decimal damage)
            {
                this.Name = name;
                this.Health = health;
                this.Damage = damage;
            }
            public string Name { get; set; }
            public decimal Health { get; set; }
            public decimal Damage { get; set; }
        }
    }
}
