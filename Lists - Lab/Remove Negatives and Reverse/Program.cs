using System;
using System.Collections.Generic;
using System.Linq;

namespace Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.RemoveAll(x => x < 0);
            if (numbers.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    int old = numbers[i];
                    numbers[i] = numbers[numbers.Count - 1 - i];
                    numbers[numbers.Count - 1 - i] = old;
                }
            }
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
