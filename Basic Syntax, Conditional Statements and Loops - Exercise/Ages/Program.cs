using System;

namespace Basic_Syntax__Conditional_Statements_and_Loops___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string role = string.Empty;
            if (age >= 0 && age <= 2)
            {
                role = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                role = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                role = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                role = "adult";
            }
            else if (age >= 66)
            {
                role = "elder";
            }
            Console.WriteLine(role);
        }
    }
}
