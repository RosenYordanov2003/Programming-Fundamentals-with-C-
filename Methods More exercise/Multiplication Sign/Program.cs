using System;
using System.Collections.Generic;

namespace Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            numbers.Add(firstNumber);
            numbers.Add(secondNumber);
            numbers.Add(thirdNumber);
            bool isPositive = FindIsPositive(numbers);
            bool isNegative = FindWheterNegative(numbers);
            bool isZero = FindisZero(numbers);
            if (isPositive)
            {
                Console.WriteLine("positive");
            }
            if (isNegative)
            {
                Console.WriteLine("negative");
            }
            if (isZero)
            {
                Console.WriteLine("zero");
            }
        }

        static bool FindisZero(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool FindWheterNegative(List<int> numbers)
        {
            int countNegative = 0;
            foreach (int item in numbers)
            {
                if (item < 0)
                {
                    countNegative++;
                }
            }
            if (countNegative == 1 || countNegative == numbers.Count)
            {
                return true;
            }
            return false;
        }

        static bool FindIsPositive(List<int> numbers)
        {
            int countPositive = 0;
            int countNegative = 0;
            foreach (int item in numbers)
            {
                if (item > 0)
                {
                    countPositive++;
                }
                else if (item < 0)
                {
                    countNegative++;
                }
            }
            if (countPositive == numbers.Count)
            {
                return true;
            }
            else if (countNegative == 2)
            {
                return true;
            }
            return false;
        }
    }
}
