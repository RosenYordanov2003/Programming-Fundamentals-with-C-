using System;

namespace Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int z = 0; z < arr1.Length; z++)
                {
                    if (arr2[i] == arr1[z])
                    {
                        Console.Write(arr2[i] + " ");
                    }
                }
            }
        }
    }
}
