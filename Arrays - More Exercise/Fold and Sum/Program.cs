using System;
using System.Collections.Generic;
using System.Linq;

namespace Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int[]numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstKNumbers=new int[numbers.Length/4];
            int[] middElements = new int[firstKNumbers.Length * 2];
            int[]lastNums=new int[numbers.Length/4];
          List<int>lastKNumbers=new List<int>();
            for (int i = 0; i <firstKNumbers.Length ; i++)
            {
               firstKNumbers[i] =numbers[i];
            }
            List<int>midEl=new List<int>();
            for (int i = 0; i <middElements.Length ; i++)
            {
                middElements[i] = numbers[i+firstKNumbers.Length];
                midEl.Add(middElements[i]);
            }
            for (int i = numbers.Length-1; i >lastNums.Length; i--)
            {
                lastKNumbers.Add(numbers[i]);
                if (lastKNumbers.Count==lastNums.Length)
                {
                    break;
                }
            }           
            List<int>numsFromLeftAndRight=new List<int>();
            for (int left = firstKNumbers.Length-1; left >=0; left--)
            {
                numsFromLeftAndRight.Add(firstKNumbers[left]);
            }
         
            for (int right =0; right <lastKNumbers.Count ; right++)
            {
                int currentNumber=lastKNumbers[right];
                numsFromLeftAndRight.Add(lastKNumbers[right]);
            }
            List<int>result=new List<int>();
            for (int r = 0; r <numsFromLeftAndRight.Count ; r++)
            {
                result.Add(numsFromLeftAndRight[r] + midEl[r]);            
            }
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
