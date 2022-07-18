using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxSequence = 0;
            int currentSequence = 0;
            int winnerNumber = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int firstNum = numbers[i];
                int secondNum = numbers[i + 1];
                if (firstNum == secondNum)
                {
                    currentSequence++;
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        winnerNumber = firstNum;
                    }
                }
                else
                {
                    currentSequence = 0;
                }
            }
            for (int i = 0; i <= maxSequence; i++)
            {
                Console.Write($"{winnerNumber} ");
            }
        }
    }
}
