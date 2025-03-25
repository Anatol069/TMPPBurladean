using System;

public class SportsCarFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new SportsCar();
    }
}
