using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (typeGroup == "Students")
            {
                if (day == "Friday")
                {
                    price += 8.45 * countPeople;
                }
                else if (day == "Saturday")
                {
                    price += 9.80 * countPeople;
                }
                else if (day == "Sunday")
                {
                    price += 10.46 * countPeople;
                }
                if (countPeople >= 30)
                {
                    price = price - (price * 15) / 100;
                }
            }
            else if (typeGroup == "Business")
            {
                if (countPeople >= 100)
                {
                    countPeople -= 10;
                }
                if (day == "Friday")
                {
                    price += 10.90 * countPeople;
                }
                else if (day == "Saturday")
                {
                    price += 15.60 * countPeople;
                }
                else if (day == "Sunday")
                {
                    price += 16 * countPeople;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price += 15 * countPeople;
                }
                else if (day == "Saturday")
                {
                    price += 20 * countPeople;
                }
                else if (day == "Sunday")
                {
                    price += 22.50 * countPeople;
                }
                if (countPeople >= 10 && countPeople <= 20)
                {
                    price = price - (price * 5) / 100;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
