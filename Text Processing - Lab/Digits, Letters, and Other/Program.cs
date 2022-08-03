using System;
using System.Text;
using System.Linq;
namespace Digits__Letters__and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();
            string text=Console.ReadLine();
            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }
                else
                {
                    others.Append(symbol);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
