using System;

namespace Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int[] passengers = new int[n];
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    passengers[i] = int.Parse(Console.ReadLine());
                    sum += passengers[i];
                }
                foreach (var item in passengers)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                Console.WriteLine(sum);

            }
        }
    }
}
