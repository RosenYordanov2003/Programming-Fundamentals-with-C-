using System;
using System.Linq;

namespace Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random position = new Random();
            string[] words = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                int randomPosition=position.Next(0,words.Length);
                string randomWord=words[randomPosition];
                string currentWord = words[i];
                words[randomPosition]=currentWord;
                words[i]=randomWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
