using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string comand = string.Empty;
            int counterChanges = 0;
            while ((comand = Console.ReadLine()) != "end")
            {
                List<string> splitComand = comand.Split(' ').ToList();
                string operation = splitComand[0];
                if (operation == "Contains")
                {
                    int numberToCheck = int.Parse(splitComand[1]);
                    if (numbers.Contains(numberToCheck))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (operation == "PrintEven")
                {
                    PrintEvenNumbers(numbers);
                    Console.WriteLine();
                }
                else if (operation == "Add")
                {
                    int number = int.Parse(splitComand[1]);
                    numbers.Add(number);
                    counterChanges++;
                }
                else if (operation == "Remove")
                {
                    int numberToRemove = int.Parse(splitComand[1]);
                    numbers.Remove(numberToRemove);
                    counterChanges++;
                }
                else if (operation == "RemoveAt")
                {
                    int indexToRemove = int.Parse(splitComand[1]);
                    numbers.RemoveAt(indexToRemove);
                    counterChanges++;
                }
                else if (operation == "Insert")
                {
                    int numberToInsert = int.Parse(splitComand[1]);
                    int indexToInsert = int.Parse(splitComand[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                    counterChanges++;
                }
                else if (operation == "PrintOdd")
                {
                    PrintOddNumbers(numbers);
                    Console.WriteLine();
                }
                else if (operation == "GetSum")
                {
                    int sum = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }
                    Console.WriteLine(sum);
                }
                else if (operation == "Filter")
                {
                    string condition = splitComand[1];
                    int numberToCondition = int.Parse(splitComand[2]);
                    PrintNumbersFromConditions(numbers, condition, numberToCondition);
                    Console.WriteLine();
                }
            }
            if (counterChanges > 0)
            {
                foreach (var item in numbers)
                {
                    Console.Write($"{item} ");
                }
            }
        }
        static void PrintEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();
            evenNumbers = numbers.FindAll(x => x % 2 == 0);
            foreach (int number in evenNumbers)
            {
                Console.Write($"{number} ");
            }
        }
        static void PrintOddNumbers(List<int> numbers)
        {
            List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
            foreach (var number in oddNumbers)
            {
                Console.Write($"{number} ");
            }
        }
        static void PrintNumbersFromConditions(List<int> numbers, string condition, int numberToCondition)
        {
            List<int> results = new List<int>();
            if (condition == "<")
            {
                results = numbers.FindAll(x => x < numberToCondition);
            }
            else if (condition == ">")
            {
                results = numbers.FindAll(x => x > numberToCondition);
            }
            else if (condition == ">=")
            {
                results = numbers.FindAll(x => x >= numberToCondition);
            }
            else if (condition == "<=")
            {
                results = numbers.FindAll(x => x <= numberToCondition);
            }
            foreach (var item in results)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
