using System;

namespace Data_Types_and_Variables___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           long number1=long.Parse(Console.ReadLine());
           long number2=long.Parse(Console.ReadLine());
           long number3=long.Parse(Console.ReadLine());
           long number4=long.Parse(Console.ReadLine());
            long result=number1+number2;
             result = result / number3;
            result = result * number4;
            Console.WriteLine(result);

        }
    }
}
