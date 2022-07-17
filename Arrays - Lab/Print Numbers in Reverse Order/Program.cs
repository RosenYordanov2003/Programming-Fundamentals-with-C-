using System;

namespace Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;

            }
            for (int z = numbers.Length - 1; z >= 0; z--)
            {
                Console.Write($"{numbers[z]} ");
            }
        }
    }
}
