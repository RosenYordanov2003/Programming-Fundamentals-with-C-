using System;

namespace MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] comands = Console.ReadLine().Split('|');
            int initialHealth = 100;
            int intialBitcoins = 0;
            int diff = 0;
            bool isAlive = true;
            for (int i = 0; i < comands.Length; i++)
            {
                string[] tokens = comands[i].Split(" ");
                string operation = tokens[0];
                if (operation == "potion")
                {
                    int health = int.Parse(tokens[1]);
                    if (initialHealth < 100)
                    {
                        initialHealth += health;
                        if (initialHealth > 100)
                        {
                            diff = initialHealth - 100;
                            initialHealth -= diff;
                        }
                        Console.WriteLine($"You healed for {health - diff} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                    }
                }
                else if (operation == "chest")
                {
                    int amountBitcoins = int.Parse(tokens[1]);
                    intialBitcoins += amountBitcoins;
                    Console.WriteLine($"You found {amountBitcoins} bitcoins.");
                }
                else
                {
                    string monsterName = tokens[0];
                    int monsterPower = int.Parse(tokens[1]);
                    initialHealth -= monsterPower;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {monsterName}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        isAlive = false;
                        break;
                    }
                }
            }
            if (isAlive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {intialBitcoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}
