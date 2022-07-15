using System;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            double max = 0;
            string winnerKeg = string.Empty;
            for (int i = 1; i <=n ; i++)
            {
                double result = 0;
                string kegModel = Console.ReadLine();
                double radius=double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                result = Math.PI * Math.Pow(radius, 2)*height;
                if (result>max)
                {
                    max = result;
                    winnerKeg = kegModel;
                }
            }
            Console.WriteLine(winnerKeg);
        }
    }
}
