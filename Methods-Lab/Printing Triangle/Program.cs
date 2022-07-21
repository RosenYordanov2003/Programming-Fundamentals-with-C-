using System;

namespace Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                PrintUpperPart(1, i);
            }
            for (int down = n-1; down > 0; down--)
            {
                PrintDownPart(1, down);
            }
        }

        static void PrintDownPart(int start, int end)
        {
            for (int i = start; i <=end ; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void PrintUpperPart(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
