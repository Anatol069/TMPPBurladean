using System;

namespace CarSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var carFactory = CarCreate.Instance;

            carFactory.CreateCar("Tesla Model S", "Rosu", 2020);
            carFactory.CreateCar("Ford Mustang", "Albastru", 2016);
            carFactory.CreateCar("Toyota Corolla", "Alba", 2001);

            carFactory.DisplayAllCars();

            var anotherCarCreate = CarCreate.Instance;

            if (carFactory == anotherCarCreate)
            {
                Console.WriteLine("carFactory si anotherCarFactory au aceeasi instanta.");
            }
        }
    }
}