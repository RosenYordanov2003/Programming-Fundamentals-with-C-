using System;
using System.Text;

namespace Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToRepeat = Console.ReadLine();
            int timesToRepeat = int.Parse(Console.ReadLine());
            string result = Repeat_String(stringToRepeat, timesToRepeat);
            Console.WriteLine(result);
        }

        static string Repeat_String(string stringToRepeat, int timesToRepeat)
        {
            StringBuilder textToAppend = new StringBuilder();
            for (int i = 1; i <=timesToRepeat ; i++)
            {
                textToAppend.Append(stringToRepeat);
            }
            return textToAppend.ToString();
        }
    }
}
