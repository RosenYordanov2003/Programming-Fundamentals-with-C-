using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string comand = string.Empty;
            while ((comand=Console.ReadLine())!="end")
            {
                List<string>operations=comand.Split(' ').ToList();
                string operationType=operations[0];
                if (operationType=="Delete")
                {
                    int elementToDelete = int.Parse(operations[1]);
                    numbers.RemoveAll(x=>x==elementToDelete);
                }
                else if (operationType == "Insert")
                {
                    int elemetnToInsert=int.Parse(operations[1]);
                    int indexToInsert=int.Parse(operations[2]);
                    numbers.Insert(indexToInsert,elemetnToInsert);
                }
            }
            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
