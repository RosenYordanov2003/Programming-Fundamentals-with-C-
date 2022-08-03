using System;
using System.Linq;
using System.Text;

namespace Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            foreach (string word in text)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
