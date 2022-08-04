using System;
using System.Text;

namespace Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];
                char letterNewPosition = ChangePositionOnTheLetter(currentLetter);
                result.Append(letterNewPosition);
            }
            Console.WriteLine(result.ToString());
        }

        static char ChangePositionOnTheLetter(char currentLetter)
        {
            int result = (int)(currentLetter);
            result += 3;
            char newPosition = (char)(result);
            return newPosition;
        }
    }
}
