using System;

namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// from startingYield we subtract 10 from him everyday while is bigger than 100
            /// the workers consumes 26 spices every day
            /// if the Yield is less than 100 workers consumes another 26 spices
            /// the workers consumes spices if spices are enough
            int startingYield = int.Parse(Console.ReadLine());
            int daysCounter = 0;
            int totalSpices = 0;
            while (startingYield>=100)
            {
                int spices = 0;
                int workersConsumes=26;
                spices += startingYield;
                daysCounter++;
                startingYield -= 10;
                totalSpices += spices;
                if (totalSpices >= workersConsumes)
                {
                    totalSpices -= 26;
                }
                if (startingYield<100)
                {
                    if (totalSpices>=workersConsumes)
                    {
                        totalSpices -= 26;
                    }
                    break;
                }
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalSpices);
        }
    }
}
