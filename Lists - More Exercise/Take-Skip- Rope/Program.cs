using System;
using System.Collections.Generic;

namespace Take_Skip__Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<char> result = new List<char>();
            List<int> numbers = new List<int>();
            result.AddRange(text);
            for (int i = 0; i < result.Count; i++)
            {
                char current = result[i];
                string result2 = current.ToString();
                if (char.IsDigit(current))
                {
                    numbers.Add(int.Parse(result2));
                    result.Remove(current);
                    i--;
                }
            }
            List<int> Take = FindEvenIndex(numbers);
            List<int> Skip = FindOddIndex(numbers);
            List<char> encryptedResult = new List<char>();
            while (Take.Count > 0 && Skip.Count > 0)
            {
                int takeLenght = Take[0];
                int count=0;
                if (takeLenght>0)
                {
                    for (int i = 0; i < takeLenght; i++)
                    {
                        if (i<result.Count)
                        {
                            encryptedResult.Add(result[i]);
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    Take.RemoveAt(0);
                    result.RemoveRange(0,count);
                    takeLenght = 0;
                    count = 0;
                }
                else
                {
                    Take.RemoveAt(0);
                }
                int skipLenght = Skip[0];
                if (skipLenght>0)
                {
                    result.RemoveRange(0, skipLenght);
                    Skip.RemoveAt(0);
                    skipLenght = 0;
                }
                else
                {
                    Skip.RemoveAt(0);
                }
            }
            Console.WriteLine(String.Join("",encryptedResult));
        }
        static List<int> FindOddIndex(List<int> numbers)
        {
            List<int> odd = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    odd.Add(numbers[i]);
                }
            }
            return odd;
        }
        static List<int> FindEvenIndex(List<int> numbers)
        {
            List<int> even = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(numbers[i]);
                }
            }
            return even;
        }
    }
}
