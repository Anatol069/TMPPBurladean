using System;
using System.Collections.Generic;

namespace CarSingleton
{
    public class CarCreate
    {
        private static readonly Lazy<CarCreate> _instance = new Lazy<CarCreate>(() => new CarCreate());

        private List<Car> _cars = new List<Car>();

        private CarCreate() { }

        public static CarCreate Instance => _instance.Value;

        public Car CreateCar(string model, string color, int year)
        {
            var car = new Car(model, color, year);
            _cars.Add(car);
            Console.WriteLine($"Creem un nou automobil: {car}");
            return car;
        }

        public void DisplayAllCars()
        {
            Console.WriteLine("Lista tuturor automobilelor:");
            foreach (var car in _cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}