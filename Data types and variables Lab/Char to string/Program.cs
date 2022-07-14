using System;

namespace Char_to_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word =string.Empty;
            for (int i = 1; i <=3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                word += symbol;
            }
            foreach (var item in word)
            {
                Console.Write(item);
            }
        }
    }
}
