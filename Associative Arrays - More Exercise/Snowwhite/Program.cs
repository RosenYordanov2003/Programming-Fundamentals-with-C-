using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dwarfs>> hatColorsDictionary = new Dictionary<string, List<Dwarfs>>();
            List<Dwarfs> dwarfsList = new List<Dwarfs>();
            string command;
            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] tokens = command.Split(new[] { ' ', '<', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                SetDwarfs(hatColorsDictionary, dwarfsList, tokens);
            }
            PrintResul(hatColorsDictionary, dwarfsList);
        }

        static void PrintResul(Dictionary<string, List<Dwarfs>> hatColorsDictionary, List<Dwarfs> dwarfsList)
        {
            dwarfsList = dwarfsList.OrderByDescending(dwarf => dwarf.Physic).ThenByDescending(dwarf => hatColorsDictionary[dwarf.HatColor].Count).ToList();
            foreach (Dwarfs dwafr in dwarfsList)
            {
                Console.WriteLine($"({dwafr.HatColor}) {dwafr.Name} <-> {dwafr.Physic}");
            }
        }

        private static void SetDwarfs(Dictionary<string, List<Dwarfs>> hatColorsDictionary, List<Dwarfs> dwarfsList, string[] tokens)
        {
            string name = tokens[0];
            string hatColor = tokens[1];
            int physic = int.Parse(tokens[2]);
            if (!hatColorsDictionary.ContainsKey(hatColor))
            {
                hatColorsDictionary[hatColor] = new List<Dwarfs>();
            }
            if (!hatColorsDictionary[hatColor].Any(dwarf => dwarf.Name == name))
            {
                Dwarfs currentDwarf = new Dwarfs(name, hatColor, physic);
                hatColorsDictionary[hatColor].Add(currentDwarf);
                dwarfsList.Add(currentDwarf);
            }
            else
            {
                Dwarfs dwarfToCompare = hatColorsDictionary[hatColor].FirstOrDefault(dwarf => dwarf.Name == name);
                dwarfToCompare.Physic = Math.Max(physic, dwarfToCompare.Physic);
            }
        }
    }
    class Dwarfs
    {
        public Dwarfs(string name, string hatColor, int physic)
        {
            this.Name = name;
            this.HatColor = hatColor;
            this.Physic = physic;
        }
        public string Name { get; set; }
        public string HatColor { get; set; }
        public int Physic { get; set; }
    }
}
