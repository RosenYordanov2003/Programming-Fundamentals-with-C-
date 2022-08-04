using System;
using System.Text;

namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int bombPower = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];
                if (currentLetter == '>')
                {
                    result.Append(currentLetter);
                    char bomb = text[i + 1];
                    bombPower+= (int)(bomb) - 48;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        result.Append(currentLetter);
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
