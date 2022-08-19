using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"(\:{2}|\*{2})(?<emojies>[A-Z]{1}[a-z]{2,})\1";
            decimal sum = 1m;
            List<string> emojies = new List<string>();

            string input = Console.ReadLine();

            Regex regex = new Regex(emojiPattern);

            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                emojies.Add(match.Value);
            }
            string digitPatern = @"[0-9]";

            Regex digit = new Regex(digitPatern);
            List<string> coolEmojis = new List<string>();
            MatchCollection digitMatch = digit.Matches(input);
            sum = FindSum(digitMatch);
            FindCoolEmojies(sum, coolEmojis,emojies);
            PrintResult(emojies, coolEmojis, sum);
        }

        private static void PrintResult(List<string> emojis, List<string> coolEmojis, decimal sum)
        {
            Console.WriteLine($"Cool threshold: {sum}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are: ");
            foreach (string coolEmoji in coolEmojis)
            {
                Console.WriteLine(coolEmoji);
            }
        }

        static void FindCoolEmojies(decimal sum, List<string> coolEmojies, List<string> emojis)
        {
            foreach (string emoji in emojis)
            {
                int emojiSum = 0;
                for(int i = 0; i < emoji.Length; i++)
                {
                    if (char.IsLetter(emoji[i]))
                    {
                        int currentEmojiValue = (int)emoji[i];
                        emojiSum += currentEmojiValue;
                    }
                }
                if (emojiSum>=sum)
                {
                    coolEmojies.Add(emoji);
                }
            }
        }

        private static decimal FindSum(MatchCollection digitMatch)
        {
            decimal sum = 1;
            foreach (Match digits in digitMatch)
            {
                sum *= decimal.Parse(digits.Value);
            }
            return sum;
        }
    }
}
