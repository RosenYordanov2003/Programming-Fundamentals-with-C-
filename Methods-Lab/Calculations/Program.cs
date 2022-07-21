using System;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (operation=="add")
            {
                AddNumbers(number1, number2);
            }
            else if (operation == "divide")
            {
                DivideNumbers(number1, number2);
            }
            else if (operation=="subtract")
            {
                SubtractNumbers(number1, number2);
            }
            else if (operation=="multiply")
            {
                MultiplyNumbers(number1, number2);
            }
        }

        static void DivideNumbers(int number1, int number2)
        {
            Console.WriteLine(number1/number2);
        }

        private static void SubtractNumbers(int number1, int number2)
        {

            Console.WriteLine(number1 - number2);
        }

        static void MultiplyNumbers(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        static void AddNumbers(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }
    }
}
