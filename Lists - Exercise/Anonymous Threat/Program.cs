using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] toekns = command.Split(" ");
                string operation = toekns[0];
                if (operation == "merge")
                {
                    int startIndex = int.Parse(toekns[1]);
                    int endIndex = int.Parse(toekns[2]);
                    if (startIndex < 0 || startIndex > input.Count)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > input.Count - 1 || endIndex < 0)
                    {
                        endIndex = input.Count - 1;
                    }
                    Merge(input, startIndex, endIndex);
                }
                else if (operation == "divide")
                {
                    int indexToDivide = int.Parse(toekns[1]);
                    int countParts = int.Parse(toekns[2]);
                    Divide(input, indexToDivide, countParts);
                }
            }
            foreach (var item in input)
            {
                Console.Write($"{item} ");
            }

        }

        static void Divide(List<string> input, int indexToDivide, int countParts)
        {
            List<string> dividedList = new List<string>();
            string wordToDivie=input[indexToDivide];
            input.RemoveAt(indexToDivide);
            int parts = wordToDivie.Length / countParts;
            for (int i = 0; i < countParts; i++)
            {
                if (i==countParts-1)
                {
                    dividedList.Add(wordToDivie.Substring(i*parts));
                }
                else
                {
                    dividedList.Add(wordToDivie.Substring(i*parts,parts));
                }
            }
            input.InsertRange(indexToDivide,dividedList);
        }

        static void Merge(List<string> input, int startIndex, int endIndex)
        {
            StringBuilder result = new StringBuilder();
            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Append(input[i]);
            }
            input.RemoveRange(startIndex, endIndex - startIndex + 1);
            input.Insert(startIndex, result.ToString());
        }
    }
}