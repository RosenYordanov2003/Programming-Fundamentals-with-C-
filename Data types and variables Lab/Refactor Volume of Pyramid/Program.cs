using System;

namespace Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double length= double.Parse(Console.ReadLine());
           double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result= (length * width * height)/3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {result:f2}");
            /// code before--
            /// double l, w, h = 0;
            //Console.WriteLine("Length: ");
            //l = double.Parse(Console.ReadLine());
            //Console.WriteLine("Width: ");
            //sh = double.Parse(Console.ReadLine());
            //Console.WriteLine("Height: ");
            //V = double.Parse(Console.ReadLine());
            //V = (l + w + V) / 3;
            //Console.WriteLine($"Pyramid Volume: {V:f2}");

        }
    }
}
