using System;

namespace Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int currentDigit = 2; currentDigit <= n; currentDigit++)
            {
                bool isPrime = true;
                for (int cepitel = 2; cepitel < currentDigit; cepitel++)
                {
                    if (currentDigit % cepitel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
              string result = isPrime.ToString();
                result = result.ToLower();
                Console.WriteLine($"{currentDigit} -> {result}");
            }

        }
    }
}
