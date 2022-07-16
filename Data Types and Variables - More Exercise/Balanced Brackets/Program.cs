using System;

namespace Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
           byte n = byte.Parse(Console.ReadLine());
            bool isValid = true;
            int openBracketCounter = 0;
            int closeBracketCounter = 0;
            int openBracket = 0;
            for (int i = 1; i <=n; i++)
            {
                string text = Console.ReadLine();
                bool isChar = char.TryParse(text, out char ch);
                if (text=="(")
                {
                    openBracketCounter++;
                    openBracket++;
                    if (openBracket>=2)
                    {
                        isValid = false;
                        break;
                    }
                }
                else if (text == ")")
                {
                  openBracket--;
                    closeBracketCounter++;
                    if (openBracket<0)
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            if (isValid == true&&openBracketCounter==closeBracketCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
