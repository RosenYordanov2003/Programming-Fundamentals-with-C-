using System;

namespace _03._Programming_Fundamentals_Mid_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string comand = string.Empty;
            int countWonBattles = 0;
            bool dontEnoughEnergy = false;
            while ((comand = Console.ReadLine()) != "End of battle")
            {
                int distanceToEnemy = int.Parse(comand);
                if (distanceToEnemy > initialEnergy)
                {
                    dontEnoughEnergy = true;
                    Console.WriteLine($"Not enough energy! Game ends with {countWonBattles} won battles and {initialEnergy} energy");
                    break;
                }
                else
                {
                    countWonBattles++;
                    initialEnergy -= distanceToEnemy;
                }
                if (countWonBattles % 3 == 0)
                {
                    initialEnergy += countWonBattles;
                }
            }
            if (!dontEnoughEnergy)
            {
                Console.WriteLine($"Won battles: {countWonBattles}. Energy left: {initialEnergy}");
            }
        }
    }
}
