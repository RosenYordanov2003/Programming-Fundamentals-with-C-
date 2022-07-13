using System;

namespace Last_Digit_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int number = int.Parse(Console.ReadLine());
                SpellEnglish(number);
            }
            static void SpellEnglish(int number)
            {
                int lastDigit = 0;
                int counter = 0;
                while (true)
                {
                    lastDigit = number % 10;
                    counter++;
                    if (counter == 1)
                    {
                        break;
                    }
                }
                if (lastDigit == 1)
                {
                    Console.WriteLine("one");
                }
                else if (lastDigit == 2)
                {
                    Console.WriteLine("two");
                }
                else if (lastDigit == 3)
                {
                    Console.WriteLine("three");
                }
                else if (lastDigit == 4)
                {
                    Console.WriteLine("four");
                }
                else if (lastDigit == 5)
                {
                    Console.WriteLine("five");
                }
                else if (lastDigit == 6)
                {
                    Console.WriteLine("six");
                }
                else if (lastDigit == 7)
                {
                    Console.WriteLine("seven");
                }
                else if (lastDigit == 8)
                {
                    Console.WriteLine("eight");
                }
                else if (lastDigit == 9)
                {
                    Console.WriteLine("nine");
                }
                else if (lastDigit == 10)
                {
                    Console.WriteLine("ten");
                }
                else if (lastDigit == 0)
                {
                    Console.WriteLine("zero");
                }
            }
        }
    }
}
