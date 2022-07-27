using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string text = Console.ReadLine();
            char[] letter = text.ToCharArray();
            List<char> letters = AddLetters(text, letter);
            List<char> message = new List<char>();
            int sum = 0;
            while (numbers.Count > 0)
            {
                int currentNumber = numbers[0];
                while (currentNumber > 0)
                {
                    int digit = currentNumber % 10;
                    sum += digit;
                    currentNumber /= 10;
                }
                numbers.RemoveAt(0);
                int index = sum;
                if (index > letters.Count)
                {
                    int diff = sum - letters.Count;
                    char indexToGet = letters[0 + diff];
                    message.Add(indexToGet);
                    letters.RemoveAt(diff);
                    diff = 0;
                    sum = 0;
                }
                else
                {
                    char indexToGet = letters[sum];
                    int indexToRemove = sum;
                    message.Add(indexToGet);
                    letters.RemoveAt(indexToRemove);
                    sum = 0;
                }
            }
            foreach (char item in message)
            {
                Console.Write($"{item}");
            }
        }

        static List<char> AddLetters(string text, char[] letter)
        {
            List<char> letters = new List<char>();
            for (int i = 0; i < letter.Length; i++)
            {
                letters.Add(letter[i]);
            }
            return letters;
        }
    }
}
