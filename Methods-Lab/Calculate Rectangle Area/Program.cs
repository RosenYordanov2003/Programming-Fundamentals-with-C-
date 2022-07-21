using System;

namespace Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result=FindArea(a, b);
            Console.WriteLine(result);
        }

        static double FindArea(double a, double b)
        {
          double result = a * b;
            return result;
        }
    }
}
