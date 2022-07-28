using System;
using System.Numerics;

namespace Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                BigInteger sum = 1;
                PrintNFacturiel(n, sum);
            }
            static void PrintNFacturiel(int n, BigInteger sum)
            {
                while (n > 0)
                {
                    sum *= n;
                    n--;
                }
                Console.WriteLine($"{sum}");
            }
        }
    }
}
