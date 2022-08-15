using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine().Split('|').ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] tokens = command.Split(" ");
                string operation = tokens[0];
                int tokenIndex = command.IndexOf(operation);
                if (operation == "Loot")
                {
                    LootMethod(tokens, treasure, tokenIndex);
                }
                else if (operation == "Drop")
                {
                    int indexToRemove = int.Parse(tokens[1]);
                    if (indexToRemove >= 0 && indexToRemove < treasure.Count)
                    {
                        DropMethod(treasure, indexToRemove);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (operation == "Steal")
                {
                    int countToSteal = int.Parse(tokens[1]);
                    PrintStealItems(countToSteal, treasure);
                    RemoveStealItems(countToSteal, treasure);
                }
            }
            GetSum(treasure);
        }

        static void GetSum(List<string> treasure)
        {
            if (treasure.Count > 0)
            {
                double sum = 0;
                for (int i = 0; i < treasure.Count; i++)
                {
                    string currentItem = treasure[i];
                    sum += currentItem.Length;
                }
                sum /= treasure.Count;
                Console.WriteLine($"Average treasure gain: {sum:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }

        static void RemoveStealItems(int countToSteal, List<string> treasure)
        {
            int end = treasure.Count - countToSteal;
            if (end < 0)
            {
                end = 0;
            }
            for (int i = treasure.Count - 1; i >= end; i--)
            {
                if (treasure.Count > 0)
                {
                    treasure.Remove(treasure[i]);
                }
            }
        }

        static void PrintStealItems(int countToSteal, List<string> treasure)
        {
            List<string> stealedItems = new List<string>();
            int end = treasure.Count - countToSteal;
            if (end < 0)
            {
                end = 0;
            }
            for (int i = treasure.Count - 1; i >= end; i--)
            {
                if (treasure.Count > 0)
                {
                    stealedItems.Insert(0, treasure[i]);
                }
            }
            Console.WriteLine(String.Join(", ", stealedItems));
        }

        static void DropMethod(List<string> treasure, int indexToRemove)
        {
            string item = treasure[indexToRemove];
            treasure.RemoveAt(indexToRemove);
            treasure.Insert(treasure.Count, item);
        }
        static void LootMethod(string[] tokens, List<string> treasure, int tokenIndex)
        {
            for (int i = 0; i < tokens.Length; i++)
            {
                string currentItem = tokens[i];
                if (i == tokenIndex)
                {
                    continue;
                }
                else
                {
                    if (treasure.Contains(currentItem))
                    {
                        continue;
                    }
                    else
                    {
                        treasure.Insert(0, currentItem);
                    }
                }
            }
        }
    }
}
