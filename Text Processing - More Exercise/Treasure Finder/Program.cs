using System;
using System.Linq;
using System.Text;

namespace Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(numbeer => int.Parse(numbeer)).ToArray();
            StringBuilder result = new StringBuilder();
            string commad;
            while ((commad = Console.ReadLine()) != "find")
            {
                int counter = 0;
                int index = 0;
                while (counter < commad.Length)
                {
                    for (int i = 0; i < commad.Length; i++)
                    {
                        char currentChar = commad[i];
                        int charSum = (int)currentChar;
                        if (index >= keys.Length)
                        {
                            index = 0;
                        }
                        charSum -= keys[index];
                        result.Append((char)charSum);
                        counter++;
                        index++;
                    }
                }
                PrintResult(result);
                result.Clear();
            }
        }

        static void PrintResult(StringBuilder result)
        {
            string message=result.ToString();
            int start = message.IndexOf("&");
            int endIndex=message.LastIndexOf("&");
            string type = message.Substring(start + 1, endIndex - start -1);
            int startCoridnateIndex = message.IndexOf("<");
            int endIndexCordinate=message.LastIndexOf(">");
            string cordinates = message.Substring(startCoridnateIndex + 1, endIndexCordinate - startCoridnateIndex - 1);
            Console.WriteLine($"Found {type} at {cordinates}");
        }
    }
}