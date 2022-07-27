using System;
using System.Collections.Generic;
using System.Linq;

namespace Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> initialDrumState = new List<int>();
            initialDrumState.AddRange(drumSet);
            string comamand = string.Empty;
            double currentMoney = 0;
            while ((comamand = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(comamand);
                currentMoney = DrumStateAfterHit(drumSet, hitPower, money, initialDrumState);
                money = currentMoney;
            }
            Console.WriteLine(String.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {currentMoney:f2}lv.");
        }

        static double DrumStateAfterHit(List<int> drumSet, int hitPower, double money, List<int> InitialDrumSet)
        {
            for (int i = 0; i < drumSet.Count; i++)
            {
                if (drumSet[i] - hitPower > 0)
                {
                    drumSet[i] -= hitPower;
                }
                else if (drumSet[i] - hitPower <= 0)
                {
                    int price = (InitialDrumSet[i] * 3);
                    if (money - price > 0)
                    {
                        drumSet[i] = InitialDrumSet[i];
                        money -= price;
                    }
                    else
                    {
                        drumSet.Remove(drumSet[i]);
                        InitialDrumSet.Remove(InitialDrumSet[i]);
                        i--;
                    }
                }
            }
            return money;
        }
    }
}
