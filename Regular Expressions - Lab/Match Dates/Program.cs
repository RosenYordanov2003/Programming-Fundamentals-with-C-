using System;
using System.Text.RegularExpressions;
namespace _3._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b(?<day>\d{2})(\/|-|.)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4}\b)";
            string text=Console.ReadLine();
            MatchCollection matches=Regex.Matches(text, patern);
            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
