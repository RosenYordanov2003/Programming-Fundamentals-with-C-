using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b";
            string text = Console.ReadLine();
            MatchCollection matches = Regex.Matches(text, patern);
            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}
