using System;

namespace Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string comand = string.Empty;
            double spentMoney = 0;
            bool theMoneyareZero = false;
            while ((comand = Console.ReadLine()) != "Game Time")
            {
                double gamePrice = 0;
                if (comand == "OutFall 4")
                {
                    gamePrice = 39.99;
                }
                else if (comand == "CS: OG")
                {
                    gamePrice = 15.99;
                }
                else if (comand == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                }
                else if (comand == "Honored 2")
                {
                    gamePrice = 59.99;
                }
                else if (comand == "RoverWatch")
                {
                    gamePrice = 29.99;
                }
                else if (comand == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                if (money >= gamePrice)
                {
                    Console.WriteLine($"Bought {comand}");
                    money -= gamePrice;
                    spentMoney += gamePrice;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    theMoneyareZero = true;
                    break;
                }
            }
            if (!theMoneyareZero)
            {
                Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${money:f2}");
            }
        }
    }
}
