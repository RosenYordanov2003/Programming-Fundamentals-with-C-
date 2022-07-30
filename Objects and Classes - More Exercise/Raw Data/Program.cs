using System;
using System.Linq;
using System.Collections.Generic;

namespace Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] carInformation = Console.ReadLine().Split(' ');
                string model = carInformation[0];
                int engineSpeed = int.Parse(carInformation[1]);
                int enginrPower = int.Parse(carInformation[2]);
                int cargoWeight = int.Parse(carInformation[3]);
                string cargoType = carInformation[4];
                Engine engine = new Engine(engineSpeed, enginrPower);
                Cargo currentCargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, currentCargo);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<Car> fragile = new List<Car>();
                PrintFragileModels(fragile, cars);
            }
            else
            {
                List<Car> flamable = new List<Car>();
                PrintFlambleModel(flamable, cars);
            }
        }

        static void PrintFlambleModel(List<Car> flamable, List<Car> cars)
        {
            foreach (Car car in cars)
            {
                if (car.Cargo.CargoType== "flamable")
                {
                    flamable.Add(car);
                }
            }
            flamable = flamable.Where(car => car.Engine.EnginePower > 250).ToList();
            foreach (Car flambleModel in flamable)
            {
                Console.WriteLine(flambleModel.Model);
            }
        }

        static void PrintFragileModels(List<Car> fragile, List<Car> cars)
        {
            foreach (Car car in cars)
            {
                if (car.Cargo.CargoType == "fragile")
                {
                    fragile.Add(car);
                }
            }
            fragile = fragile.Where(car => car.Cargo.CargoWeight < 1000).ToList();
            foreach (Car car in fragile)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }
    }
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
        public int EnginePower { get; set; }
        public int EngineSpeed { get; set; }
    }
}
