using System;

public class SUVFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new SUV();
    }
}

