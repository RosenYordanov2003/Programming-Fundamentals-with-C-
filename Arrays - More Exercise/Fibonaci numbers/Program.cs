using System;
using System.Linq;
namespace Fibonaci_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n = int.Parse(Console.ReadLine());
            int[]numbers=new int[n];
          int number = 2;
            int counter = 0;
            if (n>=2)
            {
                numbers[0] = 0;
                numbers[1] = 1;
                for (int i = 2; i <numbers.Length-1; i++)
                {
                    numbers[i]=numbers[i-2]+numbers[i-1];
                    number+=numbers[i];
                }
                counter++;
            }
            if (counter>0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(n);
            }

        }
    }
}
