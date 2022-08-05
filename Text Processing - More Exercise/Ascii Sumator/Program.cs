using System;

namespace Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (currentChar>firstChar&&currentChar< secondChar)
                {
                    sum += currentChar;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
