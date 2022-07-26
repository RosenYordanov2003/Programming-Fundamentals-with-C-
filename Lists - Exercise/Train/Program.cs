using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>numbers= Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string comand = string.Empty;
            int people = 0;
            int capacity =int.Parse(Console.ReadLine());
            while ((comand=Console.ReadLine())!="end")
            {
                List <string>operations = comand.Split(' ').ToList();
                string operation=operations[0];
                if (operation=="Add")
                {
                    int wagon = int.Parse(operations[1]);
                    numbers.Add(wagon);
                }
                else
                {
                  people = int.Parse(operations[0]);
                    for (int i = 0; i <numbers.Count; i++)
                    {
                        if (capacity-numbers[i]>=people)
                        {
                            int currentNumber=numbers[i];
                            currentNumber+= people;
                            break;
                        }
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
