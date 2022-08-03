using System;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text=Console.ReadLine();
            int indexWordToRemove = 0;
            while (true)
            {
                indexWordToRemove = text.IndexOf(wordToRemove);
                if (indexWordToRemove < 0)
                {
                    break;
                }
                text=text.Remove(indexWordToRemove,wordToRemove.Length);
            }
            Console.WriteLine(text);
        }
    }
}
