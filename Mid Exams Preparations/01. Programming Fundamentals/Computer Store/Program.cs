using System;

namespace Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalSumWithoutTaxes = 0;
            bool isSpecial = false;
            while (command != "special" && command != "regular")
            {
                double price = double.Parse(command);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalSumWithoutTaxes += price;
                }
                command = Console.ReadLine();
                if (command == "special")
                {
                    isSpecial = true;
                    break;
                }
            }
            double totalSum = totalSumWithoutTaxes + (totalSumWithoutTaxes * 20) / 100;
            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            double taxes = totalSum - totalSumWithoutTaxes;
            if (isSpecial)
            {
                totalSum = totalSum - (totalSum * 10) / 100;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalSumWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {(taxes):f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalSum:f2}$");
        }
    }
}
