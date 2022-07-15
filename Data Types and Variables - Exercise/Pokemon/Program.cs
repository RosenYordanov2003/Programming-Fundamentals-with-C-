using System;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///we have the power of our Pokemon -power-Done
            ///we have also a distance between targets-distance-Done
            /// we have also the exhaustionFactor - Y-Done
            /// our task: power-distance until power becomes less than distance
            /// every time we subtract power from distance we reach a target and we have to count them-Done
            /// if the power becomes equal to his original value, we have to divide power by Y and the division has to be INT type-Done
            /// when power becomes less than distance we have to get the reminder from power and print it with the counter for our targets-Done
            
            int power = int.Parse(Console.ReadLine());//n
            int distance = int.Parse(Console.ReadLine());//m
            int Y = int.Parse(Console.ReadLine());
            int originalPowerValue = power;
            int counter = 0;
            while (power>=distance)
            {
                power = power - distance;
                counter++;
                decimal halfFromPowerValue=originalPowerValue/2;    
                if (power<distance)
                {
                    break;
                }
                if (power==halfFromPowerValue&&Y>0)
                {
                    power = (int)(power / Y);
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
