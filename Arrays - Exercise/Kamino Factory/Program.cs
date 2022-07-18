using System;
using System.Linq;

namespace Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] theBestSequence = new int[lenght];
            int[] currentSequence = new int[lenght];
            string command = string.Empty;
            int sample = 0;
            int currentTheBestCounter = 0;
            int sum = 0;
            int maxSum = 0;
            int maxIndex = 0;
            int maxSequence = 0;
            int theBestSample = 0;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int counterSequence = 0;
                int currentIndex = -1;
                bool isTheBestSequence = false;
                currentSequence = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                sample++;
                currentTheBestCounter = 0;
                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    int firstNumber = currentSequence[i];
                    int secondNumber = currentSequence[i + 1];
                    if (firstNumber == 1 && secondNumber == 1)
                    {
                        counterSequence++;
                        if (counterSequence >= currentTheBestCounter)
                        {
                            currentIndex = i - counterSequence + 1;
                            currentTheBestCounter = counterSequence;
                            counterSequence = 0;
                        }
                    }
                }
                sum = currentSequence.Sum();
                if (currentTheBestCounter > maxSequence)
                {
                    isTheBestSequence = true;
                }
                else if (currentTheBestCounter == maxSequence)
                {
                    if (currentIndex < maxIndex)
                    {
                        isTheBestSequence = true;
                    }
                    else if (currentTheBestCounter == maxSequence && currentIndex == maxIndex)
                    {
                        if (sum > maxSum)
                        {
                            isTheBestSequence = true;
                        }
                    }
                }
                if (isTheBestSequence == true)
                {
                    maxSequence = currentTheBestCounter;
                    maxSum = sum;
                    maxIndex = currentIndex;
                    theBestSample = sample;
                    theBestSequence = currentSequence;
                }
            }
            Console.WriteLine($"Best DNA sample {theBestSample} with sum: {maxSum}.");
            foreach (var item in theBestSequence)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
