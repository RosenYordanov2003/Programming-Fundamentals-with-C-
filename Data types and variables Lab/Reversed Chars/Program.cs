using System;

namespace Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reverseWord=string.Empty;
            string converter = string.Empty;
            for (int i = 1; i <=3 ; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                 converter+=letter.ToString();
            }
            for (int reverse = converter.Length-1; reverse >=0; reverse--)
            {
                reverseWord+=converter[reverse];
            }
            foreach (var item in reverseWord)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
