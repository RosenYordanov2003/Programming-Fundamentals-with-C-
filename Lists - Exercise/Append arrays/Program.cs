using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numberAsString = Console.ReadLine().Split('|').ToList();
            numberAsString.Reverse();
            List<string> number = new List<string>();
            for (int i = 0; i <numberAsString.Count; i++)
            {
                List<string>text = numberAsString[i].Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int z = 0; z <text.Count ; z++)
                {
                    Console.Write($"{text[z]} ");
                }
            }
          
        }
    }
}
