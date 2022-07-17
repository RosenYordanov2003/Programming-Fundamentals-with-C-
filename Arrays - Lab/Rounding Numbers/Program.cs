using System;
using System.Linq;

namespace Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arrayFromNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < arrayFromNumbers.Length; i++)
            {
                double currentNumber = arrayFromNumbers[i];
                int result = 0;
                if (currentNumber >= 0)
                {
                    result = (int)(currentNumber + 0.5);
                }
                else
                {
                    result = (int)(currentNumber - 0.5);
                }
                Console.WriteLine($"{currentNumber} => {result}");
            }
        }
    }
}
