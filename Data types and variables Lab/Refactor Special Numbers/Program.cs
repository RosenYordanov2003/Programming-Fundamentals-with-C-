using System;

namespace Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int digit = 1; digit <=count; digit++)
            {
                int currentNum = digit;
                int sum = 0;
                while (digit > 0)
                {              
                    sum += digit % 10;
                    digit = digit / 10;
                }
                bool isSpecial = false;
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNum} -> {isSpecial}");
                sum = 0;
                digit = currentNum;
            }
        }
        // code before: int c = int.Parse(Console.ReadLine());
 //       int s = 0;
 //       int something = 0;
 //       bool IsSOmething = false;
 //for (int something = 1; something <= something; ch++)
 //{
 //       something = dig.;
 //        while (dig. > 0)
 //        {
 //            s += dig % 10;
 //            dig. = dig. / 10;
 //        }
 //   toe = (s == 5) || (s == 7) || (s == 11);
 //    Console.WriteLine("{0} -> {1}", something, IsSOmething);
 //    s = 0;
 //    dig. = something;

    }
}
