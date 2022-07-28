using System;
using System.Linq;
using System.Collections.Generic;

namespace Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Boxes> boxes = new List<Boxes>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] comandTokens = command.Split();
                Boxes box = new Boxes
                {
                    SerialNumber = comandTokens[0],
                    itemQuantity = int.Parse(comandTokens[2]),
                    Item = new Item
                    {
                        Name = comandTokens[1],
                        Price = decimal.Parse(comandTokens[3])
                    }
                };
                boxes.Add(box);
            }
            List<Boxes> sortedList = boxes.OrderByDescending(box => box.PricePerBox).ToList();
            PrintMethod(sortedList);
        }

        static void PrintMethod(List<Boxes> sortedList)
        {
            foreach (Boxes box in sortedList)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.itemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
        }
    }
}
class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
class Boxes
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int itemQuantity { get; set; }
    public decimal PricePerBox
    {
        get
        {
            return this.itemQuantity * this.Item.Price;
        }
    }
}