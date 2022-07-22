using System;

namespace Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
           double firstNumFact = CalculateFirstNumFact(firstNumber);
           double secondNumFact=CalculateFirstNumFact(secondNumber);
            Console.WriteLine($"{(firstNumFact/secondNumFact):f2}");
        }

        static double CalculateFirstNumFact(int firstNumber)
        {
            double result = 1;
            while (firstNumber>0)
            {
                result *= firstNumber;
                firstNumber--;
            }
            return result;
        }
    }
}
