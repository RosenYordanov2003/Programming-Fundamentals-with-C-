using System;

namespace Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <n ; i++)
            {
                for (int z = 0; z < n; z++)
                {
                    for (int g = 0; g <n ; g++)
                    {
                       char firstChar=(char)('a'+i);
                       char secondChar=(char)('a'+z);
                       char thirdChar=(char)('a'+g);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
