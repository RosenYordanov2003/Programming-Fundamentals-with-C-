using System;
using System.Linq;
using System.Collections.Generic;
namespace A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string,double>resources=new Dictionary<string,double>();
            string word=string.Empty;
            while ((word=Console.ReadLine())!="stop")
            {
               double amount=double.Parse(Console.ReadLine());
                if (resources.ContainsKey(word))
                {
                    resources[word] += amount;
                }
                else
                {
                    resources.Add(word, amount);
                }
            }
            foreach (KeyValuePair<string,double> item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
