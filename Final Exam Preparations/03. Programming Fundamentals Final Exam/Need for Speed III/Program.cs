using System;
using System.Collections.Generic;

namespace Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, CarProperties> cars = new Dictionary<string, CarProperties>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfCars; i++)
            {
                string carInformation = Console.ReadLine();
                string[] tokens = carInformation.Split('|');
                string carModel = tokens[0];
                int mileage = int.Parse(tokens[1]);
                int fuel = int.Parse(tokens[2]);
                CarProperties currentProperties = new CarProperties(mileage, fuel);
                if (!cars.ContainsKey(carModel))
                {
                    cars[carModel] = currentProperties;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] tokens = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string operation = tokens[0];
                if (operation == "Drive")
                {
                    string carModel = tokens[1];
                    int distance = int.Parse(tokens[2]);
                    int neededFuel = int.Parse(tokens[3]);
                    DriveMethod(carModel, distance, neededFuel, cars);
                }
                else if (operation == "Refuel")
                {
                    const int maximumCapacity = 75;
                    string carModel = tokens[1];
                    int fuelToAdd = int.Parse(tokens[2]);
                    int currentFuel = cars[carModel].Fuel;
                    int space = maximumCapacity - currentFuel;
                    if (space > 0 && fuelToAdd >= space)
                    {
                        fuelToAdd = space;
                        cars[carModel].Fuel += fuelToAdd;
                        Console.WriteLine($"{carModel} refueled with {fuelToAdd} liters");
                    }
                    else if (space > 0 && fuelToAdd < space)
                    {
                        cars[carModel].Fuel += fuelToAdd;
                        Console.WriteLine($"{carModel} refueled with {fuelToAdd} liters");
                    }
                }
                else if (operation == "Revert")
                {
                    string carModel = tokens[1];
                    int kilometers = int.Parse(tokens[2]);
                    RevertCar(carModel, kilometers, cars);
                }
            }
            PrintResult(cars);
        }

        static void PrintResult(Dictionary<string, CarProperties> cars)
        {
            foreach (KeyValuePair<string,CarProperties> car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }

        static void RevertCar(string carModel, int kilometers, Dictionary<string, CarProperties> cars)
        {
            cars[carModel].Mileage -= kilometers;
            if (cars[carModel].Mileage < 10000)
            {
                cars[carModel].Mileage = 10000;
            }
            else
            {
                Console.WriteLine($"{carModel} mileage decreased by {kilometers} kilometers");
            }
        }

        static void DriveMethod(string carModel, int distance, int neededFuel, Dictionary<string, CarProperties> cars)
        {
            if (cars[carModel].Fuel < neededFuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                cars[carModel].Mileage += distance;
                cars[carModel].Fuel -= neededFuel;
                Console.WriteLine($"{carModel} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
            }
            if (cars[carModel].Mileage >= 100000)
            {
                Console.WriteLine($"Time to sell the {carModel}!");
                cars.Remove(carModel);
            }
        }
    }
    class CarProperties
    {
        public CarProperties(int mileage, int fuel)
        {
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
