using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split('/');
                string type = tokens[0];
                if (type == "Car")
                {
                    Cars currentCar = new Cars(tokens[1], tokens[2], int.Parse(tokens[3]));
                    catalog.Cars.Add(currentCar);
                }
                else
                {
                    Truck curretnTruck = new Truck(tokens[1], tokens[2], int.Parse(tokens[3]));
                    catalog.Trucks.Add(curretnTruck);
                }
            }
            if (catalog.Cars.Count > 0)
            {
                List<Cars> orderCars = catalog.Cars.OrderBy(car => car.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (Cars car in orderCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Cars
    {
        public Cars(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Cars>();
            this.Trucks = new List<Truck>();
        }
        public List<Cars> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}