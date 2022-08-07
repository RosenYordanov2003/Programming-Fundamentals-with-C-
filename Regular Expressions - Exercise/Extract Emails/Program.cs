using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patern = @"\s\b(?<userName>[A-Za-z\d]+([-._][A-Za-z\d]+)*)[@][A-Za-z]+([-][A-Za-z]+)*([.][A-Za-z]+([-][A-Za-z]+)*)+";
            Regex regex=new Regex(patern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(String.Join("\n",match));
            }
        }
    }
}
