using System;

namespace _3._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int courses=(int)Math.Ceiling((double)n / people);
            Console.WriteLine(courses);
        }
    }
}
