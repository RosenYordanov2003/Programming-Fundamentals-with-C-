using System;
using System.Linq;
using System.Collections.Generic;
namespace Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string, int> keyItems = new Dictionary<string, int>
        {
            {"shards",0 },
            {"motes",0 },
            {"fragments",0 }
        };
            Dictionary<string, int> junkItems = new Dictionary<string, int>();
            Dictionary<string,string>itemToOptainOportunities=new Dictionary<string, string>
            {
                 {"shards","Shadowmourne"},
                {"fragments","Valanyr"},
                {"motes","Dragonwrath"}
            };
            string obtainedItem = string.Empty;
            while (string.IsNullOrEmpty(obtainedItem))
            {
                string[] materials = Console.ReadLine().ToLower().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                for(int i = 0; i < materials.Length; i++)
                {
                    int quantityOfItem=int.Parse(materials[i]);
                    string currentMaterial=materials[i+1];
                    if (keyItems.ContainsKey(currentMaterial))
                    {
                        keyItems[currentMaterial]+=quantityOfItem;
                        if (keyItems[currentMaterial]>=250)
                        {
                            obtainedItem = itemToOptainOportunities[currentMaterial];
                            keyItems[currentMaterial] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(currentMaterial))
                        {
                            junkItems[currentMaterial] = 0;
                        }
                        junkItems[currentMaterial]+=quantityOfItem;
                    }
                    i++;
                }
            }
            PrintResult(obtainedItem, keyItems, junkItems);
        }

         static void PrintResult(string obtainedItem, Dictionary<string, int> keyItems, Dictionary<string, int> junkItems)
        {
            Console.WriteLine($"{obtainedItem} obtained!");
            foreach (KeyValuePair<string,int> item in keyItems)
            {
                if(item.Value < 0)
                {
                    continue;
                }
                Console.WriteLine($"{item.Key.ToLower()}: {item.Value}");
            }
            foreach (KeyValuePair<string,int> item in junkItems)
            {
                if (item.Value < 0)
                {
                    continue;
                }
                Console.WriteLine($"{item.Key.ToLower()}: {item.Value}");
            }
        }
    }
}
