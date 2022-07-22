using System;
using System.Linq;
using System.Collections.Generic;

namespace Array_Manipulator
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
                    if (type == "even")
                    {
                        int result = FindMaxEven(array);
                        if (result < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                    else if (type == "odd")
                    {
                        int result = FindMaxOdd(array);
                        if (result<0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                      
                    }
                }
                else if (operation == "min")
                {
                    string type = comandArguments[1];
                    if (type == "even")
                    {
                        int result = FindEvenMin(array);
                        if (result<0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                    else if (type == "odd")
                    {
                        int result = FindMinOdd(array);
                        if (result < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(result);
                        }
                    }
                }
                else if (operation == "first")
                {
                    int count = int.Parse(comandArguments[1]);
                    string type = comandArguments[2];
                    if (type == "even")
                    {
                        if (count > array.Length || count < 0)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        else
                        {
                            FindFirstEvenElements(array, count);
                        }
                    }
                    else if (type == "odd")
                    {
                        if (count > array.Length||count<0)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        else
                        {
                            FindFirsOddElements(array, count);
                        }
                    }
                }
                else if (operation == "last")
                {
                    int count = int.Parse(comandArguments[1]);
                    string type = comandArguments[2];
                    if (type == "even")
                    {
                        if (count > array.Length || count < 0)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        else
                        {
                            FindLastEven(array, count);
                        }
                    }
                    else if (type == "odd")
                    {
                        if (count >array.Length||count<0)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        else
                        {
                            FindLastOddElements(array, count);
                        }
                    }
                }
            }
            string arrayResult = string.Format((string.Join(", ", array)));
            Console.Write($"[{arrayResult}]");
        }

        static void FindLastOddElements(int[] array, int count)
        {
            int oddCounter = 0;
            List<int> list = new List<int>();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 != 0)
                {
                    list.Add(array[i]);
                    oddCounter++;
                    if (oddCounter == count)
                    {
                        break;
                    }
                }
            }
            list.Reverse();
            if (oddCounter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                string result = string.Format(string.Join(", ", list));
                Console.WriteLine($"[{result}]");
            }
        }
        private static void FindLastEven(int[] array, int count)
        {
            int evenCount = 0;
            List<int> list = new List<int>();
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    evenCount++;
                    list.Add(array[i]);
                    if (evenCount == count)
                    {
                        break;
                    }
                }
            }
            list.Reverse();
            if (evenCount == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                string result = string.Format(string.Join(", ", list));
                Console.WriteLine($"[{result}]");
            }
        }
        static void FindFirsOddElements(int[] array, int count)
        {
            int oddCounter = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    list.Add(array[i]);
                    oddCounter++;
                    if (oddCounter == count)
                    {
                        break;
                    }
                }
            }
            if (oddCounter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {

                string result = string.Format(string.Join(", ", list));
                Console.WriteLine($"[{result}]");
            }
        }
        static void FindFirstEvenElements(int[] array, int count)
        {
            int evenCounter = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    list.Add(array[i]);
                    evenCounter++;
                    if (evenCounter == count)
                    {
                        break;
                    }
                }
            }
            if (evenCounter == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                string result = string.Format(string.Join(", ", list));
                Console.WriteLine($"[{result}]");
            }
        }
        static int FindMinOdd(int[] array)
        {
            int countOdd=0;
            int min = int.MaxValue;
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] < min)
                    {
                        countOdd++;
                        min = array[i];
                        result = i;
                    }
                }
            }
            if (countOdd>0)
            {
                return result;
            }
            return -1;
        }

        static int FindEvenMin(int[] array)
        {
            int countEven = 0;
            int min = int.MaxValue;
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] < min)
                    {
                        countEven++;
                        min = array[i];
                        result = i;
                    }
                }
            }
            if (countEven>0)
            {
                return result;
            }
            return -1;
        }

        static int FindMaxOdd(int[] array)
        {
            int countOdd = 0;
            int result = 0;
            int maxOdd = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOdd)
                    {
                        countOdd++;
                        maxOdd = array[i];
                        result = i;
                    }
                }
            }
            if (countOdd > 0)
            {
                return result;
            }
            return -1;
        }

        static int FindMaxEven(int[] array)
        {
            int counterEven = 0;
            int result = 0;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= max)
                    {
                        counterEven++;
                        max = array[i];
                        result = i;
                    }
                }
            }
            if (counterEven>0)
            {
                return result;
            }
            return -1;
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



