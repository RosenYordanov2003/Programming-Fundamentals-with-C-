using System;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int result = i * integer;
                Console.WriteLine($"{integer} X {i} = {result}");
            }
        }
    }
}
