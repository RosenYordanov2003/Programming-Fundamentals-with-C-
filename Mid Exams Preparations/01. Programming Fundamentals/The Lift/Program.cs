using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int capacity = 4;
            int countPeople = int.Parse(Console.ReadLine());
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < wagons.Count; i++)
            {
                int peopleToWagon = capacity - wagons[i];
                if (capacity - wagons[i] >= peopleToWagon)
                {
                    if (countPeople < peopleToWagon)
                    {
                        wagons[i] += countPeople;
                        countPeople -= countPeople;
                    }
                    else
                    {
                        wagons[i] += peopleToWagon;
                        countPeople -= peopleToWagon;
                    }
                }
            }
            CheckWagons(wagons, countPeople);

            PrintResult(wagons);

        }


        static void CheckWagons(List<int> wagons, int countPeople)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] < 4)
                {
                    Console.WriteLine("The lift has empty spots!");
                    break;
                }
                if (countPeople > 0)
                {
                    Console.WriteLine($"There isn't enough space! {countPeople} people in a queue!");
                    break;
                }
            }
        }
        static void PrintResult(List<int> wagons)
        {
            foreach (var item in wagons)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
