using System;

public class CarClient
{
    private readonly ICar _car;

    public CarClient(ICarFactory factory)
    {
        _car = factory.CreateCar();
    }

    public void TestDrive()
    {
        _car.Drive();
    }
}
