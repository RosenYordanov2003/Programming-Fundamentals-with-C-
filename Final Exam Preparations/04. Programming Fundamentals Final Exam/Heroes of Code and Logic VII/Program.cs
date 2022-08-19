using System;
using System.Collections.Generic;

namespace Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Heroes> dictionary = new Dictionary<string, Heroes>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string heroName = command[0];
                int hitPoints = int.Parse(command[1]);
                int manaPoints = int.Parse(command[2]);
                if (!dictionary.ContainsKey(heroName))
                {
                    dictionary.Add(heroName, new Heroes(hitPoints, manaPoints));
                    dictionary[heroName].HitPoints = hitPoints;
                    dictionary[heroName].ManaPoints = manaPoints;
                }
            }
            string command2;
            while ((command2 = Console.ReadLine()) != "End")
            {
                string[] tokens = command2.Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                if (action == "CastSpell")
                {
                    string heroName = tokens[1];
                    int manaPointsNeded = int.Parse(tokens[2]);
                    string spellName = tokens[3];
                    CastSpellMethod(heroName, manaPointsNeded, spellName, dictionary);
                }
                else if (action == "TakeDamage")
                {
                    string heroName = tokens[1];
                    int damageToReduce = int.Parse(tokens[2]);
                    string attacker = tokens[3];
                    if (dictionary.ContainsKey(heroName))
                    {
                        TakeDamageMethod(heroName, damageToReduce, attacker, dictionary);
                    }
                }
                else if (action == "Recharge")
                {
                    string heroName = tokens[1];
                    int manaPointsAmount = int.Parse(tokens[2]);
                    
                    RechargeMethod(heroName, manaPointsAmount, dictionary);
                }
                else if (action == "Heal")
                {
                    string heroName = tokens[1];
                    int healAmount = int.Parse(tokens[2]);
                    const int maximulHealCapacity = 100;
                   
                    HealMethod(heroName, healAmount, maximulHealCapacity, dictionary);
                }
            }
            PrintResult(dictionary);
        }

        static void PrintResult(Dictionary<string, Heroes> dictionary)
        {
            foreach (KeyValuePair<string, Heroes> hero in dictionary)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($" HP: {hero.Value.HitPoints}");
                Console.WriteLine($" MP: {hero.Value.ManaPoints}");
            }
        }
        static void HealMethod(string heroName, int healAmount, int maximulHealCapacity, Dictionary<string, Heroes> dictionary)
        {
            int result = dictionary[heroName].HitPoints + healAmount;
            if (result >= 100)
            {
                result -= maximulHealCapacity;
                int consumedHeal = healAmount - result;
                dictionary[heroName].HitPoints += consumedHeal;
                Console.WriteLine($"{heroName} healed for {consumedHeal} HP!");
            }
            else
            {
                dictionary[heroName].HitPoints += healAmount;
                Console.WriteLine($"{heroName} healed for {healAmount} HP!");
            }
        }

        static void RechargeMethod(string heroName, int manaPointsAmount, Dictionary<string, Heroes> dictionary)
        {
            const int maximumManaPointsAmount = 200;
            int result = dictionary[heroName].ManaPoints + manaPointsAmount;
            if (result >= maximumManaPointsAmount)
            {
                result -= maximumManaPointsAmount;
                int consumedAmount = manaPointsAmount - result;
                dictionary[heroName].ManaPoints += consumedAmount;
                Console.WriteLine($"{heroName} recharged for {consumedAmount} MP!");
            }
            else
            {
                dictionary[heroName].ManaPoints += manaPointsAmount;
                Console.WriteLine($"{heroName} recharged for {manaPointsAmount} MP!");
            }
        }

        static void TakeDamageMethod(string heroName, int damageToReduce, string attacker, Dictionary<string, Heroes> dictionary)
        {
            dictionary[heroName].HitPoints -= damageToReduce;
            if (dictionary[heroName].HitPoints > 0)
            {
                Console.WriteLine($"{heroName} was hit for {damageToReduce} HP by {attacker} and now has {dictionary[heroName].HitPoints} HP left!");
            }
            else
            {
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                dictionary.Remove(heroName);
            }
        }

        static void CastSpellMethod(string heroName, int manaPointsNeded, string spellName, Dictionary<string, Heroes> dictionary)
        {
            if (dictionary[heroName].ManaPoints >= manaPointsNeded)
            {
                dictionary[heroName].ManaPoints -= manaPointsNeded;
                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {dictionary[heroName].ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
            }
        }
    }
    class Heroes
    {
        public Heroes(int hitPoints, int manaPoints)
        {
            this.HitPoints = hitPoints;
            this.ManaPoints = manaPoints;
        }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
    }
}
