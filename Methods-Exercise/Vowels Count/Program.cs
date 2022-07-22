using System;

namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string text = Console.ReadLine().ToLower();
            SearVowels(text);
        }

        static void SearVowels(string text)
        {
            int count = 0;
            foreach (char vowle in text)
            {
                if ("aouei".Contains(vowle))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
