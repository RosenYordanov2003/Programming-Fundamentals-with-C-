using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           string comand = Console.ReadLine();
            string[]comandSplit=comand.Split(' ').ToArray();
            int bomb = int.Parse(comandSplit[0]);
            int power = int.Parse(comandSplit[1]);
            while (true)
            {
                int indexBomb = numbers.IndexOf(bomb);
                if (indexBomb<0)
                {
                    break;
                }
                    DetonateBombs(numbers,power,indexBomb);
                
            }
            Console.WriteLine(numbers.Sum());
        }
       static void DetonateBombs(List<int>numbers,int power, int indexBomb)
        {
           int rigthToRemove = indexBomb + power;
            for (int right = indexBomb; right <=rigthToRemove; right++)
            {
                if (indexBomb >= numbers.Count)
                {
                    break;

                }
                numbers.RemoveAt(indexBomb);
            }
          int leftToRemove = indexBomb - power;
            if (leftToRemove<0)
            {
                leftToRemove = 0;
            }
            for (int left = leftToRemove; left < indexBomb; left++)
            {
                if (leftToRemove>=numbers.Count)
                {
                    break;
                }
                numbers.RemoveAt(leftToRemove);
            }
        }
    }
}
