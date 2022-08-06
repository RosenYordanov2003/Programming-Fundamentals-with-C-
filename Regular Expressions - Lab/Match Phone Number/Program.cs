using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbersPatern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string posiblesPhoneNumbers=Console.ReadLine();
            MatchCollection matches = Regex.Matches(posiblesPhoneNumbers, phoneNumbersPatern);
            List<string>phoneNumbers=new List<string>();
            foreach (Match match in matches)
            {
                phoneNumbers.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ",phoneNumbers));
        }
    }
}
