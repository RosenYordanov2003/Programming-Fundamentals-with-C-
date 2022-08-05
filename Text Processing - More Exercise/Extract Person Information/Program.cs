using System;

namespace Text_Processing___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();
                int personNameStartIndex = text.IndexOf("@");
                int personNameEndIndex = text.LastIndexOf("|");
                string personName = text.Substring(personNameStartIndex+1, personNameEndIndex - personNameStartIndex-1);
                int agesStartIndex= text.IndexOf("#");
                int agesEndIndex= text.LastIndexOf("*");
                string ages = text.Substring(agesStartIndex+1, agesEndIndex - agesStartIndex-1);
                Console.WriteLine($"{personName} is {ages} years old.");
            }
        }
    }
}
