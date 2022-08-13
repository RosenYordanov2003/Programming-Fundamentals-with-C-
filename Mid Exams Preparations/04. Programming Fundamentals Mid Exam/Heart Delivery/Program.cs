using System;
using System.Linq;

namespace Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            int position = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] tokens = command.Split(" ");
                int jumpLenght = int.Parse(tokens[1]);
                if (position + jumpLenght > houses.Length - 1)
                {
                    position = 0;
                    CheckHouse(houses, position, jumpLenght);
                }
                else
                {
                    position += jumpLenght;
                    CheckHouse(houses, position, jumpLenght);
                }
            }
            Console.WriteLine($"Cupid's last position was {position}.");
            int result = PrintMissionState(houses);
            if (result > 0)
            {
                Console.WriteLine($"Cupid has failed {result} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");
            }
        }
        static int PrintMissionState(int[] houses)
        {
            int counter = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i] != 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void CheckHouse(int[] houses, int position, int jumpLenght)
        {
            if (houses[position] != 0)
            {
                houses[position] -= 2;
                if (houses[position] == 0)
                {
                    Console.WriteLine($"Place {position} has Valentine's day.");
                }
            }
            else
            {
                Console.WriteLine($"Place {position} already had Valentine's day.");
            }
        }
    }
}
