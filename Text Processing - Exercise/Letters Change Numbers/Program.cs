using System;
using System.Linq;

namespace Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0m;
            for ( int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                sum += FindSum(currentWord);
            }
            Console.WriteLine($"{sum:f2}");
        }
        static decimal FindSum(string currentWord)
        {
            decimal sum = 0m;
            char firstLetter = currentWord[0];
            char lastLetter = currentWord[currentWord.Length - 1];
            int number = int.Parse(currentWord.Substring(1, currentWord.Length - 2));
            int firstLetterPosition = FindLettersPositions(firstLetter);
            int lastLetterPosition= FindLettersPositions(lastLetter);
            if (char.IsUpper(firstLetter))
            {
               sum+= (decimal) number / firstLetterPosition;
            }
            else
            {
                sum += (decimal)number * firstLetterPosition;
            }
            if (char.IsLower(lastLetter))
            {
                sum += lastLetterPosition;
            }
            else
            {
                sum -=  lastLetterPosition;
            }
            return sum;
        }

        static int FindLettersPositions(char letter)
        {
            int characterPosition = 0;
            if (char.IsLetter(letter))
            {
                if (char.IsUpper(letter))
                {
                     characterPosition = (int)(letter)-64;
                }
                else
                {
                    characterPosition = (int)(letter) - 96;
                }
            }
            return characterPosition;
        }
    }
}
