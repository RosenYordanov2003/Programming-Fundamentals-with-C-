using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "end")
            {
                List<string> splitComand = comand.Split(' ').ToList();
                string operation = splitComand[0];
                if (operation == "Add")
                {
                    int number = int.Parse(splitComand[1]);
                    numbers.Add(number);
                }
                else if (operation == "Remove")
                {
                    int numberToRemove = int.Parse(splitComand[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (operation == "RemoveAt")
                {
                    int indexToRemove = int.Parse(splitComand[1]);
                    numbers.RemoveAt(indexToRemove);
                }
                else if (operation == "Insert")
                {
                    int numberToInsert = int.Parse(splitComand[1]);
                    int indexToInsert = int.Parse(splitComand[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
            }
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
