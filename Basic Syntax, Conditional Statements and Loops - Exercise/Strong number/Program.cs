using System;

namespace Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factoriel = 1;
            int sum = 0;
            bool isStrong = false;
            int oldNum = number;
            while (number > 0)
            {
                factoriel = 1;
                int digit = number % 10;
                while (digit >= 1)
                {
                    factoriel = factoriel * digit;
                    digit--;
                }
                sum += factoriel;
                number /= 10;
                if (sum == oldNum)
                {
                    isStrong = true;
                    Console.WriteLine("yes");
                    break;
                }
            }
            if (!isStrong)
            {
                Console.WriteLine("no");
            }
        }
    }
}
