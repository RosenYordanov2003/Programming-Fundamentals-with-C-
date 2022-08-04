using System;
using System.Linq;

namespace Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long totalSum = 0;
            for (int i = 0; i < words.Length - 1; i++)
            {
                totalSum += SumCharacters(words[i], words[i + 1]);
            }
            Console.WriteLine(totalSum);
        }
        static long SumCharacters(string firstWord, string secondWord)
        {
            int firstSum = 0;
            long sum = 0;
            int secondSum = 0;
            int maxLenght = Math.Max(firstWord.Length, secondWord.Length);
            for (int i = 0; i < maxLenght; i++)
            {
                if (i < firstWord.Length && i < secondWord.Length)
                {
                    firstSum = (int)(firstWord[i]);
                    secondSum = (int)(secondWord[i]);
                    sum += firstSum * secondSum;
                }
                else if (i >= firstWord.Length)
                {
                    secondSum = (int)(secondWord[i]);
                    sum += secondSum;
                }
                else if(i>=secondWord.Length)
                {
                    firstSum = (int)(firstWord[i]);
                    sum += firstSum;
                }
            }
            return sum;
        }
    }
}
