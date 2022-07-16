using System;

namespace Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            if (typeDay == "Weekend")
            {
                if (age >= 1 && age <= 18)
                {
                    price += 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price += 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price += 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            else if (typeDay == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    price += 12;
                }
                else if (age > 18 && age <= 64)
                {
                    price += 18;
                }
                else if (age > 64 && age <= 122)
                {
                    price += 12;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            else if (typeDay == "Holiday")
            {
                if (age >= 1 && age <= 18)
                {
                    price += 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price += 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price += 10;

                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            Console.WriteLine($"{price}$");
        }
    }
}
