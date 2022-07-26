using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int>numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string comand = string.Empty;
            while ((comand=Console.ReadLine())!="End")
            {
                
                List<string> comandSplit = comand.Split(' ').ToList();
                string operation = comandSplit[0];
                if (operation=="Add")
                {
                    int numberToAdd = int.Parse(comandSplit[1]);
                    numbers.Add(numberToAdd);
                }
                else if (operation == "Insert")
                {
                    int numberToInsert= int.Parse(comandSplit[1]);
                    int indexToInsert= int.Parse(comandSplit[2]);
                    if (indexToInsert>=0&&indexToInsert<numbers.Count)
                    {
                        numbers.Insert(indexToInsert, numberToInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (operation=="Remove")
                {
                    int indexToRemove = int.Parse(comandSplit[1]);
                    if (indexToRemove>=0&&indexToRemove<numbers.Count)
                    {
                        numbers.RemoveAt(indexToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (comand.Contains("Shift left "))
                {
                    int countToShift = int.Parse(comandSplit[2]);
                    for (int i = 0; i < countToShift; i++)
                    {
                        int firstNumber = numbers[0];
                        for (int z = 0; z <numbers.Count-1 ; z++)
                        {
                            numbers[z] = numbers[z + 1];
                        }
                        numbers[numbers.Count-1] = firstNumber;
                    }
                }
                else if (comand.Contains("Shift right"))
                {
                    int numberToShift = int.Parse(comandSplit[2]);
                    for (int i = 0; i < numberToShift; i++)
                    {
                        int lastIndex = numbers.Count - 1;
                        int lastElement = numbers[numbers.Count - 1];
                        for (int z = 0; z < numbers.Count - 1; z++)
                        {
                            if (z > 0)
                            {
                                numbers[numbers.Count - 1] = numbers[numbers.Count - 1 - z];
                            }
                        }
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastElement);
                    }
                }
            }
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }

    }
}
