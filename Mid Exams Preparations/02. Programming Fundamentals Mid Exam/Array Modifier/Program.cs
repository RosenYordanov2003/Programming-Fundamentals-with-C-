using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(" ").ToArray();
                string operation = tokens[0];
                if (operation == "swap")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);
                    SwapIndex(numbers, index1, index2);
                }
                else if (operation == "multiply")
                {
                    int indexToMultiply = int.Parse(tokens[1]);
                    int secondIndexToMultiply = int.Parse(tokens[2]);
                    MultiplyMethod(numbers, indexToMultiply, secondIndexToMultiply);
                }
                else if (operation == "decrease")
                {
                    DecreaseElements(numbers);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        static void DecreaseElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        static void MultiplyMethod(List<int> numbers, int indexToMultiply, int secondIndexToMultiply)
        {
            numbers[indexToMultiply] = numbers[indexToMultiply] * numbers[secondIndexToMultiply];
        }

        static void SwapIndex(List<int> numbers, int index1, int index2)
        {
            int tempFirstIndex = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = tempFirstIndex;
        }
    }
}
