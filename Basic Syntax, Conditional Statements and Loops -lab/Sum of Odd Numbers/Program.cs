using System;

namespace Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int curentDigit = 0;
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    curentDigit = i * 2 + 1;
                    if (curentDigit % 2 != 0)
                    {
                        sum += curentDigit;
                        Console.WriteLine(curentDigit);
                    }
                }
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
