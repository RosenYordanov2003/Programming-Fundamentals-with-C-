using System;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberSnowBalls=int.Parse(Console.ReadLine());
            double theBestSnowBallValue = int.MinValue;
            string format = string.Empty;
            long value = 0;
            for (int i = 1; i <=numberSnowBalls ; i++)
            {
                int snowBalls=int.Parse(Console.ReadLine());
                int snowBallTime=int.Parse(Console.ReadLine());
                int snowBallQuality=int.Parse(Console.ReadLine());
                if (snowBallTime>0)
                {
                 value = (long)Math.Pow((snowBalls / snowBallTime), snowBallQuality);
                }
                if (value>theBestSnowBallValue)
                {
                    theBestSnowBallValue = value;
                  format = string.Format($"{snowBalls} : { snowBallTime} = {theBestSnowBallValue} ({snowBallQuality})");
                }
            }
            Console.WriteLine(format);
        }
    }
}
