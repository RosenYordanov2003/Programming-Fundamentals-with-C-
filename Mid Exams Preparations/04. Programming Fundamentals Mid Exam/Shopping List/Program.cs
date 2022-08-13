using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine().Split("!").ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] tokens = command.Split(" ");
                string operation = tokens[0];
                if (operation == "Urgent")
                {
                    string item = tokens[1];
                    if (initialList.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        UrgentMethod(item, initialList);
                    }
                }
                else if (operation == "Unnecessary")
                {
                    string item = tokens[1];
                    if (initialList.Contains(item))
                    {
                        UnnecessaryMethod(item, initialList);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (operation == "Correct")
                {
                    string oldItem = tokens[1];
                    string newItem = tokens[2];
                    if (initialList.Contains(oldItem))
                    {
                        CorrectMethod(oldItem, newItem, initialList);
                    }
                }
                else if (operation == "Rearrange")
                {
                    string item = tokens[1];
                    if (initialList.Contains(item))
                    {
                        RearrangeMethod(initialList, item);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", initialList));
        }

        static void RearrangeMethod(List<string> initialList, string item)
        {
            initialList.Remove(item);
            initialList.Insert(initialList.Count, item);
        }

        static void CorrectMethod(string oldItem, string newItem, List<string> initialList)
        {
            int oldItemIndex = initialList.IndexOf(oldItem);
            initialList.Remove(oldItem);
            initialList.Insert(oldItemIndex, newItem);
        }

        static void UnnecessaryMethod(string item, List<string> initialList)
        {
            initialList.Remove(item);
        }

        static void UrgentMethod(string item, List<string> initialList)
        {
            initialList.Insert(0, item);
        }
    }
}
