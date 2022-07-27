using System;
using System.Collections.Generic;
using System.Linq;

namespace Mixed_Up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> remaingNumbers = FindRemainingNumbers(firstList, secondList);
            Console.WriteLine();
            List<int>mixedList=new List<int>();
            while (firstList.Count>0&&secondList.Count>0)
            {
                mixedList.Add(firstList[0]);
                mixedList.Add(secondList[secondList.Count-1]);
                firstList.RemoveAt(0);
                secondList.RemoveAt(secondList.Count-1);
            }
            List<int> finalResult = FindElements(mixedList, remaingNumbers);
            finalResult.Sort();
           Console.WriteLine(String.Join(" ",finalResult));
        }
        static List<int> FindElements(List<int> mixedList, List<int> remaingNumbers)
        {
           List<int>FinalResult=new List<int>();
            int firstRemaining = remaingNumbers[0];
            int secondRemaining = remaingNumbers[1];
            FinalResult = mixedList.FindAll(x => x > firstRemaining && x < secondRemaining||x>secondRemaining&&x<firstRemaining);
            return FinalResult;
        }

        static List<int> FindRemainingNumbers(List<int> firstList, List<int> secondList)
        {
            List<int>remaining=new List<int>();
            int count = 0;
            if (firstList.Count>secondList.Count)
            {
                for (int i = firstList.Count-1; i >=firstList.Count-2; i--)
                {
                    remaining.Add(firstList[i]);
                }
                for (int i = firstList.Count - 1; i >= firstList.Count - 2; i--)
                {
                    int currentNumber=firstList[i];
                    firstList.Remove(currentNumber);
                    count++;
                    if (count==2)
                    {
                        count = 0;
                        break;
                    }
                }
                return remaining;
            }
            else
            {   
                secondList.Reverse();
                for (int i = secondList.Count-1; i >= secondList.Count-2; i--)
                {
                    remaining.Add(secondList[i]);
                }
                for (int i = secondList.Count - 1; i >= secondList.Count - 2; i--)
                {
                    int currentNumber = secondList[i];
                    secondList.Remove(currentNumber);
                    i--;
                    count++;
                    if (count==2)
                    {
                        break;
                    }
                }
                secondList.Reverse();
                return remaining;
            }
            
        }
    }
}
