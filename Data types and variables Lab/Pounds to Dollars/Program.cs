using System;

namespace Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            double dolarValue = 1.31;
            decimal dolar = (decimal)(dolarValue);
            decimal total = dolar * pounds;
            Console.WriteLine($"{total:f3}");
        }
    }
}
