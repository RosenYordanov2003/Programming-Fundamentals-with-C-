using System;

namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double sum = 0;
            int keyboardCounter = 0;
            for (int lostgame = 1; lostgame <= lostGamesCount; lostgame++)
            {
                int counter = 0;
                int currentLostGame = lostgame;
                if (currentLostGame % 2 == 0)
                {
                    sum += headsetPrice;
                    counter++;
                }
                if (currentLostGame % 3 == 0)
                {
                    sum += mousePrice;
                    counter++;
                }
                if (counter == 2)
                {
                    sum += keyboardPrice;
                    keyboardCounter++;
                }
                if (keyboardCounter % 2 == 0 && keyboardCounter > 0)
                {
                    sum += displayPrice;
                    keyboardCounter = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
