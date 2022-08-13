using System;

namespace _04._Programming_Fundamentals_Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodKg = double.Parse(Console.ReadLine()) * 1000;
            double hayKg = double.Parse(Console.ReadLine()) * 1000;
            double coverKg = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;
            bool fodIsOver = false;
            for (int i = 1; i <= 30; i++)
            {
                foodKg -= 300;
                if (i % 2 == 0)
                {
                    double hay = (foodKg * 5) / 100;
                    hayKg -= hay;
                }
                if (i % 3 == 0)
                {
                    coverKg -= weight / 3;
                }
                if (foodKg <= 0 || hayKg <= 0 || coverKg <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    fodIsOver = true;
                    break;
                }
            }
            foodKg /= 1000;
            hayKg /= 1000;
            coverKg /= 1000;
            if (!fodIsOver)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKg:f2}, Hay: {hayKg:f2}, Cover: {coverKg:f2}.");
            }
        }
    }
}
