using System;
using System.Linq;
using System.Collections.Generic;
namespace Associative_Arrays___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string word=Console.ReadLine();
            Dictionary<char,int>dictonary=new Dictionary<char,int>();
            for (int i = 0; i <word.Length ; i++)
            {
                char currentLetter=word[i];
                if (currentLetter==' ')
                {
                    continue;
                }
                if (dictonary.ContainsKey(currentLetter))
                {
                    dictonary[currentLetter]++;
                }
                else
                {
                    dictonary.Add(currentLetter,1);
                }
            }
            foreach (KeyValuePair<char,int> item in dictonary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
