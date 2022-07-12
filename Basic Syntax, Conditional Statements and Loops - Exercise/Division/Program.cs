using System;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxDivison = 0;
            int divison = 0;
            int count = 0;
            int countDivison = 0;
            if (number % 2 == 0)
            {
                divison = 2;
                countDivison++;
                if (divison > maxDivison)
                {
                    maxDivison = divison;
                }
            }
            if (number % 3 == 0)
            {
                countDivison++;
                divison = 3;
                if (divison > maxDivison)
                {
                    maxDivison = divison;
                }
            }
            if (number % 6 == 0)
            {
                countDivison++;
                divison = 6;
                if (divison > maxDivison)
                {
                    maxDivison = divison;
                }
            }
            if (number % 7 == 0)
            {
                countDivison++;
                divison = 7;
                if (divison > maxDivison)
                {
                    maxDivison = divison;
                }
            }
            if (number % 10 == 0)
            {
                countDivison++;
                divison = 10;
                if (divison > maxDivison)
                {
                    maxDivison = divison;
                }
            }
            if (countDivison == 0)
            {
                Console.WriteLine("Not divisible");
                count++;
            }
            if (count <= 0)
            {
                Console.WriteLine($"The number is divisible by {maxDivison}");
            }
        }
    }
}
