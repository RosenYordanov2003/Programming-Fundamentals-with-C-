using System;
using System.Linq;

namespace Car_Race_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            {
                int middle = numbers.Length / 2;
                double leftPlayerSum = 0;
                double rightPlayerSum = 0;
                for (int left = 0; left < middle; left++)
                {
                    double currentNumber = numbers[left];
                    if (currentNumber == 0)
                    {
                        leftPlayerSum = (leftPlayerSum * 0.8);
                    }
                    leftPlayerSum += currentNumber;
                }
                for (int right = numbers.Length-1; right > middle; right--)
                {
                    double currentNumber = numbers[right];
                    if (currentNumber == 0)
                    {
                        rightPlayerSum = (rightPlayerSum * 0.8);
                    }
                    rightPlayerSum += currentNumber;
                }
                if (leftPlayerSum < rightPlayerSum)
                {
                    leftPlayerSum = Math.Round(leftPlayerSum, 3);
                    Console.WriteLine($"The winner is left with total time: {leftPlayerSum}");
                }
                else
                {
                    Console.WriteLine($"The winner is right with total time: {rightPlayerSum}");
                    rightPlayerSum=Math.Round(rightPlayerSum, 3);
                }
            }
        }
    }
}
