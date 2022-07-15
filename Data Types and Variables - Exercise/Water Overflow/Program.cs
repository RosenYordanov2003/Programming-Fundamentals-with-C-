using System;

namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int count = int.Parse(Console.ReadLine());
          int capacity = 255;
            int sum = 0;
            for (int i = 1; i <=count; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters<=capacity)
                {
                    capacity -= liters;
                    sum += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
