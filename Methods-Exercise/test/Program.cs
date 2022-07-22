using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "end")
            {
                List<string> comandArguments = comand.Split(' ').ToList();
                string operation = comandArguments[0];
                if (operation == "exchange")
                {
                    int[] exchangedArray = new int[array.Length];
                    int indexToStart = int.Parse(comandArguments[1]);
                    if (indexToStart >= 0 && indexToStart < array.Length)
                    {
                        ExchangeArray(indexToStart, array, exchangedArray);
                        array = exchangedArray;
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (operation == "max")
                {
                    string type = comandArguments[1];
                    FindMaxEvenOdd(array, type);
                }
                else if (operation == "min")
                {
                    string type = comandArguments[1];
                    FindMinEvenOdd(array, type);
                }
                else if (operation == "first")
                {
                    int count = int.Parse(comandArguments[1]);
                    string type = comandArguments[2];
                    if (count < 0 || count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        FindFirstEvenOdd(array, type, count);
                    }
                }
                else if (operation == "last")
                {
                    int count = int.Parse(comandArguments[1]);
                    string type = comandArguments[2];
                    if (count < 0 || count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        FindLastEvenOdd(array, type, count);
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        static void FindLastEvenOdd(int[] array, string type, int count)
        {
            List<int> FindLastEven =new List<int>();
            List<int>FindLastOdd=new List<int>();
            if (type=="even")
            {
                int secondCounter = 0;
                for(int i=array.Length-1; i>=0; i--)
                {
                    int currentNumber=array[i];
                    if (currentNumber % 2 == 0)
                    {
                        secondCounter++;
                        FindLastEven.Add(currentNumber);
                        if (secondCounter==count)
                        {
                            break;
                        }
                    }
                }
                if (secondCounter>0)
                {
                    Console.WriteLine($"[{string.Join(", ", FindLastEven)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                int secondCounter = 0;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    int currentNumber = array[i];
                    if (currentNumber % 2 != 0)
                    {
                        secondCounter++;
                        FindLastOdd.Add(currentNumber);
                        if (secondCounter == count)
                        {
                            break;
                        }
                    }
                }
                FindLastOdd.Reverse();
                if (secondCounter > 0)
                {
                    Console.WriteLine($"[{string.Join(", ", FindLastOdd)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void FindFirstEvenOdd(int[] array, string type, int count)
        {
            List<int> firstEven = new List<int>();
            List<int> firstOdd = new List<int>();
            if (type == "even")
            {
                int secondCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int currentNumber = array[i];
                    if (currentNumber % 2 == 0)
                    {
                        firstEven.Add(currentNumber);
                        secondCount++;
                        if (secondCount == count)
                        {
                            break;
                        }
                    }
                }
                if (secondCount > 0)
                {
                    Console.WriteLine($"[{string.Join(", ", firstEven)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else
            {
                int secondCount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int currentNumber = array[i];
                    if (currentNumber % 2 != 0)
                    {
                        firstOdd.Add(currentNumber);
                        secondCount++;
                        if (secondCount == count)
                        {
                            break;
                        }
                    }
                }
                if (secondCount > 0)
                {
                    Console.WriteLine($"[{string.Join(", ", firstOdd)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        private static void FindMinEvenOdd(int[] array, string type)
        {
            if (type == "even")
            {
                int evenCounter = 0;
                int evenMin = int.MaxValue;
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int currnentNumber = array[i];
                    if (currnentNumber % 2 == 0)
                    {
                        if (currnentNumber <= evenMin)
                        {
                            evenCounter++;
                            evenMin = currnentNumber;
                            result = i;
                        }
                    }
                }
                if (evenCounter == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                int oddCounter = 0;
                int oddMin = int.MaxValue;
                int result = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int currnentNumber = array[i];
                    if (currnentNumber % 2 != 0)
                    {
                        if (currnentNumber <= oddMin)
                        {
                            oddCounter++;
                            oddMin = currnentNumber;
                            result = i;
                        }
                    }
                }
                if (oddCounter == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }

        static void FindMaxEvenOdd(int[] array, string type)
        {
            if (type == "even")
            {
                int result = 0;
                int maxEven = int.MinValue;
                int evenCounter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int currentNumber = array[i];
                    if (currentNumber % 2 == 0)
                    {
                        if (currentNumber >= maxEven)
                        {
                            evenCounter++;
                            maxEven = currentNumber;
                            result = i;
                        }
                    }
                }
                if (evenCounter == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                int result = 0;
                int maxOdd = int.MinValue;
                int oddCounter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int currentNumber = array[i];
                    if (currentNumber % 2 != 0)
                    {
                        oddCounter++;
                        if (currentNumber >= maxOdd)
                        {
                            maxOdd = currentNumber;
                            result = i;
                        }
                    }
                }
                if (oddCounter == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }
        static void ExchangeArray(int indexToStart, int[] array, int[] exchangedArray)
        {
            int exchangeArrayIndex = 0;
            for (int i = indexToStart + 1; i < array.Length; i++)
            {
                exchangedArray[exchangeArrayIndex] = array[i];
                exchangeArrayIndex++;
            }
            for (int i = 0; i <= indexToStart; i++)
            {
                exchangedArray[exchangeArrayIndex] = array[i];
                exchangeArrayIndex++;
            }
        }
    }
}