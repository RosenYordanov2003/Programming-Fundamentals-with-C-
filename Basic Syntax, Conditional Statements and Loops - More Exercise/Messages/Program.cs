using System;

namespace Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string digit = Console.ReadLine();
                int digitLength = digit.Length;
                int digitToInt = int.Parse(digit[0].ToString());
                int offset = (digitToInt - 2) * 3;
                if (digitToInt == 0)
                {
                    message += " ";
                    continue;
                }
                if (digitToInt == 8 || digitToInt == 9)
                {
                    offset++;
                }
                int digitLetterIndex = offset + digitLength - 1;
                message += (char)(digitLetterIndex + 97);
            }
            Console.WriteLine(message);
        }
    }
}
