using System;

namespace Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int addResult=AddNumbers(firstNumber, secondNumber);
            int subtractResult = SubtractMethod(addResult, thirdNumber);
            Console.WriteLine(subtractResult);
        }

         static int SubtractMethod(int addResult, int thirdNumber)
        {
            return addResult - thirdNumber;
        }

        static int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
