using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_more_exercise
{
    internal class Program
    {
        private static object names;

        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int totalNameSum = 0;
            List<int> sums = new List<int>(sum);
            for (int i = 0; i <n ; i++)
            {
               string names = Console.ReadLine();
                for (int z = 0; z < names.Length; z++)
                {
                    sum = 0;
                   char currentLtter = names[z];
                    if (currentLtter=='A'||currentLtter=='a'||currentLtter=='o' || currentLtter == 'O' || currentLtter == 'u' || currentLtter == 'U' || currentLtter == 'i' || currentLtter == 'I' || currentLtter == 'e' || currentLtter == 'E')
                    {
                         sum+=(int)(currentLtter);
                        sum *= names.Length;
                    }
                    else
                    {
                        sum += (int)(currentLtter);
                        sum/= names.Length;
                    }
                    totalNameSum += sum;
                }
                sums.Add(totalNameSum);
                totalNameSum = 0;
            }
            sums.Sort();
            foreach (var item in sums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
