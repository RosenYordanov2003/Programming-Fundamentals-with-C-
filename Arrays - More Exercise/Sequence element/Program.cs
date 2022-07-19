using System;
using System.Linq;

namespace Sequence_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[]numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isFind = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                for (int left = 0; left <i; left++)
                {
                    leftSum+=numbers[left];
                }
                int rightSum = 0;
                for (int right = numbers.Length-1; right >i; right--)
                {
                    rightSum += numbers[right];
                }
                if (leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    isFind = true;
                    break;
                }
            }
            if (!isFind)
            {
                Console.WriteLine("no");
            }
        }
    }
}
