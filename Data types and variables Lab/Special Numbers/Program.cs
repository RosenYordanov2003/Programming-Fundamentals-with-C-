using System;

namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                sum = 0;
                int oldNum = i;
                int currentNum = i;
                if (currentNum>=10)
                {
                    while (currentNum>0)
                    {
                        int digit = currentNum % 10;
                        sum += digit;
                        currentNum=currentNum/10;
                    }
                    if (sum==5||sum==11||sum==7)
                    {
                        Console.WriteLine($"{oldNum} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{oldNum} -> False");
                    }
                }
                else if (currentNum<10)
                {
                    if (currentNum==5||currentNum==7||currentNum==11)
                    {
                        Console.WriteLine($"{currentNum} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{currentNum} -> False");
                    }
                }
            }
        }
    }
}
