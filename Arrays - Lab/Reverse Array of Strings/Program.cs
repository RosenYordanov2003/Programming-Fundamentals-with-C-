using System;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ');
            for (int index = 0; index < text.Length / 2; index++)
            {
                string currentText = text[index];
                string oldText = currentText;
                text[index] = text[text.Length - 1 - index];
                text[text.Length - 1 - index] = oldText;
            }
            foreach (var item in text)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
