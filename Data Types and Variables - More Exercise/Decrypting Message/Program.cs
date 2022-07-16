using System;

namespace Decrypting_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string word=string.Empty;
            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int letterToInt=(int)(letter);
                int result = letterToInt + key;
                char messege = (char)(result);
                word+= messege.ToString();
            }
            Console.WriteLine($"{word}");
        }
    }
}
