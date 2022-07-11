using System;

namespace Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int startInteger = int.Parse(Console.ReadLine());
            do
            {
                int result = integer * startInteger;
                Console.WriteLine($"{integer} X {startInteger} = {result}");
                startInteger++;

            } while (startInteger <= 10);
        }
    }
}
