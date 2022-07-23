using System;
using System.Collections.Generic;

namespace Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> tribonaciNumbers = new List<long>(3)
          {
              1,1,2
          };
            int index = 0;
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("0");
            }
            else if (n == 1)
            {
                Console.WriteLine("1");
            }
            else if (n == 2)
            {
                Console.WriteLine("1 1");
            }
            else if (n == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                for (int i = tribonaciNumbers.Count; i < n; i++)
                {
                    long result = tribonaciNumbers[0 + index] + tribonaciNumbers[1 + index] + tribonaciNumbers[2 + index];
                    tribonaciNumbers.Add(result);
                    index++;
                }
                Console.Write(string.Join(" ", tribonaciNumbers));
            }
        }
    }
}
