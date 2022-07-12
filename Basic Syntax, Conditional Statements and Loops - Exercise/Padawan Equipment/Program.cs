using System;

namespace Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double saberStudents = countOfStudents + (countOfStudents * 10) / 100;
            saberStudents = Math.Ceiling(saberStudents);
            double totalSaberPrice = saberPrice * saberStudents;
            double totalBeltPrice = 0;
            Math.Floor(saberPrice);
            for (int i = 1; i <= countOfStudents; i++)
            {
                double currentStudnets = i;
                if (currentStudnets % 6 != 0)
                {
                    totalBeltPrice += beltPrice;
                }
            }
            double total = totalSaberPrice + robePrice * countOfStudents + totalBeltPrice;
            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                double diff = Math.Abs(money - total);
                Console.WriteLine($"John will need {diff:f2}lv more.");
            }
        }
    }
}
