using System;

namespace Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            FindClosestPointToCenter(x1, y1, x2, y2);
        }
        static void FindClosestPointToCenter(double x1, double y1, double x2, double y2)
        {
            double firstDistance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondDistance = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (firstDistance <= secondDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
