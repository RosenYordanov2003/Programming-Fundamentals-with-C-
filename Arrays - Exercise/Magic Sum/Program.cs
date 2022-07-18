using System;
using System.Linq;

namespace Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];
                for (int z = i + 1; z < numbers.Length; z++)
                {
                    int secondNumber = numbers[z];
                    if (firstNumber + secondNumber == magicNum)
                    {
                        Console.WriteLine($"{firstNumber} {secondNumber}");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
