using System;

namespace _4_Sum_of_chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <=n ; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int castToInt=(int)(symbol);
                sum+=castToInt;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
