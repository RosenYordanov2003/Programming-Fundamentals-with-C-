using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"\@\#+\b(?<barcode>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})\b\@\#+";
            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();
                Regex regex = new Regex(pattern);
                Match match = regex.Match(text);
                if (match.Success)
                {
                    string result = match.Groups["barcode"].Value;
                    FindProductGroup(result);
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }

        static void FindProductGroup(string result)
        {
            int counter = 0;
            StringBuilder sb = new StringBuilder();
            foreach (char symbol in result)
            {
                if (char.IsDigit(symbol))
                {
                    sb.Append(symbol);
                    counter++;
                }
            }
            if (counter==0)
            {
                Console.WriteLine("Product group: 00");
            }
            else
            {
                Console.WriteLine($"Product group: {sb.ToString()}");
            }
        }
    }
}
