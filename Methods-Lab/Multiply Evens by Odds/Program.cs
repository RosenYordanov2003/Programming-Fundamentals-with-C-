using System;

namespace Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            if (number<0)
            {
                number = Math.Abs(number);
            }
            GetSumOfEvenDigits(number);
            GetSumOfOddDigits(number);
            int result =GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

         static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
                number /= 10;
            }
            return oddSum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            while (number>0)
            {
                int digit = number % 10;
                if (digit%2==0)
                {
                    evenSum += digit;
                }
                number /= 10;
            }
            return evenSum;
        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = evenSum * oddSum;
            return result;
        }
    }
}
