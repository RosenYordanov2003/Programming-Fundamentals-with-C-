using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int biggerList = Math.Max(firstList.Count, secondList.Count);
            for (int i = 0; i < biggerList; i++)
            {
                if (i < firstList.Count)
                {
                    result.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
