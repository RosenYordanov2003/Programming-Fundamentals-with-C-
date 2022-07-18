using System;
using System.Linq;

namespace Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zigZagArray = new int[n];
            int[] normalArray = new int[n];
            for (int index = 0; index < n; index++)
            {
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (index % 2 == 0)
                {
                    normalArray[index] = array[1];
                    zigZagArray[index] = array[0];
                }
                else
                {
                    normalArray[index] = array[0];
                    zigZagArray[index] = array[1];
                }
            }
            foreach (var item in zigZagArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in normalArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
