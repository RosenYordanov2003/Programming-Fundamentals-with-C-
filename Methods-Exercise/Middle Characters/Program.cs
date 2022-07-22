using System;

namespace Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text.Length % 2 == 0)
            {
                FindMiddleCharacters(text);
            }
            else
            {
                Console.WriteLine(text[text.Length/2]);
            }
        }

        static void FindMiddleCharacters(string text)
        {
            string result = string.Empty;
            int firstCharIndex = text.Length / 2;
            int secondCharIndex = firstCharIndex-1;
            for (int i = 0; i < text.Length; i++)
            {
                if (i == firstCharIndex)
                {
                    result += text[i];
                }
                if (i == secondCharIndex)
                {
                    result += text[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
