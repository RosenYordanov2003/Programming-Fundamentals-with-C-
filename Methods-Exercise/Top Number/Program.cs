using System;

namespace Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                bool result = IsTopNumber(currentNumber);
                if (result == true)
                {
                    Console.WriteLine(currentNumber);
                }
            }
        }

        static bool IsTopNumber(int currentNumber)
        {
            bool isDivisibleby8 = false;
            bool containsOddDigit = false;
            int sum = 0;
            if (currentNumber >= 10)
            {
                while (currentNumber >0)
                {
                    int digit = currentNumber % 10;
                    sum += digit;
                    if (digit % 2 != 0)
                    {
                        
                        containsOddDigit = true;
                    }
                    currentNumber /= 10;
                }
                if (sum % 8 == 0)
                {
                    isDivisibleby8 = true;
                }
            }
            else
            {
                if ((currentNumber % 8 == 0) && (currentNumber % 2 != 0))
                {
                    isDivisibleby8 = true;
                    containsOddDigit = true;
                }
            }
            if (isDivisibleby8 && containsOddDigit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
