using System;
using System.Linq;
using System.Collections.Generic;
namespace Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string model = tokens[0];
                decimal fuelAmount = decimal.Parse(tokens[1]);
                decimal fuelConsumptionPer1km = decimal.Parse(tokens[2]);
                Car currentCar = new Car(model, fuelAmount, fuelConsumptionPer1km);
                cars.Add(currentCar);
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] comandArgs = command.Split(' ');
                string operaton = comandArgs[0];
                if (operaton == "Drive")
                {
                    string model = comandArgs[1];
                    decimal distance = decimal.Parse(comandArgs[2]);
                    Car findModel = cars.FirstOrDefault(c => c.Model == model);
                    findModel.isEnoughFuel(distance, findModel.FuelAmount, findModel.FuelConsumptionPer1km);
                }
            }
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
    class Car
    {
        public Car(string model, decimal fuelAmount, decimal fuelConsumptionPer1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPer1km = fuelConsumptionPer1km;
        }
        public string Model { get; set; }
        public decimal FuelAmount { get; set; }
        public decimal FuelConsumptionPer1km { get; set; }
        public decimal TraveledDistance { get; set; }
        public bool isEnoughFuel(decimal distance, decimal fuelAmount, decimal fuelConsumptionPer1km)
        {
            decimal consumeFuel = distance * fuelConsumptionPer1km;
            if (consumeFuel > fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }
            this.FuelAmount -= consumeFuel;
            this.TraveledDistance += distance;
            return true;
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TraveledDistance}";
        }
    }
}
