using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace tested
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToUpper();
            StringBuilder finalTextResult = new StringBuilder();
            while (input.Length > 0)
            {
                string resultAfterOneIteration = FindSubstring(ref input);
                finalTextResult.Append(resultAfterOneIteration);
            }
           char[]array=finalTextResult.ToString().Distinct().ToArray();
            Console.WriteLine($"Unique symbols used: {array.Length}");
            Console.WriteLine(finalTextResult);
        }
        static string FindSubstring(ref string input)
        {
            StringBuilder result = new StringBuilder();
            int currentDigit = 0;
            string pattern = @"(?<numbers>\d+)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            currentDigit = int.Parse(match.Groups["numbers"].Value);
            int digitIndex = input.IndexOf(match.ToString());
            string currentText = input.Substring(0, digitIndex);
            string digitLenght = currentDigit.ToString();
            if (digitLenght.Length == 1)
            {
                input = input.Remove(0, digitIndex + 1);
            }
            else
            {
                input = input.Remove(0, digitIndex + 2);
            }
            for (int i = 1; i <= currentDigit; i++)
            {
                result.Append(currentText);
            }
            return result.ToString();
        }
    }
}
