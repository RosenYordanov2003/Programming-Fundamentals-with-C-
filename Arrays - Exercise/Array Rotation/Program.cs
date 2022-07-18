using System;
using System.Linq;

namespace Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int firstElement = numbers[0];
                for (int z = 0; z < numbers.Length - 1; z++)
                {
                    numbers[z] = numbers[z + 1];
                }
                numbers[numbers.Length - 1] = firstElement;
            }
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
