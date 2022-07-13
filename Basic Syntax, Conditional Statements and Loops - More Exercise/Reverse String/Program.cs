using System;

namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse += text[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
