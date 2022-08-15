using System;

namespace Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= days; i++)
            {
                sum += dailyPlunder;
                if (i % 3 == 0)
                {
                    sum += (double)dailyPlunder / 2;
                }
                if (i % 5 == 0)
                {
                    sum =sum - (sum * 30) / 100;
                }
            }
            if (sum >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {sum:f2} plunder gained.");
            }
            else
            {
                double percent = (double)sum / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percent:f2}% of the plunder.");
            }
        }
    }
}
