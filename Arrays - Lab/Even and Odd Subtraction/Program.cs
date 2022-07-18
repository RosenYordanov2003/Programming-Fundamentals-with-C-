﻿using System;
using System.Linq;

namespace Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            int difference = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }
            difference = evenSum - oddSum;
            Console.WriteLine(difference);
        }
    }
}
