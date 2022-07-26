using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 we will receive sequence of int separated by space-done
            //2 we will receive index which we have to remove from our list-done
            //3 we have to increase all element with the value from the removed element if they are less than him or equal to him--done
            //4 we have to decrease all elements which are bigger than removed element wit his value-done
            //5 if the given index is less than 0 we remove the first element and copy the last element to his place
            //6 if the index is greater than the last element index we remove the last element and copy the first element on his place
            //7 the program end when there is no more element and we have to print the values of all removed elements
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> removedItems = new List<int>();
            int removedItem = 0;
            while (numbers.Count > 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());
                if (indexToRemove < 0)
                {
                    removedItems.Add(numbers[0]);
                    removedItem=numbers[0];
                    numbers.RemoveAt(0);
                    int lastElement = numbers.Last();
                    numbers.Insert(0, lastElement);
                }
                else if (indexToRemove >= numbers.Count)
                {
                    removedItems.Add(numbers[numbers.Count-1]);
                    removedItem=numbers[numbers.Count-1];
                    numbers.RemoveAt(numbers.Count - 1);
                    int firstElement = numbers.First();
                    numbers.Insert(numbers.Count, firstElement);
                }
                else if (indexToRemove>=0&&indexToRemove<numbers.Count)
                {
                    removedItems.Add(numbers[indexToRemove]);
                    removedItem = numbers[indexToRemove];
                    numbers.RemoveAt(indexToRemove);
                }
                NumbersOperation(numbers, removedItem);
            }
            Console.WriteLine(removedItems.Sum());
        }
        static void NumbersOperation(List<int> numbers, int removedItem)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= removedItem)
                {
                    numbers[i] += removedItem;
                }
                else
                {
                    numbers[i] -= removedItem;
                }
            }
        }
    }
}
