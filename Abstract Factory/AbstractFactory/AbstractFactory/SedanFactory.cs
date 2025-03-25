using System;

public class SedanFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new Sedan();
    }
}
