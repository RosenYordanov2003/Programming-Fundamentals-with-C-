using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int max1 = 0;
            int max2 = 0;
            int max3 = 0;
            if (num1 >= num2 && num1 >= num3)
            {
                max1 = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                max1 = num2;
            }
            else if (num3 >= num1 && num3 >= num2)
            {
                max1 = num3;
            }
            if (num1 <= num2 && num1 >= num3)
            {
                max2 = num1;
            }
            else if (num1 >= num2 && num1 <= num3)
            {
                max2 = num1;
            }
            else if (num2 > num1 && num2 < num3)
            {
                max2 = num2;
            }
            else if (num2 <= num1 && num2 >= num3)
            {
                max2 = num2;
            }
            else if (num3 >= num1 && num3 <= num2)
            {
                max2 = num3;
            }
            else if (num3 <= num1 && num3 >= num2)
            {
                max2 = num3;
            }
            if (num1 <= num2 && num1 <= num3)
            {
                max3 = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                max3 = num2;
            }
            else if (num3 <= num1 && num3 <= num2)
            {
                max3 = num3;
            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);
            Console.WriteLine(max3);
        }
    }
}
