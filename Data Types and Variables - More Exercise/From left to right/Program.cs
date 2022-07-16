using System;
using System.Numerics;

namespace From_left_to_right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int space = 0;
            string left = string.Empty;
            string right = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string text = Console.ReadLine();
                for (int z = 0; z < text.Length - 1; z++)
                {
                    if (text[z] == ' ')
                    {
                        space = z;

                    }
                }
                left = text.Substring(0, space);
                BigInteger leftToInt = BigInteger.Parse(left);
                right = text.Substring(space + 1);
                BigInteger rightToInt = BigInteger.Parse(right);
                if (rightToInt > leftToInt)
                {
                    BigInteger rightSum = 0;
                    if (rightToInt<0)
                    {
                        rightToInt = BigInteger.Abs(rightToInt);
                    }
                    while (rightToInt > 0)
                    {
                        BigInteger digit = rightToInt % 10;
                        rightSum += digit;
                        rightToInt /= 10;
                    }
                    Console.WriteLine(rightSum);
                }
                else
                {
                    if (leftToInt<0)
                    {

                        leftToInt = BigInteger.Abs(leftToInt);
                    }
                    BigInteger leftSum = 0;
                    while (leftToInt > 0)
                    {
                        BigInteger digit = leftToInt % 10;
                        leftSum += digit;
                        leftToInt /= 10;
                    }
                    Console.WriteLine(leftSum);
                }
            }
        }
    }
}
