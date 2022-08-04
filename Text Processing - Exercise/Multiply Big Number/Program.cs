using System;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multyplier = int.Parse(Console.ReadLine());
            StringBuilder sb=new StringBuilder();
            int remainder = 0;
            if (multyplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = number.Length-1; i >=0; i--)
            {
                char currentDigit = number[i];
                int currentDigitAsNumber=int.Parse(currentDigit.ToString());
                int result = currentDigitAsNumber * multyplier+remainder;
                sb.Append(result%10);
                remainder=result/10;
            }
            if (remainder!=0)
            {
                sb.Append(remainder);
            }
            char[]array=sb.ToString().ToCharArray();
            string[]reversed = array.Select(x => x.ToString()).ToArray();
            Console.WriteLine(string.Join("",reversed.Reverse()));
        }
    }
}
