using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\@|\#{1})(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1";
            Regex regexWords = new Regex(pattern);
            MatchCollection matches = regexWords.Matches(input);
            List<string> mirrorWords = new List<string>();
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                foreach (Match pairs in matches)
                {
                    string firstWord = pairs.Groups["firstWord"].Value;
                    string secondWord = pairs.Groups["secondWord"].Value;
                    FindMirrorPairs(firstWord, secondWord, mirrorWords);
                }
                if (mirrorWords.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine($"The mirror words are:\n{string.Join(", ", mirrorWords)}");
                }
            }
        }
        static void FindMirrorPairs(string firstWord, string secondWord, List<string> mirrorWords)
        {
            char[] array = secondWord.ToCharArray();
            string secondWordReversed = $"{string.Join("", array.Reverse())}";
            if (secondWordReversed == firstWord)
            {
                string result = $"{firstWord} <=> {secondWord}";
                mirrorWords.Add(result);
            }
        }
    }
}
