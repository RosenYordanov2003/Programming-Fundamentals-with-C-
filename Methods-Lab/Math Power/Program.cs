using System;

namespace Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double abase = double.Parse(Console.ReadLine());
           double result= NumberPow(number,abase);
            Console.WriteLine(result);
        }

        static double NumberPow(double number, double abase)
        {
            double result = 1d;
            for (int i = 1; i <=abase ; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
