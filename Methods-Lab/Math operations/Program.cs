using System;

namespace Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if (@operator == '+')
            {
                int result = AddNumbers(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (@operator == '-')
            {
                int result = SubtractNumbers(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (@operator == '*')
            {
                int result = MultiplyNumbers(firstNum, secondNum);
                Console.WriteLine(result);
            }
            else if (@operator=='/')
            {
                int result = DivideNumbers(firstNum, secondNum);
                Console.WriteLine(result);
            }
        }
         static int DivideNumbers(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }

        static int MultiplyNumbers(int firstNum, int secondNum)
        {
           return firstNum * secondNum;
        }
        static int SubtractNumbers(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        static int AddNumbers(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
