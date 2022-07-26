using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i <n ; i++)
            {
                string comand = Console.ReadLine();
                List<string>comandSplit = comand.Split(' ').ToList();
                string names = comandSplit[0];
                //if (guests.Contains(names)&&comand.Contains("is going!"))
                //{
                //    Console.WriteLine($"{names} is already in the list!");
                //}
                if (comand.Contains("is going!"))
                {
                    if (guests.Contains(names))
                    {
                        Console.WriteLine($"{names} is already in the list!");
                        continue;
                    }
                    guests.Add(names);
                }
                if (comand.Contains("is not going!"))
                {
                    if (guests.Contains(names))
                    {
                        guests.Remove(names);
                    }
                    else
                    {
                        Console.WriteLine($"{names} is not in the list!");
                    }
                }
            }
            foreach (var item in guests)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
